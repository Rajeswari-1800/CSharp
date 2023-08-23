using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        int rem=0;
        if(num%2==0)
        {
            Console.WriteLine("cannot Reverse");
        }
        else
        {
            while(num!=0)
            {
                rem=num%10;
                sum=sum*10+rem;
                num=num/10;
            }
            Console.WriteLine(sum);
        }
        
    }
}
