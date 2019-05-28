using System;

namespace SimpleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var bishop = new Piece("Bishop");
            var rook = new Piece("Rook");
            board.Add("e4", bishop);
            board.Add("f7", rook);

        }
    }
}
