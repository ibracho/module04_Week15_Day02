namespace atm;

class Program
{
    public static decimal Balance = 100;
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the atm!\n\n");
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("To view balance, press 1");
            Console.WriteLine("To view withdraw, press 2");
            Console.WriteLine("To deposit new funds, press 3");
            Console.WriteLine("To exit, press 4");
            Console.WriteLine("\n");

            string input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                decimal balance = ViewBalance();
                Console.WriteLine("This is the current balance: " + balance);
            }
            else if (input == "2")
            {
                Console.Write("What is the widthdraw amount? ");
                string widthdrawAmountString = Console.ReadLine();
                decimal widthdrawAmount = Convert.ToDecimal(widthdrawAmountString);
                decimal newAccountBalance = Widthdraw(widthdrawAmount);
                Balance = newAccountBalance;
                Console.WriteLine("The new balance is " + newAccountBalance);
            }
            else if (input == "4")
            {
                System.Environment.Exit(0);
            }
            Console.WriteLine("\n");

            Console.Write("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static decimal ViewBalance()
    {
        return Balance;
    }

    static decimal Widthdraw(decimal widthdrawAmount)
    {
        if (Balance < widthdrawAmount)
        {
            throw new Exception("Insufficient funds!");
        }

        else if (widthdrawAmount < 0)
        {
            throw new Exception("Invalid withdrawl amount");
        }
        decimal newBalance = Balance - widthdrawAmount;
        return newBalance;
    }
}
