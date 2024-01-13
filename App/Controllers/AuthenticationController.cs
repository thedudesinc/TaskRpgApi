using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TaskRpg.Domain.Abstractions.Services;
using TaskRpgApi.App.Responses;
using TaskRpgApi.Domain.Abstractions.Services;
using TaskRpgApi.Domain.Models;

namespace TaskRpgApi.App.Controllers;

[ApiController]
[Route("api/authentication")]

public class AuthenticationController
{
    private readonly IConfiguration _configuration;
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserService _userService;

    public AuthenticationController(IConfiguration configuration, IAuthenticationService authenticationService, IUserService userService)
    {
        _configuration = configuration;
        _authenticationService = authenticationService;
        _userService = userService;
    }

    [HttpPost]
    [Route("login")]
    [AllowAnonymous]
    public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginInput user, CancellationToken ct)
    {
        var userResponse = await _authenticationService.Authenticate(user, ct) ?? throw new HttpRequestException("unauthorized", null, HttpStatusCode.Unauthorized);
        var issuer = _configuration.GetValue<string>("Jwt:Issuer");
        var audience = _configuration.GetValue<string>("Jwt:Audience");
        var key = _configuration.GetValue<string>("Jwt:Key") ?? throw new HttpRequestException("missing configuration", null, HttpStatusCode.InternalServerError);
        var encodedKey = Encoding.ASCII.GetBytes(key);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("Id", userResponse.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
             }),
            Expires = DateTime.UtcNow.AddMinutes(30),
            Issuer = issuer,
            Audience = audience,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(encodedKey), SecurityAlgorithms.HmacSha512Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var stringToken = tokenHandler.WriteToken(token);
        var loginResponse = new LoginResponse()
        {
            Id = userResponse.Id,
            DisplayName = userResponse.DisplayName,
            Email = userResponse.Email,
            StringToken = stringToken
        };
        return loginResponse;
    }
}
