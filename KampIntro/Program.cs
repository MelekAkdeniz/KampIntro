﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    string kategoriEtiketi = "Kategori";
    int ogrenciSayisi = 32000;
    double faizOrani = 1.45;
    bool sistemeGirisYapmisMi = false;
    double dolarDun = 7.45;
    double dolarBugun = 7.45;

    if (dolarDun>dolarBugun)
    {
        Console.WriteLine("Azalış butonu");
    }
    else if (dolarDun<dolarBugun)
    {
        Console.WriteLine("Artış butonu");
    }
    else
    {
        Console.WriteLine("değişmedi butonu");
    }


    if (sistemeGirisYapmisMi == true) 
    {
        Console.WriteLine("Kullanıcı ayarları butonu ");

    }
    else
    {
        Console.WriteLine("Giriş yap butonu");
    }
        
    Console.WriteLine(kategoriEtiketi);


}
