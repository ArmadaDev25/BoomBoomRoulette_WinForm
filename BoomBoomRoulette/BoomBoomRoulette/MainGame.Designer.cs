namespace BoomBoomRoulette
{
    partial class MainGame
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
            EventsBox = new ListBox();
            StartRoundBtn = new Button();
            hInput = new TextBox();
            rInput = new TextBox();
            GSTLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            AimPlayerBtn = new Button();
            AimAiBtn = new Button();
            label3 = new Label();
            fireBtn = new Button();
            lblPName = new Label();
            lblPlayerNameOutput = new Label();
            lblPlayerHP = new Label();
            lblcomputerHP = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // EventsBox
            // 
            EventsBox.FormattingEnabled = true;
            EventsBox.ItemHeight = 25;
            EventsBox.Location = new Point(791, 162);
            EventsBox.Name = "EventsBox";
            EventsBox.Size = new Size(462, 454);
            EventsBox.TabIndex = 0;
            // 
            // StartRoundBtn
            // 
            StartRoundBtn.Location = new Point(12, 112);
            StartRoundBtn.Name = "StartRoundBtn";
            StartRoundBtn.Size = new Size(148, 34);
            StartRoundBtn.TabIndex = 1;
            StartRoundBtn.Text = "Start Game";
            StartRoundBtn.UseVisualStyleBackColor = true;
            StartRoundBtn.Click += StartRoundBtn_Click;
            // 
            // hInput
            // 
            hInput.Location = new Point(409, 59);
            hInput.Name = "hInput";
            hInput.Size = new Size(150, 31);
            hInput.TabIndex = 2;
            // 
            // rInput
            // 
            rInput.Location = new Point(103, 59);
            rInput.Name = "rInput";
            rInput.Size = new Size(150, 31);
            rInput.TabIndex = 3;
            // 
            // GSTLabel
            // 
            GSTLabel.AutoSize = true;
            GSTLabel.Location = new Point(12, 22);
            GSTLabel.Name = "GSTLabel";
            GSTLabel.Size = new Size(127, 25);
            GSTLabel.TabIndex = 4;
            GSTLabel.Text = "Game Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 62);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 5;
            label1.Text = "Health Per Player";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 6;
            label2.Text = "Rounds";
            // 
            // AimPlayerBtn
            // 
            AimPlayerBtn.Location = new Point(12, 225);
            AimPlayerBtn.Name = "AimPlayerBtn";
            AimPlayerBtn.Size = new Size(112, 34);
            AimPlayerBtn.TabIndex = 8;
            AimPlayerBtn.Text = "Self";
            AimPlayerBtn.UseVisualStyleBackColor = true;
            AimPlayerBtn.Click += AimPlayerBtn_Click;
            // 
            // AimAiBtn
            // 
            AimAiBtn.Location = new Point(141, 225);
            AimAiBtn.Name = "AimAiBtn";
            AimAiBtn.Size = new Size(112, 34);
            AimAiBtn.TabIndex = 9;
            AimAiBtn.Text = "Opponent";
            AimAiBtn.UseVisualStyleBackColor = true;
            AimAiBtn.Click += AimAiBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 10;
            label3.Text = "Choose Target";
            // 
            // fireBtn
            // 
            fireBtn.Location = new Point(12, 284);
            fireBtn.Name = "fireBtn";
            fireBtn.Size = new Size(241, 70);
            fireBtn.TabIndex = 11;
            fireBtn.Text = "FIRE!!!";
            fireBtn.UseVisualStyleBackColor = true;
            fireBtn.Click += fireBtn_Click;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(791, 32);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(115, 25);
            lblPName.TabIndex = 12;
            lblPName.Text = "Player Name:";
            // 
            // lblPlayerNameOutput
            // 
            lblPlayerNameOutput.AutoSize = true;
            lblPlayerNameOutput.Location = new Point(912, 32);
            lblPlayerNameOutput.Name = "lblPlayerNameOutput";
            lblPlayerNameOutput.Size = new Size(59, 25);
            lblPlayerNameOutput.TabIndex = 13;
            lblPlayerNameOutput.Text = "label4";
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.Location = new Point(912, 65);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(59, 25);
            lblPlayerHP.TabIndex = 14;
            lblPlayerHP.Text = "label4";
            // 
            // lblcomputerHP
            // 
            lblcomputerHP.AutoSize = true;
            lblcomputerHP.Location = new Point(912, 90);
            lblcomputerHP.Name = "lblcomputerHP";
            lblcomputerHP.Size = new Size(59, 25);
            lblcomputerHP.TabIndex = 15;
            lblcomputerHP.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(791, 90);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 16;
            label6.Text = "Computer HP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(791, 65);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 17;
            label7.Text = "Player HP";
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 635);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblcomputerHP);
            Controls.Add(lblPlayerHP);
            Controls.Add(lblPlayerNameOutput);
            Controls.Add(lblPName);
            Controls.Add(fireBtn);
            Controls.Add(label3);
            Controls.Add(AimAiBtn);
            Controls.Add(AimPlayerBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GSTLabel);
            Controls.Add(rInput);
            Controls.Add(hInput);
            Controls.Add(StartRoundBtn);
            Controls.Add(EventsBox);
            Name = "MainGame";
            Text = "Form1";
            Load += MainGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EventsBox;
        private Button StartRoundBtn;
        private TextBox hInput;
        private TextBox rInput;
        private Label GSTLabel;
        private Label label1;
        private Label label2;
        private Button AimPlayerBtn;
        private Button AimAiBtn;
        private Label label3;
        private Button fireBtn;
        private Label lblPName;
        private Label lblPlayerNameOutput;
        private Label lblPlayerHP;
        private Label lblcomputerHP;
        private Label label6;
        private Label label7;
    }
}
