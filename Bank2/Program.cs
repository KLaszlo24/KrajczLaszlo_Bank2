namespace Bank2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a banki rendszerben!");

            SavingsAccount bank1 = new SavingsAccount("12345", 1000, 0.05);
            CreditAccount bank2 = new CreditAccount("12345", 1000, 0.05);

            Console.WriteLine("Megtakarítási számla egyenleg: " + bank1.Balance);
            Console.WriteLine("Folyószámla egyenleg: " + bank2.Balance);

            bank1.Deposit(500);
            bank2.Deposit(200);

            bank1.Withdraw(300);
            bank2.Withdraw(700);

            Console.WriteLine("Megtakarítási számla új egyenleg: " + bank1.Balance);
            Console.WriteLine("Folyószámla új egyenleg: " + bank2.Balance);

            Console.WriteLine("Kilépéshez nyomj egy gombot...");
            Console.ReadKey();


            // nem tudom hogyan kéne megoldani
        }
    }
}
