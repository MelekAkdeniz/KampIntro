﻿// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using System.Runtime.InteropServices;

internal static class ProgramHelpers
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.İzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.İzlenmeOrani = 64;


        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.İzlenmeOrani = 80;

        Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
    }

    private class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }







    }













}







