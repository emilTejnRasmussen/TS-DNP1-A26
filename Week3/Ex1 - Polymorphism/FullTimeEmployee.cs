namespace Ex1___Polymorphism;

public class FullTimeEmployee(double salary, string name) : Employee
{
    public string Name { get; set; } = name;

    private double monthlySalary = salary;

    public double GetMonthlySalary()
    {
        return 37 * 4 * monthlySalary;
    }
}