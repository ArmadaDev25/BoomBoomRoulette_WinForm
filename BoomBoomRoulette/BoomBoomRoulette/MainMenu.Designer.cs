namespace BoomBoomRoulette
{
    partial class MainMenu
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
            StartGameP1 = new Button();
            PlayerNameEntry = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // StartGameP1
            // 
            StartGameP1.Location = new Point(303, 266);
            StartGameP1.Name = "StartGameP1";
            StartGameP1.Size = new Size(185, 34);
            StartGameP1.TabIndex = 0;
            StartGameP1.Text = "Start Game P1";
            StartGameP1.UseVisualStyleBackColor = true;
            StartGameP1.Click += StartGameP1_Click;
            // 
            // PlayerNameEntry
            // 
            PlayerNameEntry.Location = new Point(305, 221);
            PlayerNameEntry.Name = "PlayerNameEntry";
            PlayerNameEntry.Size = new Size(183, 31);
            PlayerNameEntry.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 193);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter Player Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 25);
            label2.Name = "label2";
            label2.Size = new Size(583, 74);
            label2.TabIndex = 3;
            label2.Text = "Boom Boom Roulette";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PlayerNameEntry);
            Controls.Add(StartGameP1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartGameP1;
        private TextBox PlayerNameEntry;
        private Label label1;
        private Label label2;
    }
}