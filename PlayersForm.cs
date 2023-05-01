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
    public partial class PlayersForm : Form
    {
        private Player player;
        private string action;

        public PlayersForm()
        {
            InitializeComponent();
        }

        public PlayersForm(Player player, string action)
        {
            InitializeComponent();
            this.player = player;
            this.action = action;
        }

        private void CreatePlayersForm_Load(object sender, EventArgs e)
        {
            var positions = Program.context.PlayerPositions.Select(x => x.position_name).ToArray();
            comboBoxPositions.Items.AddRange(positions);

            var teams = Program.context.Teams.Select(x => x.name).ToArray();
            comboBoxTeam.Items.AddRange(teams);

            if(action != "Create")
            {
                comboBoxPositions.SelectedItem = Program.context.PlayerPositions.Where(x=>x.position_id == player.position).FirstOrDefault().position_name;
                comboBoxTeam.SelectedItem = Program.context.Teams.Where(x => x.team_id == player.team).FirstOrDefault().name;
                textBoxName.Text = player.name;
                textBoxNumber.Text = Convert.ToString(player.number);
            }

            switch (action)
            {
                case "Create":
                    buttonCreate.Text = "Create";
                    buttonCreate.BackColor = Color.LightGreen;
                    labelName.Text = "CREATE - PLAYER";
                    break;
                case "Update":
                    buttonCreate.Text = "Update";
                    buttonCreate.BackColor = Color.Gold;
                    labelName.Text = "UPDATE - PLAYER";
                    break;
                case "Delete":
                    buttonCreate.Text = "Delete";
                    buttonCreate.BackColor = Color.LightCoral;
                    labelName.Text = "DELETE - PLAYER";

                    textBoxName.ReadOnly = true;
                    textBoxNumber.ReadOnly = true;
                    comboBoxPositions.Enabled = false;
                    comboBoxTeam.Enabled = false;
                    break;
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var position = Program.context.PlayerPositions
                .Where(x => x.position_name == comboBoxPositions.SelectedItem)
                .FirstOrDefault();

            var team = Program.context.Teams
                .Where(x => x.name == comboBoxTeam.SelectedItem)
                .FirstOrDefault();

            switch (action)
            {
                case "Create":
                    var newPlayer = new Player
                    {
                        name = textBoxName.Text,
                        number = int.Parse(textBoxNumber.Text),
                        position = position.position_id,
                        team = team.team_id,
                        player_id = Program.context.Players.Count()                        
                    };

                    Program.context.Players.Add(newPlayer);
                    break;

                case "Update":
                    player.name = textBoxName.Text;
                    player.number = int.Parse(textBoxNumber.Text);
                    player.position = position.position_id;
                    player.team = team.team_id;

                    Program.context.Players.Update(player);
                    break;

                case "Delete":
                    Program.context.Players.Remove(player);
                    break;
            }

            Program.context.SaveChanges();

            MessageBox.Show($"{textBoxName.Text} {action}d As Player!");

            this.Hide();

            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }

    }
}
