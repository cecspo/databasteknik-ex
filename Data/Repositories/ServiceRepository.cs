using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class ServiceRepository (DataContext context) : BaseRepository<ServiceEntity>(context), IServiceRepository
{
    public override async Task<IEnumerable<ServiceEntity>> GetAllAsync()
    {
        var entites = await _db.Include(p => p.Projects).ToListAsync();
        return entites;
    }

    public override async Task<ServiceEntity?> GetAsync(Expression<Func<ServiceEntity, bool>> expression)
    {
        var entity = await _db.Include(p => p.Projects).FirstOrDefaultAsync(expression);
        return entity;
    }
}
