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
            btnradio1 = new RadioButton();
            btnradio2 = new RadioButton();
            tbSpeed = new TrackBar();
            label5 = new Label();
            lblSpeed = new Label();
            tbCount = new TrackBar();
            label6 = new Label();
            tbLife = new TrackBar();
            label7 = new Label();
            lblCount = new Label();
            tbColorPoint = new TrackBar();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGraviton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAntiGraviton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbLife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbColorPoint).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(490, 329);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.MouseClick += picDisplay_MouseClick;
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
            tbGraviton.Location = new Point(510, 130);
            tbGraviton.Maximum = 100;
            tbGraviton.Name = "tbGraviton";
            tbGraviton.Size = new Size(119, 45);
            tbGraviton.TabIndex = 7;
            tbGraviton.Scroll += tbGraviton_Scroll;
            // 
            // tbAntiGraviton
            // 
            tbAntiGraviton.Location = new Point(510, 79);
            tbAntiGraviton.Maximum = 100;
            tbAntiGraviton.Name = "tbAntiGraviton";
            tbAntiGraviton.Size = new Size(119, 45);
            tbAntiGraviton.TabIndex = 8;
            tbAntiGraviton.Scroll += tbAntiGraviton_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 61);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 9;
            label3.Text = "Антигравитон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 112);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Гравитон";
            // 
            // lblAntiGraviton
            // 
            lblAntiGraviton.AutoSize = true;
            lblAntiGraviton.Location = new Point(635, 79);
            lblAntiGraviton.Name = "lblAntiGraviton";
            lblAntiGraviton.Size = new Size(18, 15);
            lblAntiGraviton.TabIndex = 11;
            lblAntiGraviton.Text = "0°";
            // 
            // lblGraviton
            // 
            lblGraviton.AutoSize = true;
            lblGraviton.Location = new Point(626, 130);
            lblGraviton.Name = "lblGraviton";
            lblGraviton.Size = new Size(18, 15);
            lblGraviton.TabIndex = 12;
            lblGraviton.Text = "0°";
            // 
            // btnradio1
            // 
            btnradio1.AutoSize = true;
            btnradio1.Location = new Point(508, 12);
            btnradio1.Name = "btnradio1";
            btnradio1.Size = new Size(149, 19);
            btnradio1.TabIndex = 13;
            btnradio1.TabStop = true;
            btnradio1.Text = "Включить гравитацию";
            btnradio1.UseVisualStyleBackColor = true;
            btnradio1.CheckedChanged += btnradio1_CheckedChanged_1;
            // 
            // btnradio2
            // 
            btnradio2.AutoSize = true;
            btnradio2.Location = new Point(508, 37);
            btnradio2.Name = "btnradio2";
            btnradio2.Size = new Size(156, 19);
            btnradio2.TabIndex = 14;
            btnradio2.TabStop = true;
            btnradio2.Text = "Отключить гравитацию";
            btnradio2.UseVisualStyleBackColor = true;
            btnradio2.CheckedChanged += btnradio2_CheckedChanged;
            // 
            // tbSpeed
            // 
            tbSpeed.Location = new Point(310, 393);
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(119, 45);
            tbSpeed.TabIndex = 15;
            tbSpeed.Scroll += tbSpeed_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 375);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 16;
            label5.Text = "Скорость";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(435, 393);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(13, 15);
            lblSpeed.TabIndex = 17;
            lblSpeed.Text = "0";
            // 
            // tbCount
            // 
            tbCount.Location = new Point(454, 393);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(119, 45);
            tbCount.TabIndex = 18;
            tbCount.Scroll += tbCount_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 375);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 20;
            label6.Text = "Кол-во частиц";
            // 
            // tbLife
            // 
            tbLife.Location = new Point(510, 198);
            tbLife.Maximum = 100;
            tbLife.Name = "tbLife";
            tbLife.Size = new Size(119, 45);
            tbLife.TabIndex = 21;
            tbLife.Scroll += tbLife_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(510, 178);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 22;
            label7.Text = "Жизнь частиц";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(510, 326);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(125, 15);
            lblCount.TabIndex = 23;
            lblCount.Text = "Количество частиц: 0";
            // 
            // tbColorPoint
            // 
            tbColorPoint.Location = new Point(508, 278);
            tbColorPoint.Maximum = 100;
            tbColorPoint.Name = "tbColorPoint";
            tbColorPoint.Size = new Size(119, 45);
            tbColorPoint.TabIndex = 24;
            tbColorPoint.Scroll += tbColorPoint_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 245);
            label8.Name = "label8";
            label8.Size = new Size(141, 30);
            label8.TabIndex = 25;
            label8.Text = "Точки перекрашивания \r\nчастиц";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(label8);
            Controls.Add(tbColorPoint);
            Controls.Add(lblCount);
            Controls.Add(label7);
            Controls.Add(tbLife);
            Controls.Add(label6);
            Controls.Add(tbCount);
            Controls.Add(lblSpeed);
            Controls.Add(label5);
            Controls.Add(tbSpeed);
            Controls.Add(btnradio2);
            Controls.Add(btnradio1);
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
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbLife).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbColorPoint).EndInit();
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
        private RadioButton btnradio1;
        private RadioButton btnradio2;
        private TrackBar tbSpeed;
        private Label label5;
        private Label lblSpeed;
        private TrackBar tbCount;
        private Label label6;
        private TrackBar tbLife;
        private Label label7;
        private Label lblCount;
        private TrackBar tbColorPoint;
        private Label label8;
    }
}
