using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public string MakeMove()
        {
            int result = Player1.Compare(Player2.PlayerMove);
            if (result == 0)
                return "Draw";
            else if (result == 1)
                return $"{Player1} won with {Player1.PlayerMove.Name}";
            else if (result == -1)
                return $"{Player2} won with {Player2.PlayerMove.Name}";
            else
                throw new ArgumentException();
        }
    }
}
