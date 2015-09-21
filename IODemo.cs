using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string content =" ";

            if(File.Exists(@"..\..\info.txt"))
            {
                content = File.ReadAllText(@"..\..\info.txt");
                Console.WriteLine("Current content: ");
                Console.WriteLine(content);

            }
            Console.WriteLine("Enter New Content -->");
            string newContent = Console.ReadLine();
            File.WriteAllText(@"..\..\info.txt",content+"\n"+newContent);
            
            Console.ReadLine();
        }
    }
 
}
