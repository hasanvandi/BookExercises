int countPlas = 0;
int countBlas= 0;
int countZero = 0;
for(int i = 0; i < 5; i++)
{
    Console.Write($"Plese Enter number{i + 1}:");
    string input = Console.ReadLine();
    int number;
    bool successes = int.TryParse( input, out number );
    if (successes)
    {
        if(number == 0)
        {
            countZero++;
        }
        else if(number > 0)
        {
            countPlas++;
        }
        else
        {
            countBlas++;
        }
    }
    else
    {
        Console.WriteLine("please enter number correct");
        i--;
        continue;

    }
}


Console.WriteLine("0 is:" + countZero);
Console.WriteLine("+ is:" + countPlas);
Console.WriteLine("- is:" + countBlas);

Console.ReadLine();