using System;
class program
{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        char [ ] arr1=str.ToCharArray();
        char[] arr=str.ToCharArray();
        
        Array.Reverse(arr);
        int count=0;
        for(int i=0;i<str.Length;i++)
        {
            if(arr[i].Equals(arr1[i]))
            {
                count++;
            }
        }
       
        if(count==str.Length)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("not a Palindrome");
        }
        
    }
}
