using System;
class program
{
    public static void Main(String[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        int [,] arr=new int[num,num];
        int n=0;
        for(int i=0;i<num;i++)
        {
            for(int j=0;j<num;j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
            
        }
        for(int i=0;i<num;i++)
        {
            for(int j=0;j<num;j++)
            {
                
                    if((arr[i,j]%2!=0&&arr[i,j]%3!=0&&arr[i,j]%5!=0&&arr[i,j]%7!=0)||(arr[i,j]==2||arr[i,j]==3||arr[i,j]==5||arr[i,j]==7))
                    {
                        if(arr[i,j]>n)
                        {
                            n=arr[i,j];
                        }
                        
                    }
                
            }
            
            
        }
        Console.WriteLine(n);
        
    }
}
