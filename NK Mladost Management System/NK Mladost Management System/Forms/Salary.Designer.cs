namespace NK_Mladost_Management_System.Forms
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            pictureBox1 = new PictureBox();
            lblX = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txtPosition = new TextBox();
            btPrint = new Button();
            btnFetchData = new Button();
            btnView = new Button();
            btnHome = new Button();
            rtbSalarySlip = new RichTextBox();
            txtPlayedGames = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtFootballerId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.BorderStyle = BorderStyle.Fixed3D;
            lblX.Font = new Font("Wide Latin", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblX.ForeColor = Color.White;
            lblX.Location = new Point(847, 31);
            lblX.Name = "lblX";
            lblX.Size = new Size(38, 23);
            lblX.TabIndex = 26;
            lblX.Text = "X";
            lblX.Click += lblX_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 31);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 25;
            label1.Text = "Salary";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtPosition);
            panel1.Controls.Add(btPrint);
            panel1.Controls.Add(btnFetchData);
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(rtbSalarySlip);
            panel1.Controls.Add(txtPlayedGames);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtFootballerId);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 405);
            panel1.TabIndex = 28;
            // 
            // txtPosition
            // 
            txtPosition.Enabled = false;
            txtPosition.Location = new Point(35, 248);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(194, 27);
            txtPosition.TabIndex = 32;
            // 
            // btPrint
            // 
            btPrint.BackColor = Color.FromArgb(0, 0, 192);
            btPrint.FlatAppearance.BorderSize = 0;
            btPrint.FlatStyle = FlatStyle.Flat;
            btPrint.Font = new Font("Wide Latin", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btPrint.ForeColor = Color.White;
            btPrint.Location = new Point(572, 363);
            btPrint.Name = "btPrint";
            btPrint.Size = new Size(87, 29);
            btPrint.TabIndex = 31;
            btPrint.Text = "Print";
            btPrint.UseVisualStyleBackColor = false;
            btPrint.Click += btPrint_Click;
            // 
            // btnFetchData
            // 
            btnFetchData.BackColor = Color.FromArgb(0, 0, 192);
            btnFetchData.FlatAppearance.BorderSize = 0;
            btnFetchData.FlatStyle = FlatStyle.Flat;
            btnFetchData.Font = new Font("Wide Latin", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnFetchData.ForeColor = Color.White;
            btnFetchData.Location = new Point(249, 39);
            btnFetchData.Name = "btnFetchData";
            btnFetchData.Size = new Size(87, 45);
            btnFetchData.TabIndex = 30;
            btnFetchData.Text = "Fetch Data";
            btnFetchData.UseVisualStyleBackColor = false;
            btnFetchData.Click += btnFetchData_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(0, 0, 192);
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Wide Latin", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(142, 363);
            btnView.Name = "btnView";
            btnView.Size = new Size(87, 29);
            btnView.TabIndex = 29;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(0, 0, 192);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Wide Latin", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(35, 363);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(87, 29);
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // rtbSalarySlip
            // 
            rtbSalarySlip.BorderStyle = BorderStyle.None;
            rtbSalarySlip.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbSalarySlip.ForeColor = Color.DodgerBlue;
            rtbSalarySlip.Location = new Point(364, 31);
            rtbSalarySlip.Name = "rtbSalarySlip";
            rtbSalarySlip.Size = new Size(496, 311);
            rtbSalarySlip.TabIndex = 27;
            rtbSalarySlip.Text = "";
            // 
            // txtPlayedGames
            // 
            txtPlayedGames.Location = new Point(35, 315);
            txtPlayedGames.Name = "txtPlayedGames";
            txtPlayedGames.Size = new Size(194, 27);
            txtPlayedGames.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(35, 294);
            label5.Name = "label5";
            label5.Size = new Size(194, 18);
            label5.TabIndex = 23;
            label5.Text = "Played games";
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(35, 183);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(194, 27);
            txtLastName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(35, 121);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(194, 27);
            txtFirstName.TabIndex = 20;
            // 
            // txtFootballerId
            // 
            txtFootballerId.Location = new Point(35, 57);
            txtFootballerId.Name = "txtFootballerId";
            txtFootballerId.Size = new Size(194, 27);
            txtFootballerId.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(35, 227);
            label6.Name = "label6";
            label6.Size = new Size(125, 18);
            label6.TabIndex = 18;
            label6.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(35, 162);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 17;
            label4.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(35, 100);
            label3.Name = "label3";
            label3.Size = new Size(157, 18);
            label3.TabIndex = 16;
            label3.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(35, 36);
            label2.Name = "label2";
            label2.Size = new Size(194, 18);
            label2.TabIndex = 15;
            label2.Text = "Footballer ID";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(895, 513);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblX);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            Load += Salary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblX;
        private Label label1;
        private Panel panel1;
        private TextBox txtPlayedGames;
        private Label label5;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtFootballerId;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnView;
        private Button btnHome;
        private RichTextBox rtbSalarySlip;
        private Button btPrint;
        private Button btnFetchData;
        private TextBox txtPosition;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}