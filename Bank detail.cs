using System;
namespace raji
{
    class program
    {
        public static void Main (string[] args)
        {
            bank[]bank=new bank[2];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Account "+i+1+":");
                Console.Write("Account number :");
                string no=Console.ReadLine();
                Console.Write("Account holder name :");
                string name=Console.ReadLine();
                Console.Write("Balance :");
                double balance=Convert.ToDouble(Console.ReadLine());
                bank[i]=new bank(no,name,balance);
            }
            Console.WriteLine("Transfer Details");
            Console.Write("amount :");
            double amount=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Before transfer");
            for(int i=0;i<2;i++)
            {
                 Console.WriteLine("Account name"+i+1+" "+bank[i].name+" "+bank[i].no+" "+bank[i].balance);
            }
            bank[] tra=transfer(bank,amount);
            
            Console.WriteLine("After Transfer");
            for(int i=0;i<2;i++)
            {
                if(tra[i]==null)
                {
                    Console.WriteLine("insufficient");
                }
                else
                {
                    Console.WriteLine("Account name"+i+1+" "+tra[i].name+" "+tra[i].no+" "+tra[i].balance);
                }
            }
            
            
        }
        public static bank[] transfer(bank[]bank,double amount)
        {
           
                if((bank[0].balance.CompareTo(amount))>0)
                {
                   bank[0].balance=bank[0].balance-amount;
                   bank[1].balance=bank[1].balance+amount;
                    return bank;
                }
                else 
                {
                    return null;
                }
            
        }
    }
    class bank
    {
        public string no;
        public string name;
        public double balance;
        public bank(string no,string name,double balance )
        {
            this.no=no;
            this.name=name;
            this.balance=balance;
            
        }
    }
}
