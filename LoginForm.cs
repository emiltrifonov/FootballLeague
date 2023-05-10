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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Program.context.Referees.Select(x => x.name).ToList().Contains(textBoxLogin.Text))
            {
                MessageBox.Show($"Welcome, {textBoxLogin.Text}!");
                var form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Wrong name!");
                textBoxLogin.Clear();
            }
        }
    }
}
