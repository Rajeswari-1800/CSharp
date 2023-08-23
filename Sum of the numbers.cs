using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        int sum=0;
        int num=0;
        bool res;
        for(int i=0;i<str.Length;i++)
        {
            res=Char.IsDigit(str[i]);
            if(res==true&&i==str.Length-1)
            {
                num=num*10+str[i]-48;
                sum=sum+num;
            }
           else if(res==true)
            {
                num=num*10+str[i]-48;
                
            }
           else if(num!=0)
           {
               sum=sum+num;
               num=0;
           }
         
          
        }
        Console.WriteLine(sum);
       
    }
}
