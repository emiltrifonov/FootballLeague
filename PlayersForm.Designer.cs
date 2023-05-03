namespace FootballLeague
{
    partial class PlayersForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxPositions = new ComboBox();
            comboBoxTeam = new ComboBox();
            textBoxNumber = new TextBox();
            buttonCreate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(59, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(272, 33);
            labelName.TabIndex = 0;
            labelName.Text = "CREATE - PLAYER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 61);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(139, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(181, 23);
            textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 113);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 3;
            label2.Text = "Position:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 166);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 4;
            label3.Text = "Team:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 221);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 5;
            label4.Text = "Number:";
            // 
            // comboBoxPositions
            // 
            comboBoxPositions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPositions.FormattingEnabled = true;
            comboBoxPositions.Location = new Point(139, 109);
            comboBoxPositions.Name = "comboBoxPositions";
            comboBoxPositions.Size = new Size(181, 23);
            comboBoxPositions.TabIndex = 6;
            // 
            // comboBoxTeam
            // 
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeam.FormattingEnabled = true;
            comboBoxTeam.Location = new Point(139, 162);
            comboBoxTeam.Name = "comboBoxTeam";
            comboBoxTeam.Size = new Size(181, 23);
            comboBoxTeam.TabIndex = 7;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(139, 217);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(181, 23);
            textBoxNumber.TabIndex = 8;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCreate.BackColor = Color.LightGreen;
            buttonCreate.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ControlText;
            buttonCreate.Location = new Point(117, 347);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(190, 56);
            buttonCreate.TabIndex = 9;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(131, 279);
            button1.Name = "button1";
            button1.Size = new Size(161, 42);
            button1.TabIndex = 10;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 439);
            Controls.Add(button1);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxNumber);
            Controls.Add(comboBoxTeam);
            Controls.Add(comboBoxPositions);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(labelName);
            Name = "PlayersForm";
            Text = "CreatePlayersForm";
            Load += CreatePlayersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxPositions;
        private ComboBox comboBoxTeam;
        private TextBox textBoxNumber;
        private Button buttonCreate;
        private Button button1;
    }
}