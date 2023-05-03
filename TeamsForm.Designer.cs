namespace FootballLeague
{
    partial class TeamsForm
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
            label2 = new Label();
            textBoxTeamName = new TextBox();
            buttonCreate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(77, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(247, 36);
            labelName.TabIndex = 0;
            labelName.Text = "CREATE - TEAM";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "Team name:";
            // 
            // textBoxTeamName
            // 
            textBoxTeamName.Location = new Point(146, 100);
            textBoxTeamName.Name = "textBoxTeamName";
            textBoxTeamName.Size = new Size(214, 23);
            textBoxTeamName.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCreate.BackColor = Color.LightGreen;
            buttonCreate.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = SystemColors.ControlText;
            buttonCreate.Location = new Point(114, 256);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(172, 56);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(119, 169);
            button1.Name = "button1";
            button1.Size = new Size(161, 42);
            button1.TabIndex = 21;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TeamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 368);
            Controls.Add(button1);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxTeamName);
            Controls.Add(label2);
            Controls.Add(labelName);
            Name = "TeamsForm";
            Text = "TeamsForm";
            Load += TeamsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label2;
        private TextBox textBoxTeamName;
        private Button buttonCreate;
        private Button button1;
    }
}