namespace simpleDelegateLib;

public class Hero {

    // Definisi delegate untuk aksi hero
    public delegate void HeroAction();

    // Event yang dipicu saat hero melakukan aksi
    public event HeroAction OnAction;

    // Metode untuk memicu aksi hero
    public void PerformanceAction() {
        Console.WriteLine("Hero sedang melakukan aksi");
        OnAction?.Invoke();
    }
}