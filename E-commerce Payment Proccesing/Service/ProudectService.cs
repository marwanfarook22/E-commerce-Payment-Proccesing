
namespace E_commerce_Payment_Proccesing.Service;




public class ProudectService
{

    public IReadOnlyList<Product> ReadProudctJson()
    {
        var jsonString = File.ReadAllText("products_json.json");
        var proudect = System.Text.Json.JsonSerializer.Deserialize<Root>(jsonString)?.products;

        if (proudect != null)
        {
            return proudect;

        }
        return null;


    }
}
