using System;

namespace ClassIntro_back_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();  //Kurs tipinde bir kurs1 oluşturuyoruz.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();  //Kurs tipinde bir kurs2 oluşturuyoruz.
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Muzo";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();  //Kurs tipinde bir kurs3 oluşturuyoruz.
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ahmet";
            kurs3.IzlenmeOrani = 95;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 }; //Kurs tipinde, Kurs dizisi oluşturuyoruz.

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen );
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs           //İçinde bir çok özellik bulunduran, 'kendimizin oluşturduğu veri tipi' diyebiliriz.
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}
