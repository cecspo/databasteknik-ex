using Data.Entities;

namespace Data.Tests.SeedData;

public static class TestData
{
    public static readonly StatusCodeEntity[] StatusCodeTestData =
    [
        new StatusCodeEntity {Id = 1, StatusCodeName = "Ej påbörjad"},
        new StatusCodeEntity {Id = 2, StatusCodeName = "Pågår"},
        new StatusCodeEntity {Id = 3, StatusCodeName = "Avslutad"}
    ];

    public static readonly CustomerEntity[] CustomerTestData =
    [
        new CustomerEntity {Id = 1, CustomerName = "IKEA", CustomerContactId = CustomerContactTestData[1].Id, CustomerTypeId = CustomerTypeTestData[1], BranchTypeId = BranchTypeTestData[1]},
        new CustomerEntity {CustomerName = "Nackademin AB", CustomerContactId = CustomerContactTestData[1], CustomerTypeId = CustomerTypeTestData[1], BranchTypeId = BranchTypeTestData[1]},
        new CustomerEntity {CustomerName = "Ekofront AB", CustomerContactId = CustomerContactTestData[1], CustomerTypeId = CustomerTypeTestData[1], BranchTypeId = BranchTypeTestData[1]}
    ];

    public static readonly EmployeeEntity[] EmployeeNamesTestData =
    [
        new EmployeeEntity {FirstName = "Anton", LastName = "Haglund", Email = "anton@domain.com"},
        new EmployeeEntity {FirstName = "Cecilia", LastName = "Sporrong", Email = "ccf@domain.com"},
        new EmployeeEntity {FirstName = "Céline", LastName = "Haglund Sporrong", Email = "cello@domain.com"},
    ];

    public static readonly ServiceEntity[] ServiceTestData =
    [
        new ServiceEntity {Service = "Konsulttjänst"},
        new ServiceEntity {Service = "Utbildning"},
        new ServiceEntity {Service = "Support"}
    ];

    public static readonly PaymentEntity[] PaymentTestData =
    [
        new PaymentEntity {PaymentMethods = "Faktura"},
        new PaymentEntity {PaymentMethods = "Kreditkort"},
        new PaymentEntity {PaymentMethods = "Swish"}
    ];

    public static readonly ProjectManagerEntity[] ProjectManagerTestData =
    [
        new ProjectManagerEntity {ProjectManagerId = EmployeeNamesTestData[0].EmployeeId}
    ];

    public static readonly ProjectCommentEntity[] ProjectCommentTestData =
    [
        new ProjectCommentEntity {CommentText = "Bra jobbat!" },
        new ProjectCommentEntity {CommentText = "Du behöver göra om!"},
        new ProjectCommentEntity {CommentText = "Det här behövs inte!"}
    ];

    public static readonly ProjectDocumentEntity[] ProjectDocumentTestData =
    [
        new ProjectDocumentEntity {DocumentName = "Projektplan"},
        new ProjectDocumentEntity {DocumentName = "Tidsrapport"},
        new ProjectDocumentEntity {DocumentName = "Faktura"}
    ];

    public static readonly ProjectEntity[] ProjectTestData =
    {
        new ProjectEntity {
            ProjectName = "Databasteknik",
            Notes = "Kurs i databasteknik",
            CreatedAt = new DateTime(2025, 02, 03),
            UpdatedAt = new DateTime(2025, 02, 03),
            CustomerNumber = CustomerNumberTestData[1],
            ProjectManagerId = ProjectManagerTestData[1],
            PaymentId = PaymentTestData[1],
            StatusId = StatusTestData[1].Id,
            ServiceId = ServiceTestData[1].Id,

        }
    };
}
