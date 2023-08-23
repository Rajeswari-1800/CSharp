using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char [] str1=str.ToCharArray();
        int count=0;
        int count1=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str1[i]==' ')
            {
                count++;
            }
            else
            {
                count1++;
            }
        }
        Console.WriteLine("no of space:"+count);
        Console.WriteLine("no of characters:"+count1);
    }
}
