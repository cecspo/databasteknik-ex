using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class ProjectRepository (DataContext context) : BaseRepository<ProjectEntity>(context), IProjectRepository
{
    public override async Task<IEnumerable<ProjectEntity>> GetAllAsync()
    {
        var entites = await _db
            .Include(c => c.Customers)
            .Include(p => p.ProjectSchedules)
            .Include(p => p.ProjectManagers)
            .Include(s => s.StatusCodes)
            .Include(s => s.Services)
            .Include(p => p.ProjectComments)
            .Include(p => p.ProjectDocuments)
            .Include(p => p.Payments)
            .ToListAsync();
        return entites;
    }

    public override async Task<ProjectEntity?> GetAsync(Expression<Func<ProjectEntity, bool>> expression)
    {
        var entity = await _db.Include(c => c.Customers).FirstOrDefaultAsync(expression);
        return entity;
    }
}
