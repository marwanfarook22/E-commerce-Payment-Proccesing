using ConsoleTables;
using E_commerce_Payment_Proccesing.Service;


namespace E_commerce_Payment_Proccesing.Userinterface;




public abstract class ProudectsUserInterface
{
    public abstract void DisplayProudects(IReadOnlyList<Product> proudects);
}

public class AutomaticProudectsUserInterface : ProudectsUserInterface
{
    public override void DisplayProudects(IReadOnlyList<Product> proudects)
    {
        foreach (var proudect in proudects)
        {
            var table = new ConsoleTable("Id", "Name", "Price");

            table.AddRow(proudect.id, proudect.name, proudect.price);
        }



    }
}

public class ManualProudectsUserInterface : ProudectsUserInterface
{
    private readonly int TableWidth = 80;

    public override void DisplayProudects(IReadOnlyList<Product> proudects)
    {
        Console.WriteLine($" | {"ID",-5} | {"Name",-30} |{"Price",-10} ");

        Console.WriteLine(new string('-', TableWidth));

        foreach (var item in proudects)
        {

            Console.WriteLine($"| {item.id,-5} | {item.name,-30} | {item.price,-10} |");
            Console.WriteLine(new string('-', TableWidth));



        }
    }
}




