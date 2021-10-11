using System;
namespace ATM_Project
{
    public class AtmMachine
    {
        public double CashinAtm { get; set; }

        public bool WithdrawCashAtm(double amount)
        {
            if (CashinAtm - amount > 0)
            {
                CashinAtm -= amount;
                return true;

            }
            else
            {
                return false;

            }

        }


    }

    
}
