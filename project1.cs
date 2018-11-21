using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structMass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string sname;
            string lname;

            inFIO(out name, out sname, out lname);
            Console.ReadKey();
        }

        static void inFIO(out string name, out string sname, out string lname)
        {
            Console.WriteLine("Введите отчество");
            name = Console.ReadLine();
            Console.WriteLine("Введите инициалы отчества");
            sname = Console.ReadLine();
            Console.WriteLine("Введите инициалы фамилии");
            lname = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(sname);
            Console.WriteLine(lname);
        }

        static void IOF(string sname, string name, string lname)
        {


        }



        //static void FIO(string name, char sname, char lname) 
        //{ 

        //} 

        //static void IOF(char sname, char name, string lname) 
        //{ 

        //} 

        static void FIO_FULL(string name, string lname, string sname)
        {

        }
    }
}
