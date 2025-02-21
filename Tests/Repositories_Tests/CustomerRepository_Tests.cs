using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class CustomerRepository_Tests
{
    private DataContext GetDataContext()
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new DataContext(options);
        context.Database.EnsureCreated();
        return context;
    }

    [Fact]
    public async Task GetCustomerAsync_ShouldReturnAllCustomers()
    {
        var context = GetDataContext();
        context.Customers.AddRange(TestData.CustomerNamesTestData);
        await context.SaveChangesAsync();

        ICustomerRepository repository = new CustomerRepository(context);

        var result = await repository.GetAllAsync();

        Assert.True(result.Count() == TestData.CustomerNamesTestData.Count());
    }
}
