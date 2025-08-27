

namespace Employee;

    public class Employee
    {
    private string _name;
    private string _lastName;

    private decimal _monthlySalary;

    const int Years = 12;
    private decimal increasePercent = 10;
    public Employee(string name,string lastName,decimal MonthlySalary)
    {
        _name = name;
        _lastName = lastName;
        _monthlySalary = MonthlySalary;
    }


    /// <summary>
    /// محاسبه حقوق سالیانه
    /// </summary>
    public void ShowYearlySalary()
    {
        Console.WriteLine($"fullname:{_name} {_lastName}");
        Console.WriteLine();
        Console.WriteLine($"YearlySalary:{_monthlySalary * Years}");
    }
    /// <summary>
    /// محاسبه حقوق سالیانه با افزایش ده درصدی
    /// </summary>
    public void ShowSalary()
    {
        Console.WriteLine($"YearlySalary with increase 10%:{_monthlySalary * (1 + increasePercent /100) * Years}");
    }
}

