using ConsoleTables;
using E_commerce_Payment_Proccesing.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_Payment_Proccesing.Userinterface;

public class UserInterface
{
    private readonly int TableWidth = 80;

    public void DisplayProudectsAutomatic(List<Root> proudects)
    {
        foreach (var proudect in proudects)
        {
            var table = new ConsoleTable("Id", "Name", "Price");
            foreach (var item in proudect.products)
            {
                table.AddRow(item.id, item.name, item.price);
            }
        }



    }
    public void DisplayProudectsManual(List<Root> proudects)
    {

        Console.WriteLine($" | {"ID",-5} | {"Name",-30} |{"Price",-10} ");

        Console.WriteLine(new string('-', TableWidth));

        foreach (var itemRowa in proudects)
        {
            foreach (var p in itemRowa.products)
            {
                Console.WriteLine($"| {p.id,-5} | {p.name,-30} | {p.price,-10} |");
                Console.WriteLine(new string('-', TableWidth));
            }





        }






    }




}
