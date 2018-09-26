using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_TwentyOne
{
    public class Player<T>
    {

        public List<T> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static game operator +(game game, player player)
        {
            game.players.add(player);
            return game;
        }
        public static game operator -(game game, player player)
        {
            game.players.add(player);
            return game;
        }
    }
}
