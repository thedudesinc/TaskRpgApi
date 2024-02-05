using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskRpg.Domain.Abstractions.Services;
using TaskRpgApi.Domain.Models;

namespace TaskRpgApi.App.Controllers;

[Authorize]
[ApiController]
[Route("api/character")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _service;

    public CharacterController(ICharacterService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<CharacterOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<CharacterOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpGet]
    [Route("getByUserId")]
    public async Task<CharacterOutput> GetByUserId(CancellationToken ct)
    {
        var id = Guid.Parse(HttpContext.User.Claims.Single(u => u.Type == "Id").Value);
        return await _service.GetByUserId(id, ct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<CharacterOutput>> Create([FromBody] CharacterInput character, CancellationToken ct)
    {
        return await _service.Create(character, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<CharacterOutput>> Update(Guid id, [FromBody] CharacterInput character, CancellationToken ct)
    {
        return await _service.Update(id, character, ct);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }
}


