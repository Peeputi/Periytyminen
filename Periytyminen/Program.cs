using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;
namespace ElainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kisu = new Kissa();
            Koira koiro = new Koira();
            kisu.nimi = "Anneli";
            koiro.nimi = "Musti";
            kisu.ika = 2;
            koiro.ika = 3;
            Console.WriteLine("Kissan nimi on " + kisu.nimi + " ja ikä on " + kisu.ika);
            Console.WriteLine("Syötä uusi kissan nimi");
            kisu.ElainNimi(Console.ReadLine());
            Console.WriteLine("Syötä kissan ikä");
            kisu.ElainIka(int.Parse(Console.ReadLine()));
            if (kisu.ElainSyojaPalautus())
            {
                Console.WriteLine("Kissan nimi on tällä hetkellä " + kisu.nimi + " ja ikä on " + kisu.ika + " ja kissa on lihansyöjä.");
            }
            else
            {
                Console.WriteLine("Kissan nimi on tällä hetkellä " + kisu.nimi + " ja ikä on " + kisu.ika + " ja kissa ei ole lihansyöjä.");
            }
            Console.ReadKey();
            Console.WriteLine("Koiran nimi on " + koiro.nimi + " ja ikä on " + koiro.ika);
            Console.WriteLine("Syötä uusi koiran nimi");
            koiro.ElainNimi(Console.ReadLine());
            Console.WriteLine("Syötä koiran ikä");
            koiro.ElainIka(int.Parse(Console.ReadLine()));
            if (kisu.ElainSyojaPalautus())
            {
                Console.WriteLine("Koiran nimi on tällä hetkellä " + koiro.nimi + " ja ikä on " + koiro.ika + " ja koira on lihansyöjä.");
            }
            else
            {
                Console.WriteLine("Koiran nimi on tällä hetkellä " + koiro.nimi + " ja ikä on " + koiro.ika + " ja koira ei ole lihansyöjä.");
            }
            Console.ReadKey();
        }
    }
}
