using System.ComponentModel.DataAnnotations;

namespace EFCoreAIGS.Data.Entities;

public class SpendingDetail
{
    [Key]
    public int SpendingDetailId { get; set; }
    public string SpentOn { get; set; }
    public decimal Amount { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}

