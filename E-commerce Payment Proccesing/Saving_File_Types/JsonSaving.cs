using System.Text.Json;

public class JsonSaving : IFileSaver
{
    const string filePath = "order.json";
    public void SavingFile(OrderInfo order)
    {
       
        var options = new JsonSerializerOptions { WriteIndented = true };
      
        string jsonString = JsonSerializer.Serialize(order, options);
        File.AppendAllText(filePath, jsonString);
    }

    
}

