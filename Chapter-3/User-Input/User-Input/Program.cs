Console.WriteLine("hello every body...");
int num01 = GetNumber("first");
int num02 = GetNumber("secound");

int sumNumbers = num01 + num02;
int subNumbers = num01 - num02;
int multNumbers = num01 * num02;
int divNumbers = num01 / num02;

PrinNumber("sum is", sumNumbers);
PrinNumber("sub is",subNumbers);
PrinNumber("multiple is", multNumbers);
PrinNumber("divece is", divNumbers);

 
Console.ReadLine();

int GetNumber(string numberOrder)
{
    Console.Write("Plese Enter " + numberOrder +" number:");
    return int.Parse(Console.ReadLine());
}


void PrinNumber(string input,int result)
{
    Console.WriteLine(input +":"+ result);
}