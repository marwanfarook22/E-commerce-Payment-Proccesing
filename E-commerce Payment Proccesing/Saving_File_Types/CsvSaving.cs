using System.Text;

public class CsvSaving : IFileSaver
{
    const string filePath = "order.csv";
    const string CsvHeader = "OrderId,TotalPrice,OrderDate,PaymentMethod,CartDetails";
    StringBuilder builder = new StringBuilder();


    private string HandelCsvRows(OrderInfo order, IEnumerable<string>? itemsNames)
    {
        return $"{order.OrderId},{order.TotalPrice},{order.OrderDate},{order.PaymentDetails.CardMethod},{$"[{string.Join("-", itemsNames)}]"}";


    }

    private IEnumerable<string>? FiltringName(OrderInfo order)
    {
        return order.CartDetails?.Select(x => x.name).ToList();

    }

    public void SavingFile(OrderInfo order)
    {
        IEnumerable<string>? ItemsNames = FiltringName(order);
        string CsvRow = HandelCsvRows(order, ItemsNames);

        if (File.Exists(filePath))
        {
            builder.AppendLine(CsvRow);
            File.AppendAllText("order.csv", builder.ToString());

        }
        else
        {
            builder.AppendLine(CsvHeader);
            builder.AppendLine(CsvRow);
            File.WriteAllText("order.csv", builder.ToString());
        }
    }
}

