// Hari ke-4

using inheritance;

static class Program {
    static void Main() {
        Cars cars = new Cars("001", 6661, "dark");
        sportCars sportcars = new sportCars("C", 2002, "dark", "jarvis", "Sport");
        jeapCars jeapcars = new jeapCars();


        Console.WriteLine(cars.name);
        //Console.WriteLine(sportcars._machineCode); error
        Console.WriteLine(sportcars.name);
        Console.WriteLine(cars.yearProduct);
        Console.WriteLine(sportcars.yearProduct);
        Console.WriteLine(sportcars.variance);

        sportcars.breaking();
        sportcars.sportCarsMethode();
        jeapcars.jeapCarsMethode();
        sportcars.breaking();
        jeapcars.breaking();


        //Coba Child <----> parent
        //sportCars sportcars02 = new Cars(); error


    }
}