using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessRules
{
    public class Chess
    {
        public string Fen { get; private set; }

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.Fen = fen;
        }

        public Chess Move(string move)
        {
            Chess nextChess = new Chess(this.Fen);
            Color color = Color.white;
            color = color.FlipColor();
            return nextChess;
        }

        public Char GetFigureAt(int x, int y)
        {
            return '.';
        }
    }
}
