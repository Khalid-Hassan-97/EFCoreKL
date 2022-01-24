using EFCoreAIGS.Data.Entities;
using EFCoreAIGS.UI;

var executionLogic = new ExecutionLogic();

var spendingDetails = new List<SpendingDetail>()
{
    new SpendingDetail()
    {
        Amount = 1000,
        SpentOn = "PC"
    },
    new SpendingDetail()
    {
        Amount = 2000,
        SpentOn = "House"
    }
};

var employee = new Employee()
{
    FirstName = "Ahmed",
    LastName = "Yasser",
    SpendingDetails = spendingDetails

};

executionLogic.AddEmployee(employee);

executionLogic.PrintAllEmployees();

var emp = executionLogic.GetEmployeeByFirstName("Ahmed");
if (emp != null)
{
    emp.TotalSpendings = emp.SpendingDetails.Sum(sd => sd.Amount);
    Console.WriteLine(emp.TotalSpendings);
}
Console.WriteLine("Done!");


