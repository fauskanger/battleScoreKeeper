using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tekken5DarkRessurectionScoreKeeper.Classes;

namespace Tekken5DarkRessurectionScoreKeeper
{
    
    

    public class Controller
    {

        public List<Player> PlayerList {get; private set;}



        public void init()
        {
            // Init players:
            PlayerList = new List<Player>(2);
            PlayerList.Add(new Player("A"));
            PlayerList.Add(new Player("B"));


        }

    }
}
