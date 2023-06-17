using System;
using System.IO;
using System.Xml;

namespace ReadXMLDocumentation
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            string fileName =  "c:\\users\\uday_11013767\\documents\\visual studio 2013\\Projects\\XMLDocumentation\\XMLDocumentation\\employees.xml";
            doc.Load(fileName);
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/employees/employee");
            foreach (XmlNode node in  nodes)
            {
                XmlNode id = node.SelectSingleNode("id");
                    if (id != null)
	                    {
		                     Console.WriteLine(id.InnerText);
	                    }
                XmlNode name = node.SelectSingleNode("name");
                 if (name != null)
	                    {
		                     Console.WriteLine(name.InnerText);
	                    }
                XmlNode department = node.SelectSingleNode("department");
                 if (department != null)
	                    {
		                     Console.WriteLine(department.InnerText);
	                    }
                XmlNode salary = node.SelectSingleNode("salary");
                 if (salary != null)
	                    {
		                     Console.WriteLine(salary.InnerText);
	                    }
            //    Console.WriteLine("ID: {0}, Name: {1}, Department: {2}, Salary: {3}", id, name, department, salary); 
                Console.ReadLine();
            }
        }
    }
}
