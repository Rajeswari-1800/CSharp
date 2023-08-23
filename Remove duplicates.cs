using System;
class program
{
    public static void Main(string[] args)
    {
        string str1=Console.ReadLine();
        char [] str=str1.ToCharArray();
        for(int i=0;i<str.Length;i++)
        {
            for(int j=i+1;j<str.Length;j++)
            {
                if((str[i].CompareTo(str[j]))==0)
               {
                    str[i]='\0';
                    str[j]='\0';
                }
            }
        }
        for(int i=0;i<str.Length;i++)
        {
            if((str[i].CompareTo('\0'))!=0)
            {
                Console.Write(str[i]);
            }
        }
    }
}
