using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char[] str1=str.ToCharArray();
      //  string [] reverse=new string[str1.Length];
        char [] rev=str.ToCharArray();
        int len=str1.Length-1;
        for(int i=0;i<str1.Length;i++)
        {
            rev[len-i]=str1[i];
        }
        for(int i=0;i<str1.Length;i++)
        {
            Console.Write(rev[i]);
        }
    }
}
