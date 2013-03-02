using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekken5DarkRessurectionScoreKeeper.Classes;

namespace Tekken5DarkRessurectionScoreKeeper
{
    
    

    public class Controller
    {
        public List<Player> PlayerList { get; private set; }
        public string sequence;
        Window window;


        public Controller(Window window)
        {
            this.window = window;
        }


        public void init()
        {

            // Set up sequence
            initSequence();

            // Init players:
            PlayerList = new List<Player>(2);
            PlayerList.Add(new Player());
            PlayerList.Add(new Player());
            window.LeftPlayer  = PlayerList[0];
            window.RightPlayer = PlayerList[1];

        }

        private void initSequence()
        {
            DialogResult mbSequenceInput = MessageBox.Show("Select session", "Tekken is fun!",MessageBoxButtons.OKCancel);

        }

    }
}
