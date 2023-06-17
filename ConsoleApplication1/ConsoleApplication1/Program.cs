using System;
using System.Collections;

namespace ConsoleApplication1
{
   
    class Practice
    {
        private int  m_id;
        private string m_name;
        private string m_deg;


        public Practice()
        {
            
        }

        public Practice(int id, string name, string deg)
        {
            this.m_id = id;
            this.m_name = name;
            this.m_deg = deg;

        }

        public int Id
        {
            get { return m_id; }
            set {m_id= value ; }
        }
        public string Name
        {
            get { return m_name; }
            set { m_name = value;  }
        }

        public string Deg
        {
            get { return m_deg; }
            set { m_deg = value;  }
        }
        public void save()
        {
            Console.WriteLine("Enter Id :");
            m_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name :");
           m_name=  Console.ReadLine();
           Console.WriteLine("Enter Designation :");
           m_deg = Console.ReadLine();


        }

        public void display()
        {
            Console.WriteLine("Details of employee: ");
            Console.WriteLine("Id: {0}", m_id);
            Console.WriteLine("Name: {0}", m_name);
            Console.WriteLine("Desigantion: {0}", m_deg);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Practice pract = new Practice();
            ArrayList arr = new ArrayList();
                    pract.save();
            pract.display();
            Console.ReadLine();

        }
    }
}
