using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        double num1=Math.Sqrt(num);
        if((int)num1==num1)
        {
            Console.WriteLine("Perfect square");
        }
        else
        {
            Console.WriteLine("Not a Perfect Square");
        }
        
    }
}
