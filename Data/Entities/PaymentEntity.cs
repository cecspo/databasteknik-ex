namespace Data.Entities;

public class PaymentEntity
{
    public int Id { get; set; }

    public string PaymentMethods { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;

    public DateTime? PayedAt { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}
