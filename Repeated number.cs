using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char[] str1=str.ToCharArray();
        int count=1;
        for(int i=0;i<str1.Length;i++)
        {
            
            for(int j=i+1;j<str1.Length;j++)
            {
                if(str1[i]==str1[j])
                {
                    count++;
                    str1[j]='\0';
                }
            }
            if(str1[i]!='\0')
            {
                Console.Write(str1[i]);
                Console.Write(count);
                count=1;
            }
            
           
        }
    }
}
