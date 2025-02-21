using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Data.Tests.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.Repositories_Tests;

public class ProjectRepository_Tests
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

    private DataContext GetDataContext(DataContext context)
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new DataContext(options);
        context.Database.EnsureCreated();
        return context;
    }

    private async Task SeedData(DataContext context)
    {
        context.Customers.AddRange(TestData.CustomerTestData);
        context.Employees.AddRange(TestData.EmployeeNamesTestData);
        context.StatusCodes.AddRange(TestData.StatusCodeTestData);
        context.Projects.AddRange(TestData.ProjectTestData);
        await context.SaveChangesAsync();
    }

    private async Task SeedDataWithProject(DataContext context)
    {
        await SeedData(context);
        context.Projects.AddRange(TestData.ProjectTestData);
        await context.SaveChangesAsync();
    }

    [Fact]
    public async Task CreateAsync_ShouldCreateAndReturnProject()
    {
        var context = GetDataContext(Guid.NewGuid().ToString());

        await SeedData;
        
    }

    [Fact]
    public async Task GetAsync_ShouldReturnProject()
    {
        var context = GetDataContext();
        await SeedDataWithProject(context);

    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnAllProjects()
    {
        await SeedData();

        var context = GetDataContext();
        context.Customers.AddRange(TestData.CustomerNamesTestData);
        context.Employees.AddRange(TestData.EmployeeNamesTestData);
        context.StatusCodes.AddRange(TestData.StatusCodeTestData);
        context.Projects.AddRange(TestData.ProjectTestData);
        await context.SaveChangesAsync();
        IProjectRepository repository = new ProjectRepository(context);
        var result = await repository.GetAllAsync();
        Assert.Equal(1, result.Count());
    }
}
