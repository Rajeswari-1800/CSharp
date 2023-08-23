using System;
namespace raji
{
    class program
    {
        public static void Main(string[] arg)
        {
            rrt[]rrt=new rrt[4];
            for(int i=0;i<4;i++)
            {
                int no=Convert.ToInt32(Console.ReadLine());
                string raised=Console.ReadLine();
                string ass=Console.ReadLine();
                int pri=Convert.ToInt32(Console.ReadLine());
                string project=Console.ReadLine();
                rrt[i]=new rrt(no,raised,ass,pri,project);
            }
            string pri1=Console.ReadLine();
            rrt[] res=gethigh(rrt,pri1);
            Console.WriteLine(res[0].no+" "+res[0].raised+" "+res[0].ass);
            
        }
        public static rrt[] gethigh(rrt[]rrt,string pri1)
       {
            rrt[]n=new rrt[1];
            for(int i=0;i<4;i++)
            {
                for(int j=i+1;j<4;j++)
                {
                    if(rrt[i].pri>rrt[j].pri)
                    {
                        n[0]=rrt[i];
                        rrt[i]=rrt[j];
                        rrt[j]=n[0];
                    }
                }
            }
            for(int i=0;i<4;i++)
            {
                if(rrt[i].project.Equals(pri1))
                {
                    n[0]=rrt[i];
                    return n;
                }
            }
            return null;
        }
    }
    class rrt
    {
        public int no;
        public string raised;
        public string ass;
        public int pri;
        public string project;
        public rrt(int no,string raised,string ass,int pri,string project)
        {
            this.no=no;
            this.raised=raised;
            this.ass=ass;
            this.pri=pri;
            this.project=project;
        }
    }
}
