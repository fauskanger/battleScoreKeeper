using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;


using Tekken5DarkRessurectionScoreKeeper.Classes;

namespace Tekken5DarkRessurectionScoreKeeper
{
   

    public class Controller
    {
        public enum State { SETUP, RUNNING }
        
        string gameName = "Tekken 5: Resurrection Online";

        public List<Player> PlayerList { get; private set; }
        public string sequence;
        Window mainWindow;
        public State ProgramState { get; private set; }

        public SessionLoad sessionLoadFrame { get; private set; }



        public Controller(Window window)
        {
            this.mainWindow = window;
        }


        public void init()
        {

            // Set state to SETUP
            ProgramState = State.SETUP;

            // Set up sequence
            initSession();

            // Init players:
            PlayerList = new List<Player>(2);
            createNewPlayer("Player A");
            createNewPlayer("Player B");
            mainWindow.LeftPlayer  = PlayerList[0];
            mainWindow.RightPlayer = PlayerList[1];

        }

        private void initSession()
        {
            DataTable dt = ManageDB.Instance.query("SELECT id, Name FROM Session");

            string previousSessionsString = "";

            foreach (DataRow dr in dt.Rows)
            {
                previousSessionsString += dr["Name"] + " has the id: " + dr["id"] + "\n";
            }


            DialogResult mbSessionInput = MessageBox.Show("Start a new session?", "Session setup", MessageBoxButtons.YesNo);
            Random random = new Random();
            string sessionName = "";
            if (mbSessionInput == DialogResult.Yes)
            {
                sessionName = Microsoft.VisualBasic.Interaction.InputBox("Enter session name:", "New session", "SessionName" + random.Next(1000, 9999).ToString());
            }
            else
            {
                sessionLoadFrame = new SessionLoad();
                sessionLoadFrame.Show();
                sessionLoadFrame.BringToFront();
                //sessionName = Microsoft.VisualBasic.Interaction.InputBox(previousSessionsString + "\n\nEnter session id:", "Select session", "SessionName" + random.Next(1000, 9999).ToString());
            }

            mainWindow.Text = gameName + " - " + sessionName;

        }

        public Player createNewPlayer(bool forceCreation=false)
        {
            Player p = Player.createNewPlayer(forceCreation);
            if(p!=null)
                registerPlayer(p);
            return p;
        }

        public Player createNewPlayer(string name)
        {
            Player p = Player.createNewPlayer(name);
            if (p != null)
                registerPlayer(p);
            return p;
        }

        private void registerPlayer(Player p)
        {
            // Add to playerlist
            PlayerList.Add(p);
            
            // Create TabPage for new player
            mainWindow.tcMain.TabPages.Add(p.Name, p.Name);
            TabPage tp = mainWindow.tcMain.TabPages[p.Name];
            tp.BackColor = System.Drawing.Color.White;

            mainWindow.listView1.Items.Add(p.Name);
        }

        internal void showWindow(Form win)
        {
            win.BringToFront();
        }
    }
}
