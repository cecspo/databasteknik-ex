﻿using Data.Contexts;
using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class CustomerRepository(DataContext context) : BaseRepository<CustomerEntity>(context), ICustomerRepository
{
    public override async Task<CustomerEntity?> GetAsync(Expression<Func<CustomerEntity, bool>> expression)
    {
        var entity = await _db.Include(p => p.Projects).FirstOrDefaultAsync(expression);
        return entity;
    }
}
