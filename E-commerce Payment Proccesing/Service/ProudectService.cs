
namespace E_commerce_Payment_Proccesing.Service;




public class ProudectService
{

    public List<Root> ReadProudctJson()
    {
        var jsonString = File.ReadAllText("products_json.json");
        var proudect = System.Text.Json.JsonSerializer.Deserialize<Root>(jsonString);
        if (proudect != null)
        {
            return new List<Root> { proudect };

        }
        return new List<Root>();


    }
}
