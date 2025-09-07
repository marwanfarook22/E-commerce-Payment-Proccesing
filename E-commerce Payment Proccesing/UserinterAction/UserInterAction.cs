using E_commerce_Payment_Proccesing.Service;


namespace E_commerce_Payment_Proccesing.UserinterAction;

public class proudectUserInteraction
{
    public List<Product> UserChossenProudect(IReadOnlyList<Product> proudects)
    {
        List<int> AllIds = InputValidtion();
        List<Product> result = new List<Product>();

        for (int i = 0; i < AllIds.Count; i++)
        {
            result.AddRange(proudects[AllIds[i]]);

        }
        return result;
    }

    public List<int> InputValidtion()
    {
        List<int> ProductIdColliction = new List<int>();
        bool isValid = false;
        const string Message = "Enter Id Of Proudect You Want To Purschsed";
        do
        {
            Console.WriteLine(Message);
            int.TryParse(Console.ReadLine(), out int Result);

            if (Result >= 1 && Result <= 50)
            {
                Console.WriteLine($"You Chossen Proudect Id Is {Result}");
                ProductIdColliction.Add(Result - 1);

                Console.WriteLine("Do You Want To Chossen Another Proudect ? (y/n)");
                var Chossen = Console.ReadLine(); /*Any Key Not Y Will  Be No */
                if (Chossen != null && Chossen.ToLower() == "y")
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a number between 1 and 50.");
            }


        }
        while (isValid);

        return ProductIdColliction;
    }




}




