using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class ProjectFactory
{

    public static ProjectEntity? Create(ProjectRegistrationForm form) => form == null ? null : new()
    {
        ProjectName = form.ProjectName,
        Notes = form.Notes
    };

    public static Project? Create(ProjectEntity entity)
    {
        if (entity == null)
            return null;

        var project = new Project
        {
            CustomerNumber = entity.CustomerNumber,
            ProjectName = entity.ProjectName,
            Notes = entity.Notes,
            StatusId = entity.StatusId
        };

        if (entity.Customers != null)
        {
            var customers = new List<Customer>();

            foreach (var customer in entity.Customers)
                project.Add(new Customer
                {
                    Id = entity.Customers.Id,
                    CustomerName = entity.Customers.CustomerName,
                });            
        }

        return project;
    }
}