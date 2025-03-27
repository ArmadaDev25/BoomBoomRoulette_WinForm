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
            aimPlayerBtn = new Button();
            SuspendLayout();
            // 
            // EventsBox
            // 
            EventsBox.FormattingEnabled = true;
            EventsBox.ItemHeight = 25;
            EventsBox.Location = new Point(398, 59);
            EventsBox.Name = "EventsBox";
            EventsBox.Size = new Size(351, 379);
            EventsBox.TabIndex = 0;
            // 
            // aimPlayerBtn
            // 
            aimPlayerBtn.Location = new Point(12, 130);
            aimPlayerBtn.Name = "aimPlayerBtn";
            aimPlayerBtn.Size = new Size(112, 34);
            aimPlayerBtn.TabIndex = 1;
            aimPlayerBtn.Text = "button1";
            aimPlayerBtn.UseVisualStyleBackColor = true;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aimPlayerBtn);
            Controls.Add(EventsBox);
            Name = "MainGame";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox EventsBox;
        private Button aimPlayerBtn;
    }
}
