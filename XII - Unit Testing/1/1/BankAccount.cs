// BankAccount.cs in the Bank project
using System;

namespace Bank
{
    public class BankAccount
    {
        public string CustomerName { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string customerName, decimal balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }

        public void Debit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Debit amount is less than or equal to zero");
            }
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Debit amount exceeds balance");
            }
            Balance -= amount;
        }

        public void Credit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Credit amount is less than or equal to zero");
            }
            Balance += amount;
        }
    }
}