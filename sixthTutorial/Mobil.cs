using KendaraanLib;
namespace MobilLib;

class Mobil : Kendaraan {
    public string merkMobil;
    public int tahunProduksi;

    public Mobil(){}

    public Mobil(string jenisKendaraan, string warnaKendaraan, string merkMobil, int tahunProduksi) : base(jenisKendaraan, warnaKendaraan){
        this.merkMobil = merkMobil;
        this.tahunProduksi = tahunProduksi;
    }

    public Mobil(string jenisKendaraan, string warnaKendaraan, int KapasitasBahanBakar, int jumlahRoda, string merkMobil, int tahunProduksi) : base(jenisKendaraan, warnaKendaraan, jumlahRoda, KapasitasBahanBakar){
        this.merkMobil = merkMobil;
        this.tahunProduksi = tahunProduksi;
    }

    public void startWiper(){
        Console.WriteLine("Nyalakan Wiper");
    }

    public void stopWiper(){
        Console.WriteLine("Matikan Wiper");
    }

    public new void nyalakanRadio(){
        Console.WriteLine("New Nyalakan Radio");
    }
}