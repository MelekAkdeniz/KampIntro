﻿// See https://aka.ms/new-console-template for more information

   
{
    static void Main(string[] args)
    {
        string adi = "Engin";
        int yas = 36;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demirog";
        kurs1.İzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem";
        kurs2.İzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Ptyhon";
        kurs3.Egitmen = "Melek";
        kurs3.İzlenmeOrani = 80;

        Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);


        Console.WriteLine("hello");


    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }




    }
}



