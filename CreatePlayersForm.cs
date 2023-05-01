using FootballLeague.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballLeague
{
    public partial class CreatePlayersForm : Form
    {

        public CreatePlayersForm()
        {
            InitializeComponent();
        }

        private void CreatePlayersForm_Load(object sender, EventArgs e)
        {
            var positions = Program.context.PlayerPositions.Select(x => x.position_name).ToArray();
            comboBoxPositions.Items.AddRange(positions);

            var teams = Program.context.Teams.Select(x => x.name).ToArray();
            comboBoxTeam.Items.AddRange(teams);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Player player = new Player { name = textBoxName.Text, number = int.Parse(textBoxNumber.Text) };
            var position = Program.context.PlayerPositions.Where(x => x.position_name == comboBoxPositions.SelectedItem).FirstOrDefault();
            var team = Program.context.Teams.Where(x => x.name == comboBoxTeam.SelectedItem).FirstOrDefault();
            player.position = position.position_id;
            player.team = team.team_id;
            player.player_id = Program.context.Players.Count();

            Program.context.Players.Add(player);
            Program.context.SaveChanges();

            MessageBox.Show($"{textBoxName.Text} Added As Player!");

            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}
