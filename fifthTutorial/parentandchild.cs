namespace inheritance;

class Cars {
    public string name; // Variable nama
    public int yearProduct;// Variable Tahun Produksi
    public string color; // Variable warna mobil
   

    //Constructor
    public Cars(string name, int yearProduct, string color) {
            this.name = name;
            this.yearProduct = yearProduct;
            this.color = color;
        }
    
    public Cars(string name){}

    //Constructor
    public Cars() {}

    //methode
    public void breaking() {
        Console.WriteLine("Cars.breaking");
    }

}

class jeapCars : Cars {
    public void jeapCarsMethode(){
        Console.WriteLine("Cars.jeapCarsMethode");
    }
}

class sportCars : Cars {
    public string variance;
     private string _machineCode; // Variable kode mesin
    public sportCars(string name, int yearProduct, string color, string _machineCode, string variance) : base(name, yearProduct, color){
        this.variance = variance;
        this._machineCode = _machineCode;
    }
    public sportCars(string name) : base(name) {}
    
    public void sportCarsMethode() {
        Console.WriteLine("sportCars.sportCarsMethode");
    }
}