using KendaraanLib;
namespace SepedaMotorLib;

class SepedaMotor : Kendaraan {
    public string merkSepedaMotor;
    public int tahunProduksiMotor;

    public SepedaMotor(){}

    public SepedaMotor(string jenisKendaraan, string warnaKendaraan, string merkSepedaMotor, int tahunProduksiMotor) : base(jenisKendaraan, warnaKendaraan){
        this.merkSepedaMotor = merkSepedaMotor;
        this.tahunProduksiMotor = tahunProduksiMotor;
    }

    public SepedaMotor(string jenisKendaraan, string warnaKendaraan, int jumlahRoda, string merkMobil, int tahunProduksi) : base(jenisKendaraan, warnaKendaraan, jumlahRoda){
        this.merkSepedaMotor = merkSepedaMotor;
        this.tahunProduksiMotor = tahunProduksiMotor;
    }

    public override void Start(){
        Console.WriteLine("Motor Start Engine");
    }

    public override void Stop(){
        Console.WriteLine("Motor Stop Engine");
    }
}