using Data.Entities;

namespace Business.Models;

public class Project
{
    public int ProjectNumber { get; set; }

    public string ProjectName { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int CustomerNumber { get; set; }

    public int ProjectManagerId { get; set; }

    public int PaymentId { get; set; }

    public int StatusId { get; set; }

    public int ServiceId { get; set; }

    public CustomerEntity Customers { get; set; } = null!;

    public ProjectScheduleEntity ProjectSchedules { get; set; } = null!;

    public ProjectManagerEntity ProjectManagers { get; set; } = null!;

    public StatusCodeEntity StatusCodes { get; set; } = null!;

    public ServiceEntity Services { get; set; } = null!;

    public PaymentEntity Payments { get; set; } = null!;

    public ICollection<ProjectCommentEntity> ProjectComments { get; set; } = [];

    public ICollection<ProjectCommentEntity> ProjectDocuments { get; set; } = [];
}