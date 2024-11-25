using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar1
{
    internal class sepettManager
    {
        //naming convention
        //syntax yazım şekli
        //parametre
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler.Sepete Eklendi : " + urun.Adi);


        }

        public void Ekle2(string urunAdi, string sciklama, double fiyat, int stokAdedi )
        {
            Console.WriteLine("tebrikler.Sepete Eklendi :" + urunAdi);


        }
    }
}
