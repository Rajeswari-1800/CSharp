using System;
class program
{
    public static void Main(string[] args)
    {
        string name=Console.ReadLine();
        char [] arr=name.ToCharArray();
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i]==arr[j])
                {
                    arr[j]='\0';
                }
            }
        }
        foreach(char c in arr)
        {
            if(c!='\0')
            {
            Console.WriteLine(c);
            }
        }
    }
}
