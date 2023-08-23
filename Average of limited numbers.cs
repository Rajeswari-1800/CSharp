using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int[] arr1=new int[num];
        int count=0;
        int sum=0;
        for(int i=0;i<num;i++)
        {
            arr1[i]=Convert.ToInt32(Console.ReadLine());
        }
        int num1=Convert.ToInt32(Console.ReadLine());
        int num2=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<arr1.Length;i++)
        {
            if((arr1[i]>num1)&&(arr1[i]<num2))
            {
                count++;
                sum=sum+arr1[i];
            }
        }
        Console.WriteLine(sum/count);
    }
}
