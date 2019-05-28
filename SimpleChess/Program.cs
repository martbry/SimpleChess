using System;
using System.Text;

namespace SimpleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var bishop = new Piece("Bishop", "L");
            var rook = new Piece("Rook", "T");
            board.Set("e4", bishop);
            board.Set("f7", rook);
            while (true)
            {
                board.Show();
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                Console.Write("Hvilken rute vil du flytte fra? ");
                var positionFrom = Console.ReadLine();
                if (positionFrom == "") break;
                Console.Write("Hvilken rute vil du flytte til? ");
                var positionTo = Console.ReadLine();
                if (positionTo == "") break;
                board.Move(positionFrom, positionTo);
            }
        }
    }
}
