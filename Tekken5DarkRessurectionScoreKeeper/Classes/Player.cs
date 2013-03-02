using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekken5DarkRessurectionScoreKeeper.Classes
{
    public class Player
    {
        public string Name {get; set;}
        public Characters SelectedCharacter { get; set; }

        public Player(string name)
        {
            Name = name;
            SelectedCharacter = Characters.NONE;

        }

        public Player()
        {
            Random random = new Random();
            string tmpName = "";
            while (tmpName.Length <= 0)
                tmpName = Microsoft.VisualBasic.Interaction.InputBox("Enter player name:", "New player ", "YourPlayerName" + random.Next(100,999).ToString());

            Name = tmpName;
            SelectedCharacter = Characters.NONE;

        }

    }
}
