using BankAccountApp;

BankAccount account = new BankAccount("Chander", 100);
account.ShowBalance();

account.Deposit(250);
account.Withdraw(80);
account.Withdraw(1000); // more than the balance, rejected
account.Deposit(-20);   // negative amount, rejected
account.ShowBalance();

// account.Balance = 1000000; // does not compile: the setter is private

Console.WriteLine();

BankAccount second = new BankAccount("Alice");
second.Deposit(50);
second.Withdraw(20);
second.ShowBalance();
