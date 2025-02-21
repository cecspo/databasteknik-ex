using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class StatusCodeRepository(DataContext context) : BaseRepository<StatusCodeEntity>(context), IStatusCodeRepository
{
    public override async Task<IEnumerable<StatusCodeEntity>> GetAllAsync()
    {
        var entites = await _db.Include(p => p.Projects).ToListAsync();
        return entites;
    }

    public override async Task<StatusCodeEntity?> GetAsync(Expression<Func<StatusCodeEntity, bool>> expression)
    {
        var entity = await _db.Include(p => p.Projects).FirstOrDefaultAsync(expression);
        return entity;
    }
}