namespace Ex1___Polymorphism;

public class PartTimeEmployee(int hours, double wage, string name) : Employee
{
    public string Name { get; set; } = name;

    private int hoursPermonth = hours;
    private double hourlyWage = wage;

    public double GetMonthlySalary()
    {
        return hoursPermonth * hourlyWage;
    }
}