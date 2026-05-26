namespace CSharp.lab6
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbDirection = new TrackBar();
            label1 = new Label();
            lblDirection = new Label();
            tbSpread = new TrackBar();
            label2 = new Label();
            lblSpread = new Label();
            tbGraviton1 = new TrackBar();
            tbGraviton2 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton2).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(490, 329);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(12, 393);
            tbDirection.Maximum = 360;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(119, 45);
            tbDirection.TabIndex = 1;
            tbDirection.Scroll += tbDirection_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 375);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Направление";
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Location = new Point(137, 393);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(18, 15);
            lblDirection.TabIndex = 3;
            lblDirection.Text = "0°";
            // 
            // tbSpread
            // 
            tbSpread.Location = new Point(161, 393);
            tbSpread.Maximum = 360;
            tbSpread.Name = "tbSpread";
            tbSpread.Size = new Size(119, 45);
            tbSpread.TabIndex = 4;
            tbSpread.Scroll += tbSpread_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 375);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Разброс";
            // 
            // lblSpread
            // 
            lblSpread.AutoSize = true;
            lblSpread.Location = new Point(286, 393);
            lblSpread.Name = "lblSpread";
            lblSpread.Size = new Size(18, 15);
            lblSpread.TabIndex = 6;
            lblSpread.Text = "0°";
            // 
            // tbGraviton1
            // 
            tbGraviton1.Location = new Point(310, 393);
            tbGraviton1.Maximum = 360;
            tbGraviton1.Name = "tbGraviton1";
            tbGraviton1.Size = new Size(119, 45);
            tbGraviton1.TabIndex = 7;
            tbGraviton1.Scroll += tbGraviton1_Scroll;
            // 
            // tbGraviton2
            // 
            tbGraviton2.Location = new Point(435, 393);
            tbGraviton2.Maximum = 360;
            tbGraviton2.Name = "tbGraviton2";
            tbGraviton2.Size = new Size(119, 45);
            tbGraviton2.TabIndex = 8;
            tbGraviton2.Scroll += tbGraviton2_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(tbGraviton2);
            Controls.Add(tbGraviton1);
            Controls.Add(lblSpread);
            Controls.Add(label2);
            Controls.Add(tbSpread);
            Controls.Add(lblDirection);
            Controls.Add(label1);
            Controls.Add(tbDirection);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label label1;
        private Label lblDirection;
        private TrackBar tbSpread;
        private Label label2;
        private Label lblSpread;
        private TrackBar tbGraviton1;
        private TrackBar tbGraviton2;
    }
}
