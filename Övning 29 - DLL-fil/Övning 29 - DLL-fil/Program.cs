using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQLLibrary;

namespace Övning_29___DLL_fil
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> contacts = new List<Person>();
            SQL.DeleteContact("197801011111");

            Console.WriteLine();
            contacts = SQL.ReadDatabase();
            foreach (var p in contacts)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.SSN);
            }

        }
    }
}
