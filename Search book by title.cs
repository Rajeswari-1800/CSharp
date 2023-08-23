using System;
namespace raji
{
    class program
{
    public static void Main(string[] args)
    {
        int num=Convert.ToInt32(Console.ReadLine());
        books[]books=new books[num];
        for(int i=0;i<num;i++)
        {
            int id=Convert.ToInt32(Console.ReadLine());
            int pages=Convert.ToInt32(Console.ReadLine());
            string title=Console.ReadLine();
            string author=Console.ReadLine();
            double price=Convert.ToDouble(Console.ReadLine());
            books[i]=new books(id,pages,title,author,price);
        }
        string title1=Console.ReadLine();
        double max=maximumprice(books,num);
        for(int i=0;i<num;i++)
        {
            if(books[i].price.Equals(max))
            {
                Console.WriteLine(books[i].id +" " + books[i].title);
            }
        }
        books[] search=searchbook(books,title1,num);
        for(int i=0;i<num;i++)
        {
            Console.WriteLine(search[i].id);
            Console.WriteLine(search[i].pages);
        }
        
    }
    static double maximumprice(books[]books,int num)
        {
            double ma=0;
            for(int i=0;i<num;i++)
            {
                if((books[i].price.CompareTo(ma))>0)
                {
                    ma=books[i].price;
                    
                }
            }
            return ma;
            
        }
        static books[] searchbook(books[]books,string title1,int num)
        {
            books[] se=new books[0];
            for(int i=0;i<num;i++)
            {
                if(books[i].title.Equals(title1))
                {
                    Array.Resize(ref se,se.Length+1);
                    se[se.Length-1]=books[i];
                }
            }
            return se;
        }
}
class books
{
    public int id;
    public int pages;
    public string title;
    public string author;
    public double price;
    public books(int id,int pages,string title,string author,double price)
    {
        this.id=id;
        this.pages=pages;
        this.title=title;
        this.author=author;
        this.price=price;
    }

}
}

