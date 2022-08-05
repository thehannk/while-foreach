using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            //birden başlayıp consoledan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp consolea yazdırılması

            Console.WriteLine("Lütfen sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //a dan z e kadar tüm harfleri consolea yazdır.
            char character = 'a';
            while (character < z)
            {
                Console.Write(character);
                character++;
            }

            //foreach 

            string[] arabalar = { "Ford", "Renault", "Maserati" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
