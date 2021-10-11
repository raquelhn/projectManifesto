using System;
namespace ATM_Project
{
    public class BankAccount
    {

        public int Pin { get; set; }

        public string Amount { get; set; }

        public double Balance { get; set; }

        public double Overdraft { get; set; }

        public string Name { get; set; }

        public string BankAccountNumber { get; set; }

        public bool CheckBankAccountValidity(string acc)
        {
            if (acc == BankAccountNumber)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool CheckPinValidity(int pin)
        {
            if (pin == Pin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double CheckBalance()
        {
            return Balance;

        }

        public bool WithdrawMoney(double amount)
        {
            if (Balance + Overdraft - amount > 0)
            {
                if (Balance - amount > 0)
                {
                    Balance -= amount;
                    return true;
                }
                else
                {
                    Balance = Balance + Overdraft - amount;
                    return true;
                }

            }
            else {
                return false;

            }

        }


    }
}
