namespace Data.Entities;

public class ProjectScheduleEntity
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
