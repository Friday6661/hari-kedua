namespace KendaraanLib;

class Kendaraan {
    public string jenisKendaraan;
    public string warnaKendaraan;
    public int jumlahRoda;

    private int _kapasitasBahanBakar;

    //Properties untuk private variabel kapasitasBahanBakar
    public int KapasitasBahanBakar {
        get {
            return _kapasitasBahanBakar;
        }
        set {
            _kapasitasBahanBakar = value;
        }
    }

    //Constructor

    public Kendaraan(){}

    public Kendaraan(string jenisKendaraan, string warnaKendaraan){
        this.jenisKendaraan = jenisKendaraan;
        this.warnaKendaraan = warnaKendaraan;
    }
    public Kendaraan(string jenisKendaraan, string warnaKendaraan, int jumlahRoda) {
            this.jenisKendaraan = jenisKendaraan;
            this.warnaKendaraan = warnaKendaraan;
            this.jumlahRoda = jumlahRoda;
        }
    public Kendaraan(string jenisKendaraan, string warnaKendaraan, int jumlahRoda, int KapasitasBahanBakar) {
            this.jenisKendaraan = jenisKendaraan;
            this.warnaKendaraan = warnaKendaraan;
            this.jumlahRoda = jumlahRoda;
            this.KapasitasBahanBakar = KapasitasBahanBakar;
        }
    public virtual void Start(){
        Console.WriteLine("Kendaraan Start");
    }

    public virtual void Stop(){
        Console.WriteLine("Kendaraan Stop");
    }

    public void nyalakanRadio(){
        Console.WriteLine("Nyalakan Radio Kendaraan");
    }

    public void matikanRadio(){
        Console.WriteLine("Matikan Radio Kendaraan");
    }

}