using System;
class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        string[] employee=new string[num];
        string[] city=new string[num];
        for(int i=0;i<num;i++)
        {
            employee[i]=Console.ReadLine();
        }
        for(int i=0;i<num;i++)
        {
            city[i]=Console.ReadLine();
        }
        for(int i=0;i<num;i++)
        {
            if(employee[i]!=null)
            {
            Console.Write(city[i]);
            }
            for(int j=0;j<num;j++)
            {
                if(((city[i].CompareTo(city[j]))==0)&&(city[i]!=null))
                {
                    if(employee[j]!=null)
                    {
                    Console.Write(" " + employee[j]);
                    employee[i]=null;
                    employee[j]=null; 
                    }
                    
                }
                
            }
            Console.WriteLine("");
        }
    }
}
