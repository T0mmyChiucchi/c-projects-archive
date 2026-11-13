using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Src
{
    public class Paper : Move
    {
        public Paper() { Name = "Paper"; }

        public override int CompareTo(Move otherMove)
        {
            if (otherMove is Paper)
                return 0;
            else if (otherMove is Rock)
                return 1;
            else if (otherMove is Scissors)
                return -1;
            else
                throw new ArgumentException("Tipo di mossa non supportato", nameof(otherMove));
        }
    }
}
