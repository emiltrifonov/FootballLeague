namespace FootballLeague
{
    partial class CreatePlayersForm
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Montserrat", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(59, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(278, 35);
            labelName.TabIndex = 0;
            labelName.Text = "CREATE - PLAYER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 2;
            // 
            // CreatePlayersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(labelName);
            Name = "CreatePlayersForm";
            Text = "CreatePlayersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label1;
        private TextBox textBox1;
    }
}