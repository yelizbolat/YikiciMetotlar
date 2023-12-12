using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YikiciMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");
            Otomobil oto = new Otomobil();
            Console.WriteLine("Program bitti.");
        }
    }
    class Otomobil
    {
        string marka = "";
        string renk = "";
        public Otomobil()
        {
            marka = "TOGG";
            renk = "kırmızı";
            Console.WriteLine("YAPİCİ METOT CALİSTİ.");
        }
        ~Otomobil()
        {
            Console.WriteLine("NESNE HAFİZADAN CİKTİ.");
        }
    }
}
