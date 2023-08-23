using System;
class program
{
    public static void Main(string[] args)
    {
        string str1=Console.ReadLine();
        string low=str1.ToLower();
        char[] str=low.ToCharArray();
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]=='a'||str[i]=='e'||str[i]=='i'||str[i]=='o'||str[i]=='u')
            {
                str[i]='\0';
            }
        }
        for(int i=0;i<str.Length;i++)
        {
            if(str[i]!='\0')
            {
                Console.Write(str[i]);
            }
        }
    }
}
