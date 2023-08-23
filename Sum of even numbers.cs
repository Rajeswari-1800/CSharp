using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int [] arr=new int[num];
        int sum=0;
        for(int i=0;i<num;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        for(int i=0;i<num;i++)
        {
            if(arr[i]%2==0)
            {
                sum=sum+arr[i];
            }
        }
        Console.WriteLine(sum);
    }
}
