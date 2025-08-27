namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("mahdi","hasanvandi",2500);
            Employee employee1 = new Employee("alireza","oroumand",22000);


            
            employee.ShowYearlySalary();
            employee.ShowSalary();
            Console.WriteLine("-----------------------------------");
            employee1.ShowYearlySalary();
            employee1.ShowSalary();
          
            

            Console.ReadLine();
        }
    }
}
