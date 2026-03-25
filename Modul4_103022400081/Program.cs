using System;
using Modul4_103022400081;

class program
{
    static void Main(string[] args)
    {
        KodePaket Kode = new KodePaket();

        Console.WriteLine("Basic : " + Kode.getKodePaket("Basic"));
        Console.WriteLine("Standard : " + Kode.getKodePaket("Standard"));
        Console.WriteLine("Premium : " + Kode.getKodePaket("Premium"));
        Console.WriteLine("Unlimited : " + Kode.getKodePaket("Unlimited"));
        Console.WriteLine("Gaming : " + Kode.getKodePaket("Gaming"));
        Console.WriteLine("Streaming : " + Kode.getKodePaket("Streaming"));
        Console.WriteLine("Family : " + Kode.getKodePaket("Family"));
        Console.WriteLine("Business : " + Kode.getKodePaket("Business"));
        Console.WriteLine("Student : " + Kode.getKodePaket("Student"));
        Console.WriteLine("Traveler : " + Kode.getKodePaket("Traveler"));

        Console.WriteLine();
        MesinKopi mesin = new MesinKopi();

        mesin.PowerOn();
        mesin.StartBrewing();
        mesin.finishBrewing();
        mesin.StartMaintanance();
        mesin.FinishMaintanace();
        mesin.PowerOff();
        mesin.StartBrewing();
    }
}
