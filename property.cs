

class BankAc
{
    private string accHolder;
    private decimal balance;

    public string AccHolder
    {
        get
        {
            return accHolder;
        }

        set
        {
            accHolder = value;
        }
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be Negative");
            }
        }
    }
}