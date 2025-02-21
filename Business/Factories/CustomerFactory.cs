using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class CustomerFactory
{
    public static CustomerEntity? Create(CustomerRegistrationForm form) => form == null ? null : new()
    {
        CustomerName = form.CustomerName
    };

    public static Customer? Create(CustomerEntity entity)
    {
        if (entity == null)
            return null;

        var customer = new Customer()
        {
            Id = entity.Id,
            CustomerName = entity.CustomerName,
            Projects = []
        };

        if (entity.Projects != null)
        {
            var projects = new List<Project>();

            foreach (var project in entity.Projects)
                projects.Add(new Project
                {
                    ProjectNumber = project.ProjectNumber,
                    ProjectName = project.ProjectName,
                    Notes = project.Notes
                });
        }

        return customer;
    }
}
