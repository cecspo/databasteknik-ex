namespace Data.Entities;

public class StatusCodeEntity
{
    public int Id { get; set; }

    public string StatusCodeName { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
