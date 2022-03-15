using PlayerStats.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerStats.View
{
    public partial class Player : Form
    {
        PlayerController showPlayerController = new PlayerController();
        public Player()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playerDBDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.playerDBDataSet.Player);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
