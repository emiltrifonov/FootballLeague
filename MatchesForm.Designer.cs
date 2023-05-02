namespace FootballLeague
{
    partial class MatchesForm
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
            comboBoxHomeTeam = new ComboBox();
            label2 = new Label();
            comboBoxAwayTeam = new ComboBox();
            label3 = new Label();
            comboBoxReferee = new ComboBox();
            label4 = new Label();
            dateTimePicker = new DateTimePicker();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            buttonEditGoals = new Button();
            buttonAction = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Montserrat", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(132, 21);
            labelName.Name = "labelName";
            labelName.Size = new Size(196, 43);
            labelName.TabIndex = 0;
            labelName.Text = "MATCHES";
            // 
            // comboBoxHomeTeam
            // 
            comboBoxHomeTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHomeTeam.FormattingEnabled = true;
            comboBoxHomeTeam.Location = new Point(158, 91);
            comboBoxHomeTeam.Name = "comboBoxHomeTeam";
            comboBoxHomeTeam.Size = new Size(228, 23);
            comboBoxHomeTeam.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 10;
            label2.Text = "Home Team:";
            // 
            // comboBoxAwayTeam
            // 
            comboBoxAwayTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAwayTeam.FormattingEnabled = true;
            comboBoxAwayTeam.Location = new Point(158, 134);
            comboBoxAwayTeam.Name = "comboBoxAwayTeam";
            comboBoxAwayTeam.Size = new Size(228, 23);
            comboBoxAwayTeam.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 138);
            label3.Name = "label3";
            label3.Size = new Size(102, 19);
            label3.TabIndex = 12;
            label3.Text = "Away Team:";
            // 
            // comboBoxReferee
            // 
            comboBoxReferee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReferee.FormattingEnabled = true;
            comboBoxReferee.Location = new Point(158, 176);
            comboBoxReferee.Name = "comboBoxReferee";
            comboBoxReferee.Size = new Size(228, 23);
            comboBoxReferee.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 180);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 14;
            label4.Text = "Referee:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(158, 220);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 23);
            dateTimePicker.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(92, 224);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 17;
            label5.Text = "Date:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 419);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(457, 150);
            dataGridView1.TabIndex = 18;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 390);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 19;
            label6.Text = "Goals";
            // 
            // buttonEditGoals
            // 
            buttonEditGoals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditGoals.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEditGoals.BackColor = Color.Gold;
            buttonEditGoals.Font = new Font("Montserrat", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditGoals.ForeColor = SystemColors.ControlText;
            buttonEditGoals.Location = new Point(292, 379);
            buttonEditGoals.Name = "buttonEditGoals";
            buttonEditGoals.Size = new Size(153, 34);
            buttonEditGoals.TabIndex = 9;
            buttonEditGoals.Text = "Edit goals";
            buttonEditGoals.UseVisualStyleBackColor = false;
            buttonEditGoals.Click += buttonEditGoals_Click;
            // 
            // buttonAction
            // 
            buttonAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAction.BackColor = Color.LightGreen;
            buttonAction.Font = new Font("Montserrat", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAction.ForeColor = SystemColors.ControlText;
            buttonAction.Location = new Point(138, 274);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(190, 56);
            buttonAction.TabIndex = 10;
            buttonAction.Text = "Create";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // MatchesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 569);
            Controls.Add(buttonAction);
            Controls.Add(buttonEditGoals);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker);
            Controls.Add(comboBoxReferee);
            Controls.Add(label4);
            Controls.Add(comboBoxAwayTeam);
            Controls.Add(label3);
            Controls.Add(comboBoxHomeTeam);
            Controls.Add(label2);
            Controls.Add(labelName);
            Name = "MatchesForm";
            Text = "MatchesForm";
            Load += MatchesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private ComboBox comboBoxHomeTeam;
        private Label label2;
        private ComboBox comboBoxAwayTeam;
        private Label label3;
        private ComboBox comboBoxReferee;
        private Label label4;
        private DateTimePicker dateTimePicker;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Button buttonEditGoals;
        private Button buttonAction;
    }
}