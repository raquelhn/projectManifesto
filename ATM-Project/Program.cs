using System;

namespace ATM_Project
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            AtmMachine atm = new AtmMachine();
            BankAccount accountOne = new BankAccount();
           
           
            atm.CashinAtm = 8000;
            accountOne.Pin = 1234;
            accountOne.Balance = 500;
            accountOne.Overdraft = 100;
            accountOne.Name = "Client1";
            accountOne.BankAccountNumber = "12345678";

  
          
            

            Console.Write("Please enter your Bank account number ");
            string bankacc = Console.ReadLine();
           
            bool isBankAccValid = accountOne.CheckBankAccountValidity(bankacc);

            if (isBankAccValid)
            {
                Console.WriteLine($"Hello, please enter your PIN");

            }
            else
            {
                Console.WriteLine("ACCOUNT_ERR");

            }
            int pin = int.Parse(Console.ReadLine());
            bool isPinValid = accountOne.CheckPinValidity(pin);

            
            if (!isPinValid)
            {
                Console.WriteLine("ACCOUNT_ERR");

            }
            else
            {
                Console.WriteLine($"Hello {accountOne.Name} your balance is {accountOne.Balance} and your overdraft is {accountOne.Overdraft}! \nPlease choose what you would like to do next");
            }

           
   
            Console.Write("Press B for Balance enquires\n" +
                "Press W to withdraw money, follow by the amount\n" +
                "\n");

            
            string option = Console.ReadLine().ToUpper();
            while (option != string.Empty) {
                switch (option)
                {
                    case "B":
                        double Balance = accountOne.CheckBalance();
                        Console.WriteLine($"The balance is: {Balance}");
                        break;
                    case "W":
                        Console.WriteLine("Please provide the amount to withdraw: ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (withdrawAmount % 100 != 0)
                        {
                            Console.WriteLine("This amount is not a multiple of 100");
                            break;
                        }
                        bool isSuccessfulAtm = atm.WithdrawCashAtm(withdrawAmount);
                        if (!isSuccessfulAtm)
                        {
                            Console.WriteLine("ATM_ERR");
                            break;
                        }

                        bool isSuccessfulAccount = accountOne.WithdrawMoney(withdrawAmount);
                        if (isSuccessfulAccount)
                        {
                            Console.WriteLine($"Transaction succesfull, your new balance is: {accountOne.Balance}");

                        }
                        else
                        {
                            Console.WriteLine("FUNDS_ERR");

                        }
                        break;

                    default:
                        Console.WriteLine("option no valid");
                        break;
                }
                option = Console.ReadLine().ToUpper();


            }
                
            

            }
    }
}
