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
    public partial class RefereesForm : Form
    {
        private string action;
        private Referee referee;
        public RefereesForm(Referee referee, string action)
        {
            InitializeComponent();
            this.action = action;
            this.referee = referee;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void RefereesForm_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Create":
                    buttonAction.Text = "Create";
                    buttonAction.BackColor = Color.LightGreen;
                    labelName.Text = "CREATE - REFEREE";
                    break;
                case "Update":
                    buttonAction.Text = "Update";
                    buttonAction.BackColor = Color.Gold;
                    labelName.Text = "UPDATE - REFEREE";
                    textBoxName.Text = referee.name;
                    comboBoxPosition.SelectedIndex = int.Parse(referee.position) - 1;
                    break;
                case "Delete":
                    buttonAction.Text = "Delete";
                    buttonAction.BackColor = Color.LightCoral;
                    labelName.Text = "DELETE - REFEREE";
                    textBoxName.Text = referee.name;
                    textBoxName.Enabled = false;
                    comboBoxPosition.SelectedIndex = int.Parse(referee.position) - 1;
                    comboBoxPosition.Enabled = false;
                    break;
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Create":
                    var newRef = new Referee()
                    {
                        referee_id = Program.context.Referees.Count() + 1,
                        name = textBoxName.Text,
                        position = (comboBoxPosition.SelectedIndex + 1).ToString()
                    };
                    Program.context.Referees.Add(newRef);
                    Program.context.SaveChanges();
                    break;
                case "Update":
                    referee.name = textBoxName.Text;
                    referee.position = (comboBoxPosition.SelectedIndex + 1).ToString();
                    Program.context.Referees.Update(referee);
                    Program.context.SaveChanges();
                    break;
                case "Delete":
                    Program.context.Referees.Remove(referee);
                    Program.context.SaveChanges();
                    break;
                default: break;
            }

            MessageBox.Show($"{referee.name} {action}d As Referee!");
            var form = new Form1();
            this.Hide();
            form.ShowDialog();
        }
    }
}
