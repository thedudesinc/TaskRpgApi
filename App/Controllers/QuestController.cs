using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskRpg.Domain.Abstractions.Services;
using TaskRpgApi.Domain.Models;

namespace TaskRpgApi.App.Controllers;

[Authorize]
[ApiController]
[Route("api/quest")]
public class QuestController
{
    private readonly IQuestService _service;

    public QuestController(IQuestService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<QuestOutput>> Get(CancellationToken ct)
    {
        return await _service.Get(ct);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<QuestOutput>> Get(Guid id, CancellationToken ct)
    {
        return await _service.Get(id, ct);
    }

    [HttpGet]
    [Route("getByUserId/{id}")]
    public async Task<IEnumerable<QuestOutput>> GetByUserId(Guid id, CancellationToken ct)
    {
        return await _service.GetByUserId(id, ct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    public async Task<ActionResult<QuestOutput>> Create([FromBody] QuestInput quest, CancellationToken ct)
    {
        return await _service.Create(quest, ct);
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<QuestOutput>> Update(Guid id, [FromBody] QuestInput quest, CancellationToken ct)
    {
        return await _service.Update(id, quest, ct);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _service.Delete(id, ct);
    }
}


