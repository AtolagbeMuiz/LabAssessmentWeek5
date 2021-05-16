public class BankA : Bank
{
    private string balance = "$100";
    public override void getBalance()
    {
        System.Console.WriteLine("Your balance in BankA is " + balance);
    }
}