using Data.Repositories;
using Data.Tests.SeedData;

namespace Data.Tests.Repositories_Tests;

public class CustomerContactRepository_Tests
{
    [Fact]
    public async Task CreateAsync_ShouldCreateCustomerContact()
    {
        var context = DataContextSeeder.GetDataContext();
        var customerContactRepository = new CustomerContactRepository(context);

        var result = await customerContactRepository.CreateAsync(TestData.CustomerContactTestData[0]);

        Assert.NotEqual(1, result!.Id);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnAllStatusCodes()
    {
        var context = DataContextSeeder.GetDataContext();
        var customerContactRepository = new CustomerContactRepository(context);

        await context.AddRangeAsync(TestData.CustomerContactTestData);
        await context.SaveChangesAsync();

        var result = await customerContactRepository.GetAllAsync();

        Assert.Equal(TestData.CustomerContactTestData.Length, result.Count());
    }

    [Fact]
    public async Task GetAsync_ShouldReturnStatusCode()
    {
        var context = DataContextSeeder.GetDataContext();
        await context.AddRangeAsync(TestData.CustomerContactTestData);
        await context.SaveChangesAsync();

        var customerContactRepository = new CustomerContactRepository(context);

        var result = await customerContactRepository.GetAsync(x => x.Customers == TestData.CustomerContactTestData[0].Customers);

        Assert.Equal(TestData.CustomerContactTestData[0].Customers, result!.Customers);
    }

    [Fact]
    public async Task UpdateAsync_ShouldReturnTrue()
    {
        var context = DataContextSeeder.GetDataContext();
        await context.AddRangeAsync(TestData.CustomerContactTestData);
        await context.SaveChangesAsync();

        var customerContactRepository = new CustomerContactRepository(context);
        var customerContactsEntity = TestData.CustomerContactTestData[0];

        customerContactsEntity.Customers = "Nicklas Tiger";
        var result = await customerContactRepository.UpdateAsync(customerContactsEntity);

        Assert.True(result);
    }

    [Fact]
    public async Task RemoveAsync_ShouldReturnTrue()
    {
        var context = DataContextSeeder.GetDataContext();
        await context.AddRangeAsync(TestData.CustomerContactTestData);
        await context.SaveChangesAsync();

        var customerContactRepository = new CustomerContactRepository(context);
        var customerContactsEntity = TestData.CustomerContactTestData[0];

        var result = await customerContactRepository.RemoveAsync(customerContactsEntity);

        Assert.True(result);
    }
}
