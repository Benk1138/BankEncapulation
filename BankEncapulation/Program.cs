namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.Writeline("how mush would you liek to deposit?");
            var amountToDeposit = double.Parse(Console.Readline());
            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you, youre blance is now {Account.GetBalance()}");
            
        }
    }
}
