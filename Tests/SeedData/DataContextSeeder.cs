using Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Data.Tests.SeedData;

public class DataContextSeeder
{
    public static DataContext GetDataContext()
    {
        var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        var context = new DataContext(options);
        context.Database.EnsureCreated();

        return context;
    }

    public static async Task SeedAsync(DataContext context)
    {
        context.Customers.AddRange(TestData.CustomerTestData);

        context.Employees.AddRange(TestData.EmployeeNamesTestData);

        context.StatusCodes.AddRange(TestData.StatusCodeTestData);

        await context.SaveChangesAsync();
    }


    public static async Task SeedWithProjectAsync(DataContext context)
    {
        context.Customers.AddRange(TestData.CustomerTestData);

        context.Employees.AddRange(TestData.EmployeeNamesTestData);

        context.Projects.AddRange(TestData.ProjectTestData);

        context.StatusCodes.AddRange(TestData.StatusCodeTestData);

        await context.SaveChangesAsync();
    }
}
