using System;
namespace raji
{
    class program
    {
        public static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            hotel[] hotel=new hotel[num];
            for(int i=0;i<num;i++)
            {
                int id=Convert.ToInt32(Console.ReadLine());
                string name=Console.ReadLine();
                string date=Console.ReadLine();
                int room=Convert.ToInt32(Console.ReadLine());
                string wifi=Console.ReadLine();
                double bill=Convert.ToDouble(Console.ReadLine());
                hotel[i]=new hotel(id,name,date,room,wifi,bill);
            }
            string month=Console.ReadLine();
            
            string wi=Console.ReadLine();
            int no=noofrooms(hotel,num,month);
            Console.WriteLine(no);
            double no1=search(hotel,num,wi);
             Console.WriteLine(no1);
        }
        public static int noofrooms(hotel[] hotel,int num,string month)
        {
           bool res;
           int sum=0;
           for(int i=0;i<num;i++)
           {
               res=hotel[i].date.Contains(month);
               if(res==true)
               {
                   sum=hotel[i].room;
                   return sum;
               }
           }
           return sum;
        }
        public static double search(hotel[] hotel,int num,string wi)
        {
            double max1=0;
            double max2=0;
            for(int i=0;i<num;i++)
            {
                if(hotel[i].wifi.Equals(wi))
                {
                    if(hotel[i].bill>max1)
                    {
                        max2=max1;
                        max1=hotel[i].bill;
                    }
                }
            }
            return max2;
        }
    }
    class hotel
    {
        public int id;
        public string name;
        public string date;
        public int room;
        public string wifi;
        public double bill;
        public hotel(int id,string name,string date,int room,string wifi,double bill)
        {
            this.id=id;
            this.name=name;
            this.date=date;
            this.room=room;
            this.wifi=wifi;
            this.bill=bill;
        }
    }
}
