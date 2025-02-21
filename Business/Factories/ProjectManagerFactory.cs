using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class ProjectManagerFactory
{
    public static ProjectManagerEntity? Create(ProjectManagerRegistrationForm form) => form == null ? null : new()
    {
        ProjectManagerId = form.ProjectManagerId,
        EmployeeId = form.EmployeeId
    };

    public static ProjectManager? Create(ProjectManagerEntity entity)
    {
        if (entity == null)
            return null;

        var projectManager = new ProjectManager()
        {
            ProjectManagerId = entity.ProjectManagerId,
            EmployeeId = entity.EmployeeId,
            Projects = []
        };

        if (entity.Projects != null)
        {
            var projects = new List<Project>();
            foreach (var project in entity.Projects)
            {
                projects.Add(new Project
                {
                    ProjectNumber = project.ProjectNumber,
                    ProjectName = project.ProjectName
                });
            }
        }

        return projectManager;
    }
}