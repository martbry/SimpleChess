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
            var success = _pieces[fromPosition].Move(fromPosition, toPosition);
            return success;
        }

        public void Show()
        {
            Console.Clear();

        }
    }
}
