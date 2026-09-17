namespace Ex1___Polymorphism;

public class Company
{
    private List<Employee> _employees = [];

    public double GetMonthlySalaryTotal()
    {
        return _employees.Sum(employee => employee.GetMonthlySalary());
    }

    public void HireNewEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void DisplayMostExpensiveEmployee()
    {
        var ballerEmployee = _employees.MaxBy(employee => employee.GetMonthlySalary());

        if (ballerEmployee is null) throw new Exception("..");

        Console.WriteLine(
            $"""
            Name:     {ballerEmployee.Name}
            Salary:   {ballerEmployee.GetMonthlySalary()}
            """
            );
    }
    
}