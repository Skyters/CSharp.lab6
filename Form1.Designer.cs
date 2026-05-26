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
            tbGraviton = new TrackBar();
            tbAntiGraviton = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            lblAntiGraviton = new Label();
            lblGraviton = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAntiGraviton).BeginInit();
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
            picDisplay.MouseWheel += picDisplay_MouseWheel;
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
            // tbGraviton
            // 
            tbGraviton.Location = new Point(462, 393);
            tbGraviton.Maximum = 100;
            tbGraviton.Name = "tbGraviton";
            tbGraviton.Size = new Size(119, 45);
            tbGraviton.TabIndex = 7;
            tbGraviton.Scroll += tbGraviton_Scroll;
            // 
            // tbAntiGraviton
            // 
            tbAntiGraviton.Location = new Point(310, 393);
            tbAntiGraviton.Maximum = 100;
            tbAntiGraviton.Name = "tbAntiGraviton";
            tbAntiGraviton.Size = new Size(119, 45);
            tbAntiGraviton.TabIndex = 8;
            tbAntiGraviton.Scroll += tbAntiGraviton_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 375);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "Антигравитон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 375);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Гравитон";
            // 
            // lblAntiGraviton
            // 
            lblAntiGraviton.AutoSize = true;
            lblAntiGraviton.Location = new Point(435, 393);
            lblAntiGraviton.Name = "lblAntiGraviton";
            lblAntiGraviton.Size = new Size(18, 15);
            lblAntiGraviton.TabIndex = 11;
            lblAntiGraviton.Text = "0°";
            // 
            // lblGraviton
            // 
            lblGraviton.AutoSize = true;
            lblGraviton.Location = new Point(578, 393);
            lblGraviton.Name = "lblGraviton";
            lblGraviton.Size = new Size(18, 15);
            lblGraviton.TabIndex = 12;
            lblGraviton.Text = "0°";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(lblGraviton);
            Controls.Add(lblAntiGraviton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbAntiGraviton);
            Controls.Add(tbGraviton);
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
            ((System.ComponentModel.ISupportInitialize)tbGraviton).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAntiGraviton).EndInit();
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
        private TrackBar tbGraviton;
        private TrackBar tbAntiGraviton;
        private Label label3;
        private Label label4;
        private Label lblAntiGraviton;
        private Label lblGraviton;
    }
}
