

using E_commerce_Payment_Proccesing.UserinterAction;
using E_commerce_Payment_Proccesing.Userinterface;

public class PayPalFactory : PaymentFactory
{
    private IDisplayMessage _displayMessage;
    private IUserInputClass _userInputClass;
    public PayPalFactory(IDisplayMessage displayMessage,
        IUserInputClass userInputClass)
    {
        _displayMessage = displayMessage;
        _userInputClass = userInputClass;
    }
    public override PaymentProcessor CreatePaymentProcessor()
    {
        _displayMessage.Display("Enter Your Email in Paypal");
        string email = _userInputClass.UserInput()!;
        _displayMessage.Display("Enter Your PayPal Password");
        string password = _userInputClass.UserInput()!;

        return new PaypalProccese
        {
            Email = email,
            Password = password,
        };

    }

}







