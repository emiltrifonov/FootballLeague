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
    public partial class MatchesForm : Form
    {
        private Match match;
        private string action;

        public MatchesForm()
        {
            InitializeComponent();
        }

        public MatchesForm(Match match, string action)
        {
            InitializeComponent();
            this.match = match;
            this.action = action;
        }

        private void MatchesForm_Load(object sender, EventArgs e)
        {
            var teams = Program.context.Teams.Select(x => x.name).ToArray();
            comboBoxHomeTeam.Items.AddRange(teams);
            comboBoxAwayTeam.Items.AddRange(teams);
            var referees = Program.context.Referees.Select(x => x.name).ToArray();
            comboBoxReferee.Items.AddRange(referees);


            if (action != "Create")
            {
                var match = Program.context.Matches.Find(this.match.match_id);
                comboBoxHomeTeam.SelectedItem = Program.context.Teams.Where(x => x.team_id == match.team_1).FirstOrDefault().name;
                comboBoxAwayTeam.SelectedItem = Program.context.Teams.Where(x => x.team_id == match.team_2).FirstOrDefault().name;
                comboBoxReferee.SelectedItem = Program.context.Referees.Where(x => x.referee_id == match.main_referee).FirstOrDefault().name;
                dateTimePicker.Value = match.date;
                dataGridView1.DataSource = Program.context.Goals.Where(x => x.match_id == match.match_id).Select(x => new { x.team, x.player, x.minute }).ToArray();
            }


            switch (action)
            {
                case "Create":
                    buttonAction.Text = "Create";
                    buttonAction.BackColor = Color.LightGreen;
                    labelName.Text = "CREATE - MATCH";
                    break;
                case "Update":
                    buttonAction.Text = "Update";
                    buttonAction.BackColor = Color.Gold;
                    labelName.Text = "UPDATE - MATCH";
                    break;
                case "Delete":
                    buttonAction.Text = "Delete";
                    buttonAction.BackColor = Color.LightCoral;
                    labelName.Text = "DELETE - MATCH";

                    comboBoxHomeTeam.Enabled = false;
                    comboBoxAwayTeam.Enabled = false;
                    comboBoxReferee.Enabled = false;
                    dateTimePicker.Enabled = false;
                    break;
            }
        }


        private void buttonAction_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditGoals_Click(object sender, EventArgs e)
        {

        }
    }
}
