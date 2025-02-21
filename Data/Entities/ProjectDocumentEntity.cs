namespace Data.Entities;

public class ProjectDocumentEntity
{
    public int Id { get; set; }

    public string DocumentName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string UploadedBy { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public ProjectEntity Projects { get; set; } = null!;

    public EmployeeEntity Employees { get; set; } = null!;
}
