namespace Metotlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            int fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { "elma","" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır";

            //type-syfe--tip güvenli

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-------metotlar----------");

            //instance - örnek
            //encapsulation- kapsülleme düzensiz yapıyı düzenin içine sokmak

            sepettManager sepetManager = new sepettManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yarmut", 12, 8);
            sepetManager.Ekle2("elma", "yelma", 12, 9);
            sepetManager.Ekle2("kkk", "ymut", 12, 8);

        }
    }
}


