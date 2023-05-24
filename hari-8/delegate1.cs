namespace simpleDelegate1Lib;

public class Game {
    public delegate void GameStateChanged();

    public event GameStateChanged InteractionStateChanged;

    public void OnGameStateChanged() {
        Console.WriteLine("GameStateChanged");
        InteractionStateChanged?.Invoke();
    }

    // Event handler untuk event InteractionStateChanged

    public static void HandleGameStateChanged() {
        Console.WriteLine("Perubahan State Game sedang ditangai");
    }

    public static void PlayBacksoundMusic() {
        Console.WriteLine("Music di putar saat perubahan state game");
    }

}