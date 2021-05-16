public class BankC : Bank
{
    private string balance = "$200";
    public override void getBalance()
    {
        System.Console.WriteLine("Your balance in BankC is " + balance);
    }
}