using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class CustomerContactRepository(DataContext context) : BaseRepository<CustomerContactEntity>(context), ICustomerContactRepository
{
    public override async Task<IEnumerable<CustomerContactEntity>> GetAllAsync()
    {
        var entites = await _db.Include(c => c.Customers).ToListAsync();
        return entites;
    }

    public override async Task<CustomerContactEntity?> GetAsync(Expression<Func<CustomerContactEntity, bool>> expression)
    {
        var entity = await _db.Include(c => c.Customers).FirstOrDefaultAsync(expression);
        return entity;
    }
}