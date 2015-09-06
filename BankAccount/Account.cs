using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account

{
    private decimal balance; // instance variable that stores the balance

    // constructor - retuens a decimal and passes initialBalance
    public Account (decimal initialBalance)
    {
        Balance = initialBalance; // set balance using property 
    } // end Account constructor

    // credit (add) an amount to the account

    public void Credit(decimal amount)
    {
        Balance = Balance + amount;
    }
    
    // a property to get and set the account balance

    public decimal Balance
    {
        get
        {
            return balance;
        } //end get
        set
        {
            // validate the value is great than or equal to 0;
            // if not, balance is left unchanged.

            if (value >= 0)
                balance = value;
        } // end set
    } // end property Balance
} //end Class Acount