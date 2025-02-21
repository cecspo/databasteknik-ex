namespace Data.Entities;

public class ProjectCommentEntity
{
    public int Id { get; set; }

    public string CommentText { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public ProjectEntity Projects { get; set; } = null!;

    public EmployeeEntity Employees { get; set; } = null!;
}
