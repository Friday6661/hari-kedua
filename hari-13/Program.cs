using System;
using System.Collections.Generic;
using System.Diagnostics;

class Game
{
    private int _boardSize;
    private Dictionary<int, int> _snakes;
    private Dictionary<int, int> _ladders;

    public Game(int boardSize)
    {
        _boardSize = boardSize;
        _snakes = new Dictionary<int, int>();
        _ladders = new Dictionary<int, int>();
    }

    public void AddSnake(int start, int end)
    {
        Debug.Assert(start > end, "Posisi awal harus lebih besar dari posisi akhir pada ular.");
        Debug.Assert(start > 0 && start <= _boardSize, "Posisi awal ular harus dalam rentang papan permainan.");
        Debug.Assert(end >= 0 && end < _boardSize, "Posisi akhir ular harus dalam rentang papan permainan.");

        _snakes[start] = end;
    }

    public void AddLadder(int start, int end)
    {
        Debug.Assert(start < end, "Posisi awal harus lebih kecil dari posisi akhir pada tangga.");
        Debug.Assert(start > 0 && start < _boardSize, "Posisi awal tangga harus dalam rentang papan permainan.");
        Debug.Assert(end >= 0 && end < _boardSize, "Posisi akhir tangga harus dalam rentang papan permainan.");

        _ladders[start] = end;
    }

}

class Program
{
    static void Main()
    {
        int boardSize = 100;

        Game game = new Game(boardSize);

        game.AddSnake(14, 7);
        game.AddSnake(21, 17);
        game.AddLadder(4, 16);
        game.AddLadder(9, 28);
    }
}
