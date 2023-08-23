using System;
class program
{
    public static void Main(string [] args)
    {
        string str1=Console.ReadLine();
        char[] str=str1.ToCharArray();
        char ch=Convert.ToChar(Console.ReadLine());
        for(int i=0;i<str.Length;i++)
        {
            if((str[i].CompareTo(ch))==0)
            {
                str[i]='\0';
            }
        }
        for(int i=0;i<str.Length;i++)
        {
            if((str[i].CompareTo('\0'))!=0)
            Console.Write(str[i]);
        }
    }
}
