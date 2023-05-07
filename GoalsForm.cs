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
        private bool updateDelete = false;
        private string goalscorer;
        private bool showGoalscorer = true;
        private string team;
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
                updateDelete = true;
            }
            this.goal = goal;
        }

        private void GoalsForm_Load(object sender, EventArgs e)
        {
            textBoxMatchID.Text = match.match_id.ToString();

            goalscorer = Program.context.Players.Where(x => x.player_id == int.Parse(goal.player)).First().name;
            team = Program.context.Teams.Where(x => x.team_id == goal.team).First().name;
            if (updateDelete)
            {
                buttonCreate.Visible = false;
                buttonUpdate.Visible = true;
                buttonDelete.Visible = true;
                //comboBoxTeam.SelectedItem = Program.context.Teams.Where(x => x.team_id == goal.team).First().name;
                comboBoxTeam.Items.Add(team);
                comboBoxTeam.SelectedIndex = 0;
                //comboBoxPlayer.SelectedItem = Program.context.Players.Where(x => x.player_id == int.Parse(goal.player)).First().name;
                comboBoxPlayer.Items.Add(goalscorer);
                comboBoxPlayer.SelectedIndex = 0;
                textBoxMinute.Text = goal.minute.ToString();
                var teams = Program.context.Teams.Where(x => x.team_id == match.team_1 || x.team_id == match.team_2).Select(x => x.name).ToList();
                teams.Remove(team);
                comboBoxTeam.Items.AddRange(teams.ToArray());
            }

            dataGridViewGoals.DataSource = Program.context.Goals.Where(x => x.match_id == match.match_id).Select(x => new { x.goal_id, x.team, x.player, x.minute }).ToArray();
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showGoalscorer)
            {
                showGoalscorer = false;
                return;
            }
            comboBoxPlayer.Items.Clear();
            var selectedTeam = Program.context.Teams.FirstOrDefault(x => x.name == comboBoxTeam.SelectedItem);
            var players = Program.context.Players.Where(x => x.team == selectedTeam.team_id).Select(x => x.name).ToArray();
            comboBoxPlayer.Items.AddRange(players);
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
                Where(x => x.name == comboBoxTeam.SelectedItem.ToString()).FirstOrDefault().team_id;
            goal.player = Program.context.Players.
                Where(x => x.name == comboBoxPlayer.SelectedItem.ToString()).FirstOrDefault().player_id.ToString();
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
