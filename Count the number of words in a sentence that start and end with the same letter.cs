using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char[] name=str.ToCharArray();
        char ch='\0';
        int count=0;
        for(int i=0;i<name.Length;i++)
        {
            if(i==0||name[i-1]==' ')
            {
                ch=name[i];
            }
            for(int j=i+1;j<name.Length;j++)
            {
                if((name[j]==' ')&&((name[j-1].CompareTo(ch))==0))
                {
                    count++;
                    i=j;
                    break;
                }
                else if((j==((name.Length)-1))&&((name[j].CompareTo(ch))==0))
                {
                    count++;
                    i=j;
                    break;
                }
                else if(name[j]==' ')
                {
                    i=j;
                    break;
                }
            }
        }
        Console.WriteLine(count);
        
    }
}
