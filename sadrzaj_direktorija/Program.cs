using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sadrzaj_dir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija");
            string Putanja = Console.ReadLine();
            if (Directory.Exists(Putanja) == false)
            {
                Console.WriteLine("Direktorij koji ste naveli ne postoji!");
                Console.Read();
            }
            else
            {
                string[] Datoteke = Directory.GetFiles(Putanja);
                foreach (string x in Datoteke)
                {
                    Console.WriteLine(x);
                }
                Console.Read();
            }
        }
    }
}
