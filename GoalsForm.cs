using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballLeague.Models;

namespace FootballLeague
{
    public partial class GoalsForm : Form
    {
        private Goal goal;
        private Match match;
        public GoalsForm(Match match)
        {
            InitializeComponent();
            this.match = match;
        }
        public GoalsForm(Match match, string action, Goal goal)
        {
            InitializeComponent();
            this.match = match;
            if (action != "Create")
            {
                buttonCreate.Visible = false;
                buttonUpdate.Visible = true;
                buttonDelete.Visible = true;
                comboBoxTeam.Items.Add(Program.context.Teams.Where(x => x.team_id == goal.team).FirstOrDefault().name);
                comboBoxTeam.SelectedIndex = 0;
                comboBoxPlayer.Items.Add(Program.context.Players.Where(x => x.name == goal.player).FirstOrDefault().name);
                comboBoxPlayer.SelectedIndex = 0;
                textBoxMinute.Text = goal.minute.ToString();
            }
            this.goal = goal;
        }

        private void GoalsForm_Load(object sender, EventArgs e)
        {
            var teams = Program.context.Teams.Where(x => x.team_id == match.team_1 || x.team_id == match.team_2).Select(x => x.name).ToList();
            teams.Remove(goal.team.ToString());
            comboBoxTeam.Items.Add(teams);
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            var team = Program.context.Teams.FirstOrDefault(x => x.name == comboBoxTeam.SelectedItem);
            var players = Program.context.Players.Where(x => x.team == team.team_id).Select(x => x.name).ToList();
            comboBoxPlayer.Items.AddRange(players.ToArray());
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var goal = new Goal()
            {
                goal_id = Program.context.Goals.Count() + 1,
                match = this.match,
                player = Program.context.Players.Select(x => x.name).Where(x => x == comboBoxPlayer.SelectedItem.ToString()).FirstOrDefault(),
                minute = int.Parse(textBoxMinute.Text)
            };

            Program.context.Goals.Add(goal);
            Program.context.SaveChanges();
            var form = new MatchesForm(match, "Update");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            goal.team = Program.context.Teams.
                Where(x => x.name == comboBoxTeam.SelectedItem.ToString()).Select(x => x.team_id).FirstOrDefault();
            goal.player = Program.context.Teams.Select(x => x.name).
                Where(x => x == comboBoxTeam.SelectedItem.ToString()).FirstOrDefault();
            goal.minute = int.Parse(textBoxMinute.Text);
            Program.context.Goals.Update(goal);

            Program.context.SaveChanges();
            var form = new MatchesForm(match, "Update");
            this.Hide();
            form.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Program.context.Goals.Remove(goal);
            Program.context.SaveChanges();
            var form = new MatchesForm(match, "Update");
            this.Hide();
            form.ShowDialog();
        }
    }
}
