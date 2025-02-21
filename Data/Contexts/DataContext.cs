using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected DataContext()
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
  
    public DbSet<BranchTypeEntity> BranchTypes { get; set; }
 
    public DbSet<CustomerContactEntity> CustomerContacts { get; set; }
   
    public DbSet<CustomerEntity> Customers { get; set; }
  
    public DbSet<CustomerTypeEntity> CustomerTypes { get; set; }
   
    public DbSet<EmployeeEntity> Employees { get; set; }
   
    public DbSet<PaymentEntity> Payments { get; set; }

    public DbSet<PostalCodeEntity> PostalCodes { get; set; }
 
    public DbSet<ProjectCommentEntity> ProjectComments { get; set; }
   
    public DbSet<ProjectDocumentEntity> ProjectDocuments { get; set; }
 
    public DbSet<ProjectEntity> Projects { get; set; }
  
    public DbSet<ProjectManagerEntity> ProjectManagers { get; set; }
  
    public DbSet<ProjectScheduleEntity> ProjectSchedules { get; set; }
   
    public DbSet<ServiceEntity> Services { get; set; }
   
    public DbSet<StatusCodeEntity> StatusCodes { get; set; }
}

