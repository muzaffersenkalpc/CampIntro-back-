using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{   //corporate
    //miras- inheritance 
    
    class TuzelMusteri:Customer //tuzel ve gercek musteriyi musteri seklinde manager classında kullanmak için bunu yapıyoruz.
    {
        
        public string CompanyName { get; set; }

        public string TaxNo { get; set; }
    }
}
