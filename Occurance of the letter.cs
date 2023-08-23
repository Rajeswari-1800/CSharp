using System;
class program
{
    public static void Main(string[] args)
    {
        string str1=Console.ReadLine();
        char[] str=str1.ToCharArray();
        int count =1;
        for(int i=0;i<str.Length;i++)
        {
            for(int j=i+1;j<str.Length;j++)
            {
                if((str[i].Equals(str[j]))&&(str[i].CompareTo('\0')!=0))
                {
                    count++;
                    str[j]='\0';
                }
            }
            if(str[i]!='\0')
            {
               Console.Write(str[i]);
            Console.Write(count);
            Console.WriteLine();
            count=1;  
            }
           
        }
    }
}
