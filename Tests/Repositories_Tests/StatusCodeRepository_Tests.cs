using Data.Repositories;
using Data.Tests.SeedData;

namespace Data.Tests.Repositories_Tests;

public class StatusCodeRepository_Tests
{
    [Fact]
    public async Task CreateAsync_ShouldCreateStatusCode()
    {
        var context = DataContextSeeder.GetDataContext();
        var statusCodeRepository = new StatusCodeRepository(context);

        var result = await statusCodeRepository.CreateAsync(TestData.StatusCodeTestData[0]);

        Assert.NotEqual(1, result!.Id);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnAllStatusCodes()
    {
        var context = DataContextSeeder.GetDataContext();
        var statusCodeRepository = new StatusCodeRepository(context);

        await context.AddRangeAsync(TestData.StatusCodeTestData);
        await context.SaveChangesAsync();

        var result = await statusCodeRepository.GetAllAsync();

        Assert.Equal(TestData.StatusCodeTestData.Length, result.Count());
    }

    [Fact]
    public async Task GetAsync_ShouldReturnStatusCode()
    {
        var context = DataContextSeeder.GetDataContext();
        await context.AddRangeAsync(TestData.StatusCodeTestData);
        await context.SaveChangesAsync();

        var statusCodeRepository = new StatusCodeRepository(context);

        var result = await statusCodeRepository.GetAsync(x => x.StatusCodeName == TestData.StatusCodeTestData[0].StatusCodeName);

        Assert.Equal(TestData.StatusCodeTestData[0].StatusCodeName, result!.StatusCodeName);
    }

    [Fact]
    public async Task UpdateAsync_ShouldReturnTrue()
    {
        var context = DataContextSeeder.GetDataContext();
        await context.AddRangeAsync(TestData.StatusCodeTestData);
        await context.SaveChangesAsync();

        var statusCodeRepository = new StatusCodeRepository(context);
        var statusEntity = TestData.StatusCodeTestData[0];

        statusEntity.StatusCodeName = "Ej påbörjad";
        var result = await statusCodeRepository.UpdateAsync(statusEntity);

        Assert.True(result);
    }

    [Fact]
    public async Task RemoveAsync_ShouldReturnTrue()
    {
        var context = DataContextSeeder.GetDataContext();
        await context.AddRangeAsync(TestData.StatusCodeTestData);
        await context.SaveChangesAsync();

        var statusCodeRepository = new StatusCodeRepository(context);
        var statusEntity = TestData.StatusCodeTestData[0];

        var result = await statusCodeRepository.RemoveAsync(statusEntity);

        Assert.True(result);
    }
}