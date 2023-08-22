using System;


    class program
    {
        public static void Main(string[] args)
        {
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num2;i++)
            {
                Console.WriteLine(num1 + "x" + i + "=" + num1*i);
            }
        }
    }


