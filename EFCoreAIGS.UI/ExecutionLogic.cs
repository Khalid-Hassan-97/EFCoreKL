using EFCoreAIGS.Data;
using EFCoreAIGS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAIGS.UI;

public class ExecutionLogic
{
    public void AddEmployee(Employee employee)
    {
        using var db = new AIGSContext();
        db.Employees.Add(employee);
        db.SaveChanges();
    }

    public Employee? GetEmployeeByFirstName(string firstName)
    {
        using var db = new AIGSContext();
        return db.Employees.Include(e => e.SpendingDetails).FirstOrDefault(e => e.FirstName == firstName);
    }

    public void AddSpendingDetail(SpendingDetail spendingDetail)
    {
        using var db = new AIGSContext();
        db.SpendingDetails.Add(spendingDetail);
        db.SaveChanges();
    }

    public SpendingDetail? GetSpendingDetailBySpentON(string spentOn)
    {
        using var db = new AIGSContext();
        return db.SpendingDetails.FirstOrDefault(sd => sd.SpentOn == spentOn);
    }

    public void AddEmployee(List<Employee> employees)
    {
        using var db = new AIGSContext();
        db.Employees.AddRange(employees);
        db.SaveChanges();
    }

    public void AddSpendingDetail(List<SpendingDetail> spendingDetails)
    {
        using var db = new AIGSContext();
        db.SpendingDetails.AddRange(spendingDetails);
        db.SaveChanges();
    }

    public void PrintAllEmployees()
    {
        using var db = new AIGSContext();
        var employees = db.Employees.AsNoTracking().ToList();
        Console.WriteLine($"{"FirstName", -20}{"LastName",-20}{"HireDate",-10}");
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName, -20}{employee.LastName, -20}{employee.Hired, -10}");
        }
    }
}

