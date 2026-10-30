namespace BankAccountApp
{
    public class BankAccount
    {
        private string owner = "";

        public string Owner
        {
            get => owner;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Owner name cannot be empty.");
                    return;
                }
                owner = value;
            }
        }

        // Balance can be read from outside, but only changed by Deposit and Withdraw
        public double Balance { get; private set; }

        public BankAccount(string owner, double initialBalance = 0)
        {
            Owner = owner;
            Balance = initialBalance < 0 ? 0 : initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Deposit of {amount:F2} rejected: amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"{Owner} deposited {amount:F2}. New balance: {Balance:F2}");
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Withdrawal of {amount:F2} rejected: amount must be positive.");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine($"Withdrawal of {amount:F2} rejected: insufficient funds (balance {Balance:F2}).");
                return false;
            }

            Balance -= amount;
            Console.WriteLine($"{Owner} withdrew {amount:F2}. New balance: {Balance:F2}");
            return true;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Account owner: {Owner} | Balance: {Balance:F2}");
        }
    }
}
