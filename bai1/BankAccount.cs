using System;


public abstract class BankAccount
{
    public decimal Balance { get; protected set; }


    public BankAccount(decimal balance)
    {
        Balance = balance;
    }


    public abstract void CheckBalance();


    public abstract void BankTransfer(decimal amount);
}
