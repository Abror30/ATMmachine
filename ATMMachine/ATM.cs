using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class ATM
    {
        public  string EmployeeName { get; set; }
        public  string Address { get; set; }
        //public static int AccountNumber { get; set; }
        //public static int WithDrawMoney { get; set; }
        public int TopUpMoney { get; set; }
        public  double SomoniAccountMoney { get; set; }
        public  double YuanAccount { get; set; }
        public  double CurrencyExchange { get; set; }
        

        public ATM()
        {
            EmployeeName = "Kamolov Abror Sherozovich";
            Address = "Mekhrobod city";
            SomoniAccountMoney = 20000;
            YuanAccount = 10000;
            CurrencyExchange = 1.7;
        }

        public string CardNumber(string account)
        { 
            return account.ToString();
            Console.WriteLine("Your Bank card Number is {0}", account);
            
        }
        public  double MoneyWithdraw(double moneyOut)
        {
            if (SomoniAccountMoney >= moneyOut)
            {
                Console.WriteLine("...withdrawing money from your bank-card");
                SomoniAccountMoney = SomoniAccountMoney - moneyOut;
                Console.WriteLine("Money withdraw successfully!");
                return moneyOut;
                
            }
            else
            {
                Console.WriteLine("...You have not sufficient money on your bank account...");
                return 0;

            }
            
        }
        public  double MoneyTopUp(double topUpMoney)
        {
            Console.WriteLine("...prossessing Top Up into your bank-card...");
            SomoniAccountMoney += topUpMoney;
            Console.WriteLine("Your Money successfully topped up");
            return SomoniAccountMoney;
        }
        public  double CurrencyExchag(double somoni)
        {
            Console.WriteLine("...Processing somoni into yuan");
            Console.WriteLine("Operation is successfull");
            double exchangedYuan = somoni / CurrencyExchange;
            return exchangedYuan;
        }
        
    }
}
