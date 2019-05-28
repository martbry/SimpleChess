namespace SimpleChess
{
    class Piece
    {
        public string Type { get; set; }

        public Piece(string type)
        {
            Type = type;
        }

        public bool Move(string fromPosition, string toPosition)
        {
            return true;
        }
    }
}
