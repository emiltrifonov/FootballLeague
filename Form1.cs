namespace FootballLeague
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void teamsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var teams = Program.context.Teams.ToList();
            dataGridView1.DataSource = teams;
            this.Text = "Teams";
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var players = Program.context.Players.ToList();
            dataGridView1.DataSource = players;
            this.Text = "Players";
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var matches = Program.context.Matches.ToList();
            dataGridView1.DataSource = matches;
            this.Text = "Matches";
        }

        private void refereesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var referees = Program.context.Referees.ToList();
            dataGridView1.DataSource = referees;
            this.Text = "Referees";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreatePlayersForm form = new CreatePlayersForm();
            form.ShowDialog();
            this.Hide();
        }
    }
}
