namespace FootballLeague
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            teamsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            playersToolStripMenuItem = new ToolStripMenuItem();
            teamsToolStripMenuItem1 = new ToolStripMenuItem();
            matchesToolStripMenuItem = new ToolStripMenuItem();
            refereesToolStripMenuItem = new ToolStripMenuItem();
            buttonCreate = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1027, 450);
            dataGridView1.TabIndex = 0;
            // 
            // teamsToolStripMenuItem
            // 
            teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            teamsToolStripMenuItem.Size = new Size(202, 22);
            teamsToolStripMenuItem.Text = "Teams";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { playersToolStripMenuItem, teamsToolStripMenuItem1, matchesToolStripMenuItem, refereesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1027, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(56, 20);
            playersToolStripMenuItem.Text = "Players";
            playersToolStripMenuItem.Click += playersToolStripMenuItem_Click;
            // 
            // teamsToolStripMenuItem1
            // 
            teamsToolStripMenuItem1.Name = "teamsToolStripMenuItem1";
            teamsToolStripMenuItem1.Size = new Size(52, 20);
            teamsToolStripMenuItem1.Text = "Teams";
            teamsToolStripMenuItem1.Click += teamsToolStripMenuItem1_Click;
            // 
            // matchesToolStripMenuItem
            // 
            matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            matchesToolStripMenuItem.Size = new Size(64, 20);
            matchesToolStripMenuItem.Text = "Matches";
            matchesToolStripMenuItem.Click += matchesToolStripMenuItem_Click;
            // 
            // refereesToolStripMenuItem
            // 
            refereesToolStripMenuItem.Name = "refereesToolStripMenuItem";
            refereesToolStripMenuItem.Size = new Size(63, 20);
            refereesToolStripMenuItem.Text = "Referees";
            refereesToolStripMenuItem.Click += refereesToolStripMenuItem_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCreate.BackColor = Color.LightGreen;
            buttonCreate.Font = new Font("Montserrat", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ControlText;
            buttonCreate.Location = new Point(102, 65);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(190, 81);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top;
            buttonUpdate.BackColor = Color.Gold;
            buttonUpdate.Font = new Font("Montserrat", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.ControlText;
            buttonUpdate.Location = new Point(426, 65);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(190, 81);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.BackColor = Color.LightCoral;
            buttonDelete.Font = new Font("Montserrat", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(743, 65);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 81);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 646);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += playersToolStripMenuItem_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStripMenuItem teamsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem teamsToolStripMenuItem1;
        private ToolStripMenuItem matchesToolStripMenuItem;
        private ToolStripMenuItem refereesToolStripMenuItem;
        private Button buttonCreate;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}