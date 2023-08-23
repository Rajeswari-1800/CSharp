using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char[]arr=str.ToCharArray();
        char ch='a';
        for(int i=0;i<str.Length;i++)
        {
           if((arr[i].CompareTo(ch))>0)
           {
               ch=arr[i];
           }
            
        }
        Console.WriteLine(ch);
    }
}
