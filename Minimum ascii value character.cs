using System;
class program
{
    public static void Main(string [] args)
    {
        string str=Console.ReadLine();
        char[] str1=str.ToCharArray();
        char ch='z';
        for(int i=0;i<str.Length;i++)
        {
            if((str1[i].CompareTo(ch))<0)
            {
                ch=str1[i];
            }
            
        }
        Console.WriteLine(ch);
    }
}
