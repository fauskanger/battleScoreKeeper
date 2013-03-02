using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekken5DarkRessurectionScoreKeeper.Classes
{
    class Player
    {
        public string Name {get; set;}
        public Characters SelectedCharacter { get; set; }

        public Player(string name)
        {
            Name = name;
            SelectedCharacter = Characters.NONE;

        }

    }
}
