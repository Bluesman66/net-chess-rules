using ChessRules;
using System;

namespace ChessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chess chess = new Chess(); 
            while (true)
            {
                Console.WriteLine(chess.Fen);
                
                var move = Console.ReadLine();
                if (string.IsNullOrEmpty(move)) break;

                chess.Move(move);
                
            }
        }
    }
}
