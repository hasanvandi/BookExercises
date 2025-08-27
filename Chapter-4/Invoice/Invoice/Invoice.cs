

namespace Invoice;

public class Invoice
{
    public int PartNumber;
    public string Descrioption;
    public int NumberOfPieces;
    public int Price;


    public int GetPartNumber()
    {
        return PartNumber;
    }
    public void SetPartNumber(int value)
    {
        PartNumber = value;
    }


    public string GetDescrioption()
    {
        return Descrioption;
    }
    public void SetDescrioption(string value)
    {
        if(Descrioption != null)
        {
            Descrioption = value;
        }
        Descrioption = "please enter descrioption";
    }



    public int GetNumberOfPieces()
    {
      return NumberOfPieces;
    }
    public void SetNumberOfPieces(int value)
    {
        if (PartNumber < 0)
        {
            PartNumber = 0;
        }
        NumberOfPieces = value;
    }



    public int GetPrice()
    {
        return Price;
    }
    public void SetPrice(int value)
    {
       if(Price < 0)
        {
            Price = 0;
        }
       Price = value;
    }




    public int InvoiceAmount()
    {
        return NumberOfPieces * Price;
    }
}

