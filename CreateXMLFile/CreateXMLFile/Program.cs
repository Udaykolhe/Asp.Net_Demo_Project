using System;
using System.Xml.Linq;

namespace CreateXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //createXML();
             createXMLWithNamespace();
             Console.ReadLine();
           
        }
        private static void createXMLWithNamespace()
        {
            XNamespace nAW = "http://www.adventure-works.com";
            XNamespace nFC = "www.fouthcoffee.com";
            XDocument xdoc = new XDocument(
                new XElement(nAW + "Root",
                    new XAttribute(XNamespace.Xmlns + "aw", "http://www.adventure-works.com"),
                    new XAttribute(XNamespace.Xmlns + "fc", "www.fouthcoffee.com"),
                    new XElement(nFC +"Child",
                        new XAttribute("Color", "Red"),
                        new XElement(nAW + "DifferentChild", "Other Content")
                        ),
                        new XElement ( nAW + "Child2" , "Child2 Content"
                            ,new XAttribute("color" , "Yellow" )
                            ),
                        new XElement (nFC + "Child3" , "Child3 Content"),
                        new XElement(nFC + "Daughter",
                            new XAttribute("Size","XL"),
                            new XElement("Child1" , "DChild1"),
                            new XElement("Child2", "DChild2")
                             )
                    )
                );

           // Console.WriteLine(xdoc);
            xdoc.Save(@"C:\Users\uday_11013767\Documents\Visual Studio 2013\Projects\CreateXMLFile\CreateXMLFile\childwithNamespace.xml");
        }
         static void createXML()
        {
            XDocument xdoc = new XDocument(
               new XComment("<!-- This Is  a comment>"),
               new XProcessingInstruction("xml-stylesheet", "href='mystyle.css' title='Compact' type='text/css'"),
                //Parents Node
               new XElement("employees",
                // Child Node
                              new XElement("employee",
                //Sibbling Node
                                            new XElement("Name", "Uday"),
                                            new XElement("Age", 25)
                      ),
                      new XElement("employee",
                             new XElement("Name", "Vipul"),
                             new XElement("Age", 26)
                       ),
                       new XElement("employee",
                             new XElement("Name", "Mayur"),
                             new XElement("Age", 28)
                             )
               ));
            Console.WriteLine(xdoc);
            xdoc.Save(@"C:\Users\uday_11013767\Documents\Visual Studio 2013\Projects\CreateXMLFile\CreateXMLFile\employee.xml");
            Console.ReadLine();
        }
    }
}
