using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class ProjectScheduleRepository (DataContext context) : BaseRepository<ProjectScheduleEntity>(context), IProjectScheduleRepository
{
    public override async Task<IEnumerable<ProjectScheduleEntity>> GetAllAsync()
    {
        var entites = await _db.Include(p => p.Projects).ToListAsync();
        return entites;
    }

    public override async Task<ProjectScheduleEntity?> GetAsync(Expression<Func<ProjectScheduleEntity, bool>> expression)
    {
        var entity = await _db.Include(p => p.Projects).FirstOrDefaultAsync(expression);
        return entity;
    }
}
