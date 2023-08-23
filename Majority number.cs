using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int [] arr=new int [num];
        int count=1;
        int max=0;
        int n=0;
        for(int i=0;i<num;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<num;i++)
        {
            for(int j=i+1;j<num;j++)
            {
                if(arr[i]!='\0')
                {
                    if(arr[i]==arr[j])
                   {
                    arr[j]='\0';
                    count++;
                   }
                }
                
            }
            if(count>max)
            {
                max=count;
                n=arr[i];
            }
            count=1;
        }
        Console.WriteLine(n);
    }
}
