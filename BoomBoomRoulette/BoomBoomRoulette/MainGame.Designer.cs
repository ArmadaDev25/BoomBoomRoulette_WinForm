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
            GSTLabel = new Label();
            label1 = new Label();
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
            label2 = new Label();
            CurrentTargetlbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // EventsBox
            // 
            EventsBox.FormattingEnabled = true;
            EventsBox.ItemHeight = 25;
            EventsBox.Location = new Point(787, 116);
            EventsBox.Name = "EventsBox";
            EventsBox.Size = new Size(462, 454);
            EventsBox.TabIndex = 0;
            // 
            // StartRoundBtn
            // 
            StartRoundBtn.Location = new Point(49, 162);
            StartRoundBtn.Name = "StartRoundBtn";
            StartRoundBtn.Size = new Size(148, 34);
            StartRoundBtn.TabIndex = 1;
            StartRoundBtn.Text = "Start Game";
            StartRoundBtn.UseVisualStyleBackColor = true;
            StartRoundBtn.Click += StartRoundBtn_Click;
            // 
            // hInput
            // 
            hInput.Location = new Point(199, 112);
            hInput.Name = "hInput";
            hInput.Size = new Size(150, 31);
            hInput.TabIndex = 2;
            // 
            // GSTLabel
            // 
            GSTLabel.AutoSize = true;
            GSTLabel.Location = new Point(49, 72);
            GSTLabel.Name = "GSTLabel";
            GSTLabel.Size = new Size(127, 25);
            GSTLabel.TabIndex = 4;
            GSTLabel.Text = "Game Settings";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 115);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 5;
            label1.Text = "Health Per Player";
            // 
            // AimPlayerBtn
            // 
            AimPlayerBtn.Location = new Point(49, 318);
            AimPlayerBtn.Name = "AimPlayerBtn";
            AimPlayerBtn.Size = new Size(112, 34);
            AimPlayerBtn.TabIndex = 8;
            AimPlayerBtn.Text = "Self";
            AimPlayerBtn.UseVisualStyleBackColor = true;
            AimPlayerBtn.Click += AimPlayerBtn_Click;
            // 
            // AimAiBtn
            // 
            AimAiBtn.Location = new Point(178, 318);
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
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 232);
            label3.Name = "label3";
            label3.Size = new Size(170, 32);
            label3.TabIndex = 10;
            label3.Text = "Choose Target";
            // 
            // fireBtn
            // 
            fireBtn.Location = new Point(49, 377);
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
            lblPName.Location = new Point(464, 70);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(115, 25);
            lblPName.TabIndex = 12;
            lblPName.Text = "Player Name:";
            // 
            // lblPlayerNameOutput
            // 
            lblPlayerNameOutput.AutoSize = true;
            lblPlayerNameOutput.Location = new Point(585, 70);
            lblPlayerNameOutput.Name = "lblPlayerNameOutput";
            lblPlayerNameOutput.Size = new Size(59, 25);
            lblPlayerNameOutput.TabIndex = 13;
            lblPlayerNameOutput.Text = "label4";
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.Location = new Point(585, 103);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(59, 25);
            lblPlayerHP.TabIndex = 14;
            lblPlayerHP.Text = "label4";
            // 
            // lblcomputerHP
            // 
            lblcomputerHP.AutoSize = true;
            lblcomputerHP.Location = new Point(585, 128);
            lblcomputerHP.Name = "lblcomputerHP";
            lblcomputerHP.Size = new Size(59, 25);
            lblcomputerHP.TabIndex = 15;
            lblcomputerHP.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 128);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 16;
            label6.Text = "Computer HP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 103);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 17;
            label7.Text = "Player HP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 275);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 18;
            label2.Text = "Current Target";
            // 
            // CurrentTargetlbl
            // 
            CurrentTargetlbl.AutoSize = true;
            CurrentTargetlbl.Location = new Point(178, 275);
            CurrentTargetlbl.Name = "CurrentTargetlbl";
            CurrentTargetlbl.Size = new Size(59, 25);
            CurrentTargetlbl.TabIndex = 19;
            CurrentTargetlbl.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FoamDartGun;
            pictureBox1.Location = new Point(-142, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1529, 727);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Location = new Point(26, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(352, 427);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(436, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(261, 122);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 674);
            label4.Name = "label4";
            label4.Size = new Size(887, 21);
            label4.TabIndex = 23;
            label4.Text = "Image Source: https://www.reddit.com/r/Nerf/comments/msc56u/rekt_jury_short_dart_co2_revolver_havent_seen/?rdt=43550";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(787, 72);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 24;
            label5.Text = "Events";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Location = new Point(770, 50);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(498, 543);
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 713);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CurrentTargetlbl);
            Controls.Add(label2);
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
            Controls.Add(label1);
            Controls.Add(GSTLabel);
            Controls.Add(hInput);
            Controls.Add(StartRoundBtn);
            Controls.Add(EventsBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Name = "MainGame";
            Text = "Boom Boom Roulette";
            Load += MainGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EventsBox;
        private Button StartRoundBtn;
        private TextBox hInput;
        private Label GSTLabel;
        private Label label1;
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
        private Label label2;
        private Label CurrentTargetlbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
    }
}
