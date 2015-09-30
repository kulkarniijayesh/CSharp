using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexedNames Names = new IndexedNames();

            Names[0] = "A";
            Names[1] = "B";
            Names[2] = "C";
            Names[3] = "D";
            Names[4] = "E";
            Names[5] = "F";
            Names[6] = "G";
            Names[7] = "H";
            Names[8] = "I";

            for (int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(Names[i]);
            }
            Console.ReadLine();
        }
    }
    public class IndexedNames
    {
        static public int size = 10;
        private string[] NameList = new string[size];
      
        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
            {
                NameList[i] = "N.A.";
            }
        }

        public string this[int index]
        {
            get
            {
                return NameList[index];
            }
            set
            {
                NameList[index] = value;
            }
        }

    }
}
