namespace FootballLeague
{
    partial class RefereesForm
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
            textBoxName = new TextBox();
            buttonMenu = new Button();
            buttonAction = new Button();
            label1 = new Label();
            comboBoxPosition = new ComboBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(0, 21);
            labelName.Name = "labelName";
            labelName.Size = new Size(346, 33);
            labelName.TabIndex = 11;
            labelName.Text = "REFEREES";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 95);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(99, 95);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(189, 23);
            textBoxName.TabIndex = 13;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = SystemColors.ButtonHighlight;
            buttonMenu.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenu.Location = new Point(99, 241);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(161, 42);
            buttonMenu.TabIndex = 22;
            buttonMenu.Text = "Menu";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // buttonAction
            // 
            buttonAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAction.BackColor = Color.LightGreen;
            buttonAction.Font = new Font("Microsoft Sans Serif", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAction.ForeColor = SystemColors.ControlText;
            buttonAction.Location = new Point(70, 306);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(207, 56);
            buttonAction.TabIndex = 23;
            buttonAction.Text = "Create";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 168);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 24;
            label1.Text = "Position:";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Center Referee", "Assisstant Referee", "Fourth Official", "VAR Official", "AVAR Official" });
            comboBoxPosition.Location = new Point(99, 168);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(189, 23);
            comboBoxPosition.TabIndex = 25;
            // 
            // RefereesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 374);
            Controls.Add(comboBoxPosition);
            Controls.Add(label1);
            Controls.Add(buttonAction);
            Controls.Add(buttonMenu);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(labelName);
            Name = "RefereesForm";
            Text = "RefereesForm";
            Load += RefereesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label2;
        private TextBox textBoxName;
        private Button buttonMenu;
        private Button buttonAction;
        private Label label1;
        private ComboBox comboBoxPosition;
    }
}