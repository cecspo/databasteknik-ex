using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class ProjectManagerRepository(DataContext context) : BaseRepository<ProjectManagerEntity>(context), IProjectManagerRepository
{
    public override async Task<IEnumerable<ProjectManagerEntity>> GetAllAsync()
    {
        var entites = await _db.Include(p => p.Projects).Include(e => e.Employees).ToListAsync();
        return entites;
    }

    public override async Task<ProjectManagerEntity?> GetAsync(Expression<Func<ProjectManagerEntity, bool>> expression)
    {
        var entity = await _db.Include(p => p.Projects).Include(e => e.Employees).FirstOrDefaultAsync(expression);
        return entity;
    }
}
