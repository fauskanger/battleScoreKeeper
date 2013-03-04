using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FauskangerLib;

namespace Tekken5DarkRessurectionScoreKeeper.Classes
{
    public class Player
    {
        public string Name {get; set;}
        public Characters SelectedCharacter { get; set; }

        static public Player createNewPlayer(bool forceComplete = false)
        {
            string name = createPlayerName(forceComplete);
            if (name != null)
                return new Player(name);
            return null;
        }

        static public Player createNewPlayer(string name)
        {
            name = createPlayerName(false, name);
            if (name != null)
                return new Player(name);
            return null;
        }

        private Player(string name)
        {
            Name = name;
            SelectedCharacter = Characters.NONE;
        }


        static private string getPlayerNameFromInput()
        {
            Random random = new Random();
            return Microsoft.VisualBasic.Interaction.InputBox("Enter player name:", "New player ", "YourPlayerName" + random.Next(100, 999).ToString());
        }

        static private string getPlayerName(bool forceComplete)
        {
            string tmpName = null;

            if (forceComplete)
            {
                while (Misc.isNullOrEmpty(tmpName))
                    tmpName = getPlayerNameFromInput();
            }
            else
            {
                tmpName = getPlayerNameFromInput();
                tmpName = Misc.isNullOrEmpty(tmpName)? null: tmpName;
            }

            return tmpName;

        }


        static private string createPlayerName(bool forceComplete, string tmpName = null)
        {
            return Misc.isNullOrEmpty(tmpName) ? getPlayerName(forceComplete) : tmpName;
        }

    }
}
