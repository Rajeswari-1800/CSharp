using System;
class program
{
    public static void Main(string [] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        int rem=0;
        while(num!=0)
        {
            rem=num%10;
            num=num/10;
            if(rem==2||rem==3||rem==5||rem==7)
            {
                sum=sum+rem;
            }
        }
        Console.WriteLine(sum);
    }
}
