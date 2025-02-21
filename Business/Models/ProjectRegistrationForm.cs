namespace Business.Models;

public class ProjectRegistrationForm
{
    public string ProjectName { get; set; } = null!;

    public string? Notes { get; set; }

    public int CustomerNumber { get; set; } 
}
