namespace divideLib;

public class divideOperations {
    public int Divide(int angka1, int angka2)
    {
        try
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException("Pembagian dengan nol");
        }
        catch (Exception e)
        {
            throw new Exception("Kesalahan operasi pembagian");
        }
        finally
        {
            Console.WriteLine("Program selesai dijalankan");
        }
    }
}