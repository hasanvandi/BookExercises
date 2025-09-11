int counter = 0;
bool isValied = false;
const int hourPerWeek = 40;
while (!isValied)
{
    Console.Write($"Dear employee{counter +1},please enter your woking hours per week:");
    int workingHoursPerWeek = int.Parse(Console.ReadLine());

    Console.Write("Enter the hourly wage rate:");
    decimal hourlyWage = decimal.Parse(Console.ReadLine());

    if(workingHoursPerWeek > hourPerWeek)
    {
       int input = (workingHoursPerWeek - hourPerWeek) /2;
       int overtimeWork = workingHoursPerWeek - input;
       decimal result = overtimeWork * hourlyWage;
       Console.WriteLine($"Employee,s income this week:{result}");

        counter++;
        if(counter == 3)
        {
            isValied = true;
        }
    }
    else
    {
        decimal result = workingHoursPerWeek * hourlyWage;
        Console.WriteLine($"Employee,s income this week::{result}");
        counter++;
        if(counter == 3)
        {
            isValied = true;
        }
    }
}



Console.ReadLine();