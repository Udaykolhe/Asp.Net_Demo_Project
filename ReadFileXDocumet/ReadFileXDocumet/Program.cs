using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadFileXDocumet
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName =  @"c:\users\uday_11013767\documents\visual studio 2013\Projects\ReadFileXDocumet\ReadFileXDocumet\employees.xml";
            XDocument xdoc = XDocument.Load(fileName);
            foreach (XElement element in xdoc.Descendants("employee"))
            {
                int id = int.Parse(element.Element("id").Value);
                string name = element.Element("name").Value;
                string department = element.Element("department").Value;
                int salary = int.Parse(element.Element("salary").Value);
                Console.WriteLine("ID {0} , Name {1} , Department {2} , Salary {3}" , id,name,department,salary);
                Console.ReadLine();
            }

        }
    }
}
