using E_commerce_Payment_Proccesing.UserinterAction;
using E_commerce_Payment_Proccesing.Userinterface;

public class CreditCardFactory : PaymentFactory
{

    private IDisplayMessage _displayMessage;
    private IUserInputClass _userInputClass;

    public CreditCardFactory(IDisplayMessage displayMessage, IUserInputClass userInputClass)
    {
        _displayMessage = displayMessage;
        _userInputClass = userInputClass;
    }
    public override PaymentProcessor CreatePaymentProcessor()
    {
        _displayMessage.Display("Enter Card Number:");
        string cardNumber = _userInputClass.UserInput();

        _displayMessage.Display("Enter CVV:");
        string cvv = _userInputClass.UserInput();

        _displayMessage.Display("Enter Expiry Month (MM):");
        string month = _userInputClass.UserInput();

        _displayMessage.Display("Enter Expiry Year (YY):");
        string year = _userInputClass.UserInput();

        _displayMessage.Display("Enter Card Holder Name:");
        string name = _userInputClass.UserInput();

        return new CreditCardPayment
        {
            CardNumber = cardNumber,
            Cvv = cvv,
            ExpiryDate = $"{month}/{year}",
            CardHolderName = name,

        };
    }
}








