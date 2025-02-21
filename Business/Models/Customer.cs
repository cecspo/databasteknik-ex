using Data.Entities;

namespace Business.Models;

public class Customer
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public int CustomerContactId { get; set; }

    public int CustomerTypeId { get; set; }

    public int BranchTypeId { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];

    public BranchTypeEntity BranchTypes { get; set; } = null!;

    public CustomerContactEntity CustomerContacts { get; set; } = null!;

    public CustomerTypeEntity CustomerTypes { get; set; } = null!;
}
