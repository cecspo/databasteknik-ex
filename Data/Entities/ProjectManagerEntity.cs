using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectManagerEntity
{
    [Key]
    public int ProjectManagerId { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];

    public int EmployeeId { get; set; }

    public EmployeeEntity Employees { get; set; } = null!;
}
