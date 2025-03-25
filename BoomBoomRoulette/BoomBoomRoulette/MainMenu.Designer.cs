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
            SuspendLayout();
            // 
            // StartGameP1
            // 
            StartGameP1.Location = new Point(285, 225);
            StartGameP1.Name = "StartGameP1";
            StartGameP1.Size = new Size(112, 34);
            StartGameP1.TabIndex = 0;
            StartGameP1.Text = "button1";
            StartGameP1.UseVisualStyleBackColor = true;
            StartGameP1.Click += StartGameP1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartGameP1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button StartGameP1;
    }
}