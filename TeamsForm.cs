using FootballLeague.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class TeamsForm : Form
    {
        private Team team;
        private string action;
        public TeamsForm()
        {
            InitializeComponent();
        }
        public TeamsForm(Team team, string action)
        {
            InitializeComponent();
            this.team = team;
            this.action = action;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            textBoxTeamName.Text = team.name;

            switch (action)
            {
                case "Create":
                    buttonCreate.Text = "Create";
                    buttonCreate.BackColor = Color.LightGreen;
                    labelName.Text = "CREATE - TEAM";
                    textBoxTeamName.Clear();
                    break;
                case "Update":
                    buttonCreate.Text = "Update";
                    buttonCreate.BackColor = Color.Gold;
                    labelName.Text = "UPDATE - TEAM";
                    break;
                case "Delete":
                    buttonCreate.Text = "Delete";
                    buttonCreate.BackColor = Color.LightCoral;
                    labelName.Text = "DELETE - TEAM";

                    textBoxTeamName.ReadOnly = true;
                    textBoxTeamName.Enabled = false;
                    break;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Create":
                    var newTeam = new Team()
                    {
                        name = textBoxTeamName.Text,
                        team_id = Program.context.Teams.Count() + 1
                    };
                    Program.context.Teams.Add(newTeam);
                    break;
                case "Update":
                    team.name = textBoxTeamName.Text;
                    Program.context.Teams.Update(team);
                    break;
                case "Delete":
                    Program.context.Teams.Remove(team);
                    break;
            }

            Program.context.SaveChanges();

            MessageBox.Show($"{textBoxTeamName.Text} {action}d As Team!");

            this.Hide();

            var form = new Form1();
            form.ShowDialog();
        }
    }
}
