namespace FootballLeague
{
    partial class GoalsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            comboBoxTeam = new ComboBox();
            label2 = new Label();
            comboBoxPlayer = new ComboBox();
            label3 = new Label();
            textBoxMinute = new TextBox();
            label4 = new Label();
            buttonCreate = new Button();
            buttonMenu = new Button();
            dataGridViewGoals = new DataGridView();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            textBoxMatchID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoals).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(0, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(365, 33);
            labelName.TabIndex = 10;
            labelName.Text = "GOALS";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxTeam
            // 
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeam.FormattingEnabled = true;
            comboBoxTeam.Location = new Point(114, 123);
            comboBoxTeam.Name = "comboBoxTeam";
            comboBoxTeam.Size = new Size(181, 23);
            comboBoxTeam.TabIndex = 11;
            comboBoxTeam.SelectedIndexChanged += comboBoxTeam_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 127);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 10;
            label2.Text = "Team:";
            // 
            // comboBoxPlayer
            // 
            comboBoxPlayer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlayer.FormattingEnabled = true;
            comboBoxPlayer.Location = new Point(114, 170);
            comboBoxPlayer.Name = "comboBoxPlayer";
            comboBoxPlayer.Size = new Size(181, 23);
            comboBoxPlayer.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 174);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 10;
            label3.Text = "Player:";
            // 
            // textBoxMinute
            // 
            textBoxMinute.Location = new Point(114, 218);
            textBoxMinute.Name = "textBoxMinute";
            textBoxMinute.Size = new Size(181, 23);
            textBoxMinute.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 218);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 10;
            label4.Text = "Minute:";
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCreate.BackColor = Color.LightGreen;
            buttonCreate.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ControlText;
            buttonCreate.Location = new Point(126, 334);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(134, 56);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.ButtonHighlight;
            buttonMenu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenu.Location = new Point(114, 265);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(161, 42);
            buttonMenu.TabIndex = 21;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // dataGridViewGoals
            // 
            dataGridViewGoals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGoals.Dock = DockStyle.Bottom;
            dataGridViewGoals.Location = new Point(0, 405);
            dataGridViewGoals.Name = "dataGridViewGoals";
            dataGridViewGoals.RowTemplate.Height = 25;
            dataGridViewGoals.Size = new Size(365, 150);
            dataGridViewGoals.TabIndex = 22;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUpdate.BackColor = Color.Gold;
            buttonUpdate.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.ForeColor = SystemColors.ControlText;
            buttonUpdate.Location = new Point(33, 334);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(152, 56);
            buttonUpdate.TabIndex = 23;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Visible = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.BackColor = Color.LightCoral;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(203, 334);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(134, 56);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Visible = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 74);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 25;
            label1.Text = "Match ID:";
            // 
            // textBoxMatchID
            // 
            textBoxMatchID.Enabled = false;
            textBoxMatchID.Location = new Point(114, 74);
            textBoxMatchID.Name = "textBoxMatchID";
            textBoxMatchID.Size = new Size(181, 23);
            textBoxMatchID.TabIndex = 26;
            // 
            // GoalsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 555);
            Controls.Add(textBoxMatchID);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridViewGoals);
            Controls.Add(buttonMenu);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxMinute);
            Controls.Add(label4);
            Controls.Add(comboBoxPlayer);
            Controls.Add(label3);
            Controls.Add(comboBoxTeam);
            Controls.Add(label2);
            Controls.Add(labelName);
            Name = "GoalsForm";
            Text = "GoalsForm";
            Load += GoalsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private ComboBox comboBoxTeam;
        private Label label2;
        private ComboBox comboBoxPlayer;
        private Label label3;
        private TextBox textBoxMinute;
        private Label label4;
        private Button buttonCreate;
        private Button buttonMenu;
        private DataGridView dataGridViewGoals;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label1;
        private TextBox textBoxMatchID;
    }
}