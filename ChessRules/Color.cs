using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessRules
{
    enum Color
    {
        none,
        white,
        black
    }

    static class ColorMethods
    {
        public static Color FlipColor(this Color color)
        {
            return color == Color.white ? Color.black : color == Color.black ? Color.white : color;
        }
    } 
}
