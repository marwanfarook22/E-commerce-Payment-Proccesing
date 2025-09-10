public class PaypalProccese : PaymentProcessor
{
    public string Email { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public override paymnetMethod CardMethod { get => paymnetMethod.PayPal; set => CardMethod = paymnetMethod.PayPal; }

    public override void ValidatePayment()
    {
        if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
        {
            throw new ArgumentException("Invalid email address.");
        }
        if (string.IsNullOrWhiteSpace(Password) || Password.Length < 6)
        {
            throw new ArgumentException("Invalid password.");
        }

    }
}








