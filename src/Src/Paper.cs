using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Src
{
    public class Paper: Move
    {
        public Paper() { Name = "Paper"; }

        public override int CompareTo(Move otherMove)
        {
            int result = 0;
            if (otherMove is Paper)
                return result;
            else if (otherMove is Rock)
                return result = 1;
            else if (otherMove is Scissors)
                return result = -1;
        }
}
