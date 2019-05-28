using System;
using System.Collections.Generic;

namespace SimpleChess
{
    class Board
    {
        readonly Dictionary<string,Piece> _pieces = new Dictionary<string, Piece>();

        public void Add(string position, Piece piece)
        {
            _pieces.Add(position, piece);
        }

        public bool Move(string fromPosition, string toPosition)
        {
            if (_pieces.ContainsKey(toPosition)) return false;
            if (!_pieces.ContainsKey(fromPosition) || _pieces[fromPosition] == null) return false;
            var piece = _pieces[fromPosition];
            var isPossible = _pieces[fromPosition].Move(fromPosition, toPosition);
            if (!isPossible) return false;
            if (_pieces.ContainsKey(toPosition))_pieces[toPosition] = piece;
            else _pieces.Add(toPosition, piece);
            _pieces[fromPosition] = null;
            return true;
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("\n8\n\n\n7\n\n\n6\n\n\n5\n\n\n4\n\n\n3\n\n\n2\n\n\n1");
            for (var row = 8; row >= 1; row--)
            {
                for (var col = 'a'; col <= 'h'; col++)
                {
                    var left = 1+(col - 'a') * 5;
                    var top = (8 - row) * 3;
                    Console.CursorLeft = left;
                    Console.CursorTop = top;
                    var fillChar = row % 2 == col % 2 ? ' ' : '█';
                    Write(5, fillChar);
                    Console.CursorLeft = left;
                    Console.CursorTop = top+1;
                    Write(2, fillChar);
                    var position = "" + col + row;
                    var pieceChar = _pieces.ContainsKey(position) ? _pieces[position]?.Symbol : " ";
                    Console.Write(pieceChar ?? " ");
                    Write(2, fillChar);
                    Console.CursorLeft = left;
                    Console.CursorTop = top + 2;
                    Write(5, fillChar);
                }
            }
            Console.WriteLine();
            Console.WriteLine("   A    B    C    D    E    F    G    H");
        }

        private static void Write(int count, char c)
        {
            Console.Write("".PadLeft(count, c));
        }
    }
}
