using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class PostalCodeRepository(DataContext context) : BaseRepository<PostalCodeEntity>(context), IPostalCodeRepository
{
    public override async Task<IEnumerable<PostalCodeEntity>> GetAllAsync()
    {
        var entites = await _db.Include(a => a.Addresses).ToListAsync();
        return entites;
    }

    public override async Task<PostalCodeEntity?> GetAsync(Expression<Func<PostalCodeEntity, bool>> expression)
    {
        var entity = await _db.Include(a => a.Addresses).FirstOrDefaultAsync(expression);
        return entity;
    }
}
