using Data.Entities;

namespace Business.Models;

public class ProjectManager
{
    public int ProjectManagerId { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];

    public int EmployeeId { get; set; }

    public EmployeeEntity Employees { get; set; } = null!;
}
