// See https://aka.ms/new-console-template for more information
using KendaraanLib;
using MobilLib;
using SepedaMotorLib;

class Program {
    static void Main(){
        var kendaraan01 = new Kendaraan();
        var kendaraan02 = new Kendaraan();
        var mobil01 = new Mobil();
        var motor01 = new SepedaMotor();

        kendaraan01.jenisKendaraan = "Mobil";
        kendaraan01.warnaKendaraan = "Hitam";
        kendaraan01.jumlahRoda = 5;

        
        kendaraan01.jenisKendaraan = "Motor";
        kendaraan01.warnaKendaraan = "Hitam";
        kendaraan01.jumlahRoda = 1;
        kendaraan01.KapasitasBahanBakar = 20; //

        mobil01.merkMobil = "Nan";
        mobil01.tahunProduksi = 2005;

        motor01.merkSepedaMotor = "yoo";
        motor01.tahunProduksiMotor = 2005;
        Console.WriteLine("Keluaran Kendaraan");
        Console.WriteLine("================================================");
        Console.WriteLine(kendaraan01.jenisKendaraan);
        Console.WriteLine(kendaraan01.warnaKendaraan);
        Console.WriteLine(kendaraan01.jumlahRoda);
        Console.WriteLine(kendaraan01.KapasitasBahanBakar);


        Console.WriteLine("================================================");
        Console.WriteLine("Keluran Mobil");
        Console.WriteLine(mobil01.merkMobil);
        Console.WriteLine(mobil01.tahunProduksi);

        Console.WriteLine("================================================");
        Console.WriteLine("Keluran Override");
        kendaraan01.Start();
        kendaraan02.Stop();
        mobil01.Start();
        mobil01.Stop();

        Console.WriteLine("================================================");
        Console.WriteLine("Keluaran Hiding");
        motor01.Start();
        motor01.Stop();

        // percobaan Methode Hiding
        Mobil mobil03 = new Mobil();
        Kendaraan kendaraan03 = new Kendaraan();
        mobil03.nyalakanRadio();
    }


}
