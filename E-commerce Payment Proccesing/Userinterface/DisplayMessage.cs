using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_Payment_Proccesing.Userinterface;

public interface IDisplayMessage
{
    void Display(string message);
}

public class DisplayMessage : IDisplayMessage
{
    public void Display(string message)
    {
        Console.WriteLine(message);
    }
    public void displayPaymnet()
    {
        Console.WriteLine("Chosse The Way You Want To Payment ");
        Console.WriteLine("1- Credit Card");
        Console.WriteLine("2- PayPal");
        Console.WriteLine("3- Digital Wallet");
    }

}
