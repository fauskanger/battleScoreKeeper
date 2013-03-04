using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekken5DarkRessurectionScoreKeeper.Classes;

using FauskangerLib;

namespace Tekken5DarkRessurectionScoreKeeper
{
    public partial class Window : Form
    {


        private int charSelNumCols, charSelNumRows;
        private int charImgWidth, charImgHeight;
        private int charIndex, charSelectedCol, charSelectedRow;

        public Player LeftPlayer { set; get; }
        public Player RightPlayer { set; get; }
        Controller controller;

        public Window()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            charSelectedCol = e.X/charImgWidth;
            charSelectedRow = e.Y/charImgHeight;
            charIndex = charSelectedCol + charSelectedRow * charSelNumCols;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSetAll1.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter.Fill(this.dBDataSetAll1.Session);
            controller = new Controller(this);
         
            charSelNumCols = 12;
            charSelNumRows = 3;

            charImgWidth = pbxCharacterSelect.Image.Width / charSelNumCols;
            charImgHeight = pbxCharacterSelect.Image.Height / charSelNumRows;

            controller.init();

          //  if (controller.sessionLoadFrame != null)
            //    controller.sessionLoadFrame.BringToFront();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (Calc.isInRange(charSelectedCol, 0, 11) && Calc.isInRange(charSelectedRow, 0, 2) && (charSelectedCol != 0 || charSelectedRow != 0))
            {
                assignSelectedCharacter(e);
            }

            updateCharacterNames();
        }

        private void updateCharacterNames()
        {
            lblLeftCharacter.Text  = Character.getCharacterName(LeftPlayer.SelectedCharacter);
            lblRightCharacter.Text = Character.getCharacterName(RightPlayer.SelectedCharacter);

            lblLeftPlayerName.Text  = LeftPlayer.Name;
            lblRightPlayerName.Text = RightPlayer.Name;
        }

        private void assignSelectedCharacter(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    setCharacterToPlayer(LeftPlayer, getClickedCharacter());
                    break;
                case MouseButtons.Right:
                    setCharacterToPlayer(RightPlayer, getClickedCharacter());
                    break;
            }

        }


        private void setCharacterToPlayer(Player player, Characters character)
        {
            player.SelectedCharacter = character;
        }

        private Characters getClickedCharacter()
        {
            return Character.getCharacter(charIndex);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { 
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controller.createNewPlayer();
        }
        

        
    }
}
