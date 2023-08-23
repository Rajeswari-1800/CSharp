using System;
namespace raji
{
    class program
    {
        public static void Main(string[] args)
        {
            sim[]sim=new sim[4];
            for(int i=0;i<4;i++)
            {
                int id=Convert.ToInt32(Console.ReadLine());
                string name=Console.ReadLine();
                double balance=Convert.ToDouble(Console.ReadLine());
                double rate=Convert.ToDouble(Console.ReadLine());
                string circle=Console.ReadLine();
                sim[i]=new sim(id,name,balance,rate,circle);
            }
            string circle1=Console.ReadLine();
            string circle2=Console.ReadLine();
            sim[] res=transfer(sim,circle1,circle2);
            for(int i=0;i<4;i++)
            {
                if(res[i].circle.Equals(circle2))
                {
                    Console.WriteLine(res[i].id+" "+res[i].circle+" "+res[i].rate);
                }
            }
        }
        public static sim[] transfer(sim[]sim,string circle1,string circle2)
        {
            sim[] n=new sim[1];
            for(int i=0;i<4;i++)
            {
                for(int j=i;j<4;j++)
                {
                    if(sim[i].rate>sim[j].rate)
                    {
                        n[0]=sim[i];
                        sim[i]=sim[j];
                        sim[j]=n[0];
                    }
                }
            }
            for(int i=0;i<4;i++)
            {
                if((sim[i].circle.CompareTo(circle1))==0)
                {
                    sim[i].circle=circle2;
                }
                else
                {
                    sim[i].circle=circle1;
                }
            }
            return sim;
        }
        
    }
    class sim
    {
        public int id;
        public string name;
        public double balance;
        public double rate;
        public string circle;
        public sim(int id,string name,double balance,double rate,string circle)
        {
            this.id=id;
            this.name=name;
            this.balance=balance;
            this.rate=rate;
            this.circle=circle;
        }
        
    }
}
