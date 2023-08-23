using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int [] arr=new int[num];
        int n=0;
        int n1=0;
        int count=0;
        for(int i=0;i<num;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        n=arr[0];
        n1=arr[arr.Length-1];
        for(int i=n;i<n1;i++)
        {
             count=0;
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[j]==i)
                {
                    count++;
                    break;
                }
                else
                {
                   
                }
            }
            if(count==0)
            {
                Console.WriteLine(i);
               
            }
            
        }
    }
}

