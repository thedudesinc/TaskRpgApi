using AutoMapper;
using TaskRpgApi.Domain.Models.Inputs;
using TaskRpgApi.Domain.Models.Outputs;
using TaskRpgApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using TaskRpgApi.Domain.Abstractions;
using TaskRpgApi.Persistance.Entities;

namespace TaskRpgApi.Persistance.Repositories;

public class UserRepository : GenericRepository<User, UserInput, UserOutput>, IUserRepository
{
    public UserRepository(TaskRpgContext context, IMapper mapper) : base(context, mapper)
    {

    }

    public new async Task<UserOutput> Update(Guid id, UserInput input, CancellationToken ct)
    {
        var existing = await _context.Set<User>().SingleAsync(e => e.Id == id, ct);

        var entity = _mapper.Map(input, existing);

        entity.DateModified = DateTime.Now;

        _context.Set<User>().Update(entity);

        if (string.IsNullOrEmpty(input.Password))
        {
            _context.Entry(entity).Property(entity => entity.Password).IsModified = false;
        }

        await _context.SaveChangesAsync(ct);

        return (UserOutput)_mapper.Map(entity, entity.GetType(), typeof(UserOutput));

    }

}
