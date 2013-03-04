using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekken5DarkRessurectionScoreKeeper
{
    public partial class SessionLoad : Form
    {

        Controller controller;

        public SessionLoad()
        {
            InitializeComponent();
        }

        public SessionLoad(Controller controller)
        {
            this.controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
