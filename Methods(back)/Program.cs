using System;

namespace Methods_back_
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.StokAdedi = 8;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.StokAdedi = 19;

            Product[] products = new Product[] {product1,product2 };
            //typesafe -- tip güvenli
            foreach (Product product in products) 
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.StokAdedi);
                Console.WriteLine("---------");
            }

            Console.WriteLine("---------Methods----------");

            //encapsulation.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1); //parametre yolluyoruz.
            sepetManager.Ekle(product2);


        }
    }
}



//Don't repeat yourself - DRY - Clean code - Best Practice.