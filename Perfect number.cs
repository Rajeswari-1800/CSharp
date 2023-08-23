using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=1;
        int num1=num/2;
        for(int i=2;i<=num1;i++)
        {
        
            if(num%i==0)
            {
               
                sum=sum+i;
            }
            
        }
        if(sum==num)
        {
         Console.WriteLine("Perfect number");
        }
        else
        {
            Console.WriteLine("Not a Perfect number");
        }
        
    }
}

