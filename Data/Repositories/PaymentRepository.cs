using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class PaymentRepository(DataContext context) : BaseRepository<PaymentEntity>(context), IPaymentRepository
{
    public override async Task<IEnumerable<PaymentEntity>> GetAllAsync()
    {
        var entites = await _db.Include(p => p.Projects).ToListAsync();
        return entites;
    }

    public override async Task<PaymentEntity?> GetAsync(Expression<Func<PaymentEntity, bool>> expression)
    {
        var entity = await _db.Include(p => p.Projects).FirstOrDefaultAsync(expression);
        return entity;
    }
}