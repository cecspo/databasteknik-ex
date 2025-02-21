using Data.Entities;

namespace Business.Models;

public class StatusCode
{
    public int Id { get; set; }

    public string StatusCodeName { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
