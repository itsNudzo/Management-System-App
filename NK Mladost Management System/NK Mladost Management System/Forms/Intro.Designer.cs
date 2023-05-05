namespace NK_Mladost_Management_System
{
    partial class Intro
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            MyProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            MyProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MyProgress
            // 
            MyProgress.BackColor = Color.Transparent;
            MyProgress.Controls.Add(pictureBox1);
            MyProgress.FillColor = Color.FromArgb(200, 213, 218, 223);
            MyProgress.FillThickness = 13;
            MyProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyProgress.ForeColor = Color.White;
            MyProgress.Location = new Point(173, 66);
            MyProgress.Minimum = 0;
            MyProgress.Name = "MyProgress";
            MyProgress.ProgressColor = Color.FromArgb(0, 0, 192);
            MyProgress.ProgressColor2 = Color.FromArgb(0, 0, 192);
            MyProgress.ProgressThickness = 13;
            MyProgress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            MyProgress.Size = new Size(187, 187);
            MyProgress.TabIndex = 0;
            MyProgress.Text = "guna2CircleProgressBar1";
            MyProgress.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(488, 35);
            label1.TabIndex = 1;
            label1.Text = "NK MLADOST MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wide Latin", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(103, 266);
            label2.Name = "label2";
            label2.Size = new Size(336, 16);
            label2.TabIndex = 2;
            label2.Text = "DeveloppedByNudzejmDelan";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 300);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MyProgress);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Intro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Intro_Load;
            MyProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar MyProgress;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}