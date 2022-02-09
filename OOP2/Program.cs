using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.Name = " Muzo ";
            musteri1.Surname = "Senkal ";
            musteri1.TcNo = "123545646";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "54321";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.TaxNo = "123423543253";
            //SOLID
            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
