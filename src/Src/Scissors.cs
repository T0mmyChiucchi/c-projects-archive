using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class Scissors: Move
    {
        public Scissors() { Name = "Scissors"; }

        public override int CompareTo(Move otherMove)
        {
            int result = 0;
            if (otherMove is Scissors)
                return result;
            else if (otherMove is Paper)
                return result = 1;
            else if(otherMove is Rock)
                return result = -1;
        }
    }
}
