# AE3OP Task 04 - OOP Fundamentals: BankAccount

"Your turn" exercise from [Methods and behavior](https://github.com/icebeam7/oop-tutorials/blob/main/01-oop-fundamentals/04-methods-and-behavior.md):
a `BankAccount` class using a class, properties and methods.

## What is in it

| Part | Where |
|---|---|
| Class | `BankAccount` in `BankAccountApp/BankAccount.cs` |
| Properties | `Owner` (validated, cannot be empty), `Balance` (public get, private set) |
| Constructor | `BankAccount(string owner, double initialBalance = 0)` |
| Methods | `Deposit(double amount)`, `Withdraw(double amount)`, `ShowBalance()` |
| Encapsulation | `Balance` can only change through `Deposit` and `Withdraw`; negative amounts and overdrafts are rejected |

`Program.cs` creates two accounts and makes a few deposits and withdrawals, including rejected ones.

## Run

```bash
dotnet run --project BankAccountApp
```

## Investigate

1. **Field vs method:** a field (or property) stores data, the state of the object, such as `Balance`. A method is behavior, code that does something with that data, such as `Deposit`.
2. **Method with a return value:** a method that gives a result back to the caller instead of `void`. `Withdraw` returns `bool`, `true` if the money was taken out and `false` if it was rejected.
3. **Why keep behavior inside the class:** the rules (no negative deposits, no overdraft) live in one place next to the data they protect, so code outside cannot put the object in an invalid state, and it is reused by every account.
