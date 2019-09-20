using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920KCSK
{
    class Program
    {
        static void Main(string[] args)
        {
            var kecskek = new List<Kecske>();

            kecskek.Add(new Kecske("Géza", true, new DateTime(1997, 10, 01)));
            kecskek.Add(new Kecske("Lukrécia", false, new DateTime(1992, 09, 17)));
            kecskek.Add(new Kecske("János", true, new DateTime(1995, 07, 30)));
            kecskek.Add(new Kecske("Gréta", false, new DateTime(1996, 01, 10)));
            kecskek.Add(new Kecske("József", false, new DateTime(1900, 01, 16)));

            Console.WriteLine("Összes kecske neve: ");
            foreach (var k in kecskek)
            {
                Console.WriteLine($"{k.Nev}");
            }
            Console.ReadKey();
        }
    }
}
