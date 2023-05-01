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
            switch (this.Text)
            {
                case "Players":
                    PlayersForm form = new PlayersForm(new Models.Player(), "Create");
                    this.Hide();
                    form.ShowDialog();
                    break;
                // Add cases for other tabs if desired
                default:
                    MessageBox.Show("Invalid tab selection!");
                    break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Players":
                    if (dataGridView1.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("First select the row you want to edit!");
                        return;
                    }

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string value = selectedRow.Cells[0].Value.ToString();
                    var player = Program.context.Players.Where(x => x.player_id == int.Parse(value)).FirstOrDefault();
                    PlayersForm form = new PlayersForm(player, "Update");
                    this.Hide();
                    form.ShowDialog();
                    break;
                // Add cases for other tabs if desired
                default:
                    MessageBox.Show("Invalid tab selection!");
                    break;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Players":
                    if (dataGridView1.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("First select the row you want to edit!");
                        return;
                    }

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string value = selectedRow.Cells[0].Value.ToString();
                    var player = Program.context.Players.Where(x => x.player_id == int.Parse(value)).FirstOrDefault();
                    PlayersForm form = new PlayersForm(player, "Delete");
                    this.Hide();
                    form.ShowDialog();
                    break;
                // Add cases for other tabs if desired
                default:
                    MessageBox.Show("Invalid tab selection!");
                    break;
            }
        }
    }
}
