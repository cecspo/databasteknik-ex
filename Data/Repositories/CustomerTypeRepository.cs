using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class CustomerTypeRepository(DataContext context) : BaseRepository<CustomerTypeEntity>(context), ICustomerTypeRepository
{
    public override async Task<IEnumerable<CustomerTypeEntity>> GetAllAsync()
    {
        var entites = await _db.Include(c => c.Customers).ToListAsync();
        return entites;
    }

    public override async Task<CustomerTypeEntity?> GetAsync(Expression<Func<CustomerTypeEntity, bool>> expression)
    {
        var entity = await _db.Include(c => c.Customers).FirstOrDefaultAsync(expression);
        return entity;
    }
}