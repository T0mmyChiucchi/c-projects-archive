using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class Player
    {
        public Move PlayerMove { get; set; }

        public Player(Move move) { PlayerMove = move; }
        public Player() { }

        public int Compare(Move otherMove)
        {
            return PlayerMove.CompareTo(otherMove);
        }
    }
}
