namespace Data.Entities;

public class ServiceEntity
{
    public int Id { get; set; }

    public string Service { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
