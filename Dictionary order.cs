using System;
class program
{
    public static void Main(string[]args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        string [] str=new string[num];
        string []str1=new string[1];
        for(int i=0;i<num;i++)
        {
            str[i]=Console.ReadLine();
        }
        for(int i=0;i<num;i++)
        {
            for(int j=i+1;j<num;j++)
            {
                if((str[i].CompareTo(str[j]))>0)
                {
                    str1[0]=str[i];
                    str[i]=str[j];
                    str[j]=str1[0];
                    
                }
            }
        }
        for(int i=0;i<num;i++)
        {
            Console.WriteLine(str[i]);
        }
    }
}
