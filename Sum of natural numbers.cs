using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i=1;i<=num;i++)
        {
            sum=sum+i;
        }
        Console.WriteLine(sum);
        
    }
}
