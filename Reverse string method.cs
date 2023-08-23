using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char[] str1=str.ToCharArray();
         Array.Reverse(str1);
        for(int i=0;i<str1.Length;i++)
        {
            Console.Write(str1[i]);
        }
    }
}

