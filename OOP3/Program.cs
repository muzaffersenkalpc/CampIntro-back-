using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager(); //IKrediManager diye yapabiliriz. Aynı sonucu alırız.
                                         //**Interfaceler, o interface i implement eden classın referansını tutabilir.

            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
           //basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(),new FileLoggerService()} );
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
