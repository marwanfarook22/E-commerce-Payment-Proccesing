
using E_commerce_Payment_Proccesing.Service;
using E_commerce_Payment_Proccesing.UserinterAction;
using E_commerce_Payment_Proccesing.Userinterface;



new MainApplication(new JsonSaving()).start();

public class MainApplication
{
    static DisplayMessage Message = new DisplayMessage();
    static UserInputClass UserInputClass = new UserInputClass();
    static ProudectService service = new ProudectService();
    static Manual_TableProudects_UserInterface Manual_TableProudects = new Manual_TableProudects_UserInterface();
    static proudectUserInteraction UserInteraction = new proudectUserInteraction();
    private IFileSaver FileSaver { get; set; }
    public MainApplication(IFileSaver fileSaver)
    {
        FileSaver = fileSaver;

    }
    public void start()
    {
        var ProudectList = service.ReadProudctJson();
        Manual_TableProudects.DisplayProudects(ProudectList);
        List<Product> UserCart = UserInteraction.UserChossenProudect(ProudectList);
        Message.displayPaymnet();
        string paymentMethod = UserInputClass.UserInput();
        HandlePaymentAndOrder(paymentMethod, UserCart);
    }

    public void HandlePaymentAndOrder(string paymentMethod, List<Product> UserCart)
    {
        try
        {
            PaymentFactory factory = CreatePaymentFactory(paymentMethod);
            var payment = ProcessPayment(factory);
            OrderInfo orderInfo = CreateOrder(UserCart, payment);
            FileSaver.SavingFile(orderInfo);

        }
        catch (Exception ex)
        {
            handelExcptionsEroor(ex);

        }
    }


    private static PaymentFactory CreatePaymentFactory(string paymentMethod)
    {

        switch (paymentMethod)
        {
            case "1":
                return new CreditCardFactory(new DisplayMessage(), new UserInputClass());
            case "2":
                return new PayPalFactory(new DisplayMessage(), new UserInputClass());
            case "3":
                return new DigitalWalletFactory(new DisplayMessage(), new UserInputClass());
            default:
                return HandleInvalidInput();

        }

    }

    private static PaymentProcessor ProcessPayment(PaymentFactory factory)
    {
        var payment = factory.ProcessTransaction();
        Message.Display("Payment processed successfully.");
        return payment;
    }

    private static OrderInfo CreateOrder(List<Product> UserCart, PaymentProcessor payment)
    {
        PlacementOrder placementOrder = new PlacementOrder();
        return placementOrder.CreateOrder(UserCart, payment);

    }



    private static void handelExcptionsEroor(Exception exception)
    {
        Message.Display(exception.Message);
        Console.ReadKey();

    }
    private static PaymentFactory HandleInvalidInput()
    {
        Console.ReadKey();
        throw new Exception("Invalid Input");

    }
}

