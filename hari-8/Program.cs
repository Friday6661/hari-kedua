using simpleDelegateLib;
using simpleDelegate1Lib;
using System;

class Program {
    public static void Main(string[] args) {
        Hero hero = new Hero();

        // Mendaftarkan event handler untuk event Onaction
        hero.OnAction += HandleAction;
        hero.OnAction += LostAction;

        // Memicu aksi hero
        hero.PerformanceAction();

        Game game = new Game();

        // Mendaftarkan event handler
        game.InteractionStateChanged += Game.HandleGameStateChanged;
        game.InteractionStateChanged += Game.PlayBacksoundMusic;

        game.OnGameStateChanged();
    }

    // Event handler untuk event Onaction
    public static void HandleAction() {
        Console.WriteLine("Aksi hero telah ditangani");
    }

    public static void LostAction() {
        Console.WriteLine("Hero kehilangan aksi untuk ditangani");
    }
}