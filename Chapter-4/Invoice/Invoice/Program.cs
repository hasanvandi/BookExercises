namespace Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new()
            {
                PartNumber = 1,
                Descrioption ="laptop",
                NumberOfPieces = 4,
                Price = 600
            };
            Console.WriteLine(invoice.InvoiceAmount());

            Console.ReadLine();
        }
    }
}
