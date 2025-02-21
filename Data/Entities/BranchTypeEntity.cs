namespace Data.Entities;

public class BranchTypeEntity
{
    public int Id { get; set; }

    public string BranchTypeName { get; set; } = null!;

    public ICollection<CustomerEntity> Customers { get; set; } = [];
}
