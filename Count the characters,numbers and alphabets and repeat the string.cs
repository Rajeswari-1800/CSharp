using System;
class program
{
    public static void Main(string[]args)
    {
        string str1=Console.ReadLine();
        char[] str=str1.ToCharArray();
        int alp=0;
        int ch=0;
        int num=0;
        int count =1;
        for(int i=0;i<str.Length-1;i++)
        {
          bool num1=Char.IsDigit(str[i]);
          bool alp1=Char.IsLetter(str[i]);
          bool num2=Char.IsDigit(str[i+1]);
          bool alp2=Char.IsLetter(str[i+1]);
          if(alp1==true&&alp2==false)
          {
              count++;
              alp++;
          }
          else if(num1==true&&num2==false)
          {
              count++;
              num++;
              
          }
          else if(num1==false&&alp1==false)
          {
              count++;
              ch++;
          }
          else if(num2==true&&i==(str.Length-1))
          {
              count++;
              num++;
              
          }
          else if(alp2==true&&i==(str.Length-1))
          {
              count++;
              alp++;
          }
          else if(alp2==false&&num2==false&&i==(str.Length-1))
          {
              count++;
              ch++;
          }
        }
        for(int i=0;i<count;i++)
        {
            Console.WriteLine(str1);
        }
        
    }
    
}
