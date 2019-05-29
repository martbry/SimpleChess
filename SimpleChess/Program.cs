using System;
using System.Text;

namespace SimpleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var board = new Board();
            var bishop = new Piece("Bishop", "LPR");
            var rook = new Piece("Rook", "TRN");
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
