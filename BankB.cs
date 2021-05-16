public class BankB : Bank
{
    private string balance = "$150";
    public override void getBalance()
    {
        System.Console.WriteLine("Your balance in BankB is " + balance);
    }
}