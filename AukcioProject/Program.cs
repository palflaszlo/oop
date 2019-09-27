using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProject
{   
    class Program
    {
        static void Main(string[] args)
        {
            //Festmeny(cim, festo, stilus, licitekSzama, legmagasabbLicit, legutolsoLicitIdeje);
            //string festmeny = "Ablak Vasarellytől";
            Festmeny ujFestmeny = new Festmeny("ablak", "Vasarelly", "posztmodern", 0, 500, new DateTime(2019-09-20), false);
            Console.WriteLine("Ez egy új festmény: " + ujFestmeny); //itt még 500
            Console.WriteLine("Erre még nincs licit");
            /*
            while(ujFestmeny.LegmagasabbLicit<2000)
            {
                ujFestmeny.Licit(); //itt lesz 10001
                Console.WriteLine();
                Console.WriteLine(ujFestmeny); //itt írja ki az 1000-t
                
            }
            */

            while(ujFestmeny.LegmagasabbLicit < 3000)
            {
                Console.WriteLine("Adja meg az ön licitjét:");
                int mertek = Convert.ToInt32(Console.ReadLine());
                ujFestmeny.BekertLicit(mertek);
                Console.WriteLine(ujFestmeny);
            }
            

            Console.WriteLine();
            //Console.WriteLine(ujFestmeny.Licit2());
            Console.ReadLine();
        }
    }
}
