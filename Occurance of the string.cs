using System;
class program
{
    public static void Main(string[] args)
    {
        string name=Console.ReadLine();
        char [] ch=name.ToCharArray();
        char name1=Convert.ToChar(Console.ReadLine());
        int count=0;
        for(int i=0;i<name.Length;i++)
        {
           if(name1==ch[i])
           {
               count++;
           }
            
        }
        Console.WriteLine(count);
    }
}
