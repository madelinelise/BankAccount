using System;

public class AccountTest
{
    // Main method begins execution of the app

    public static void Main ( string[] args )
    {
        // constructors 
        Account account1 = new Account(50.00M); //create Account object
        Account account2 = new Account(-7.53M);

        Console.WriteLine("Account1 balance: {0:C}\n", account1.Balance);
        Console.WriteLine("Account2 balance: {0:C}\n", account2.Balance);

        decimal depositAmount;

        Console.WriteLine("Enter deposit ammount for account1: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
        account1.Credit(depositAmount);

        Console.WriteLine("account1 balance: {0:C}\n", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);


        Console.WriteLine("Enter deposit ammount for account2: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
        account2.Credit(depositAmount);

        Console.WriteLine("account1 balance: {0:C}\n", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);


    } // end Main

} // end class AccountTest