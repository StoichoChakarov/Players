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
using PlayerStats.Model;

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

        private void RefreshTable() => dgvPlayers.DataSource = showPlayerController.GetPlayers();

        private void button1_Click(object sender, EventArgs e)
        {

            PlayerStats.Model.Player player = new PlayerStats.Model.Player();
            player.name = textBox1.Text;
            player.points = int.Parse(textBox2.Text);
            showPlayerController.CreatePlayer(player);
            RefreshTable();
        }

    }
}
