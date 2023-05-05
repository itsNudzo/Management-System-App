namespace NK_Mladost_Management_System.Forms
{
    partial class ViewFootballer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFootballer));
            pictureBox1 = new PictureBox();
            lblX = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblFootballerId = new Label();
            label8 = new Label();
            btnHome = new Button();
            btnPrint = new Button();
            btnRefresh = new Button();
            lblNumber = new Label();
            lblPosition = new Label();
            lblDate = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtIdDetails = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
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
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.BorderStyle = BorderStyle.Fixed3D;
            lblX.Font = new Font("Wide Latin", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblX.ForeColor = Color.White;
            lblX.Location = new Point(668, 31);
            lblX.Name = "lblX";
            lblX.Size = new Size(38, 23);
            lblX.TabIndex = 23;
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
            label1.Size = new Size(309, 21);
            label1.TabIndex = 22;
            label1.Text = "Footballer's Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblFootballerId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblPosition);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(txtIdDetails);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 391);
            panel1.TabIndex = 25;
            // 
            // lblFootballerId
            // 
            lblFootballerId.AutoSize = true;
            lblFootballerId.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFootballerId.ForeColor = Color.DodgerBlue;
            lblFootballerId.Location = new Point(345, 63);
            lblFootballerId.Name = "lblFootballerId";
            lblFootballerId.Size = new Size(194, 18);
            lblFootballerId.TabIndex = 29;
            lblFootballerId.Text = "Footballer ID";
            lblFootballerId.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 0, 192);
            label8.Location = new Point(130, 63);
            label8.Name = "label8";
            label8.Size = new Size(194, 18);
            label8.TabIndex = 28;
            label8.Text = "Footballer ID";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(0, 0, 192);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(357, 330);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(113, 45);
            btnHome.TabIndex = 27;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(0, 0, 192);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(238, 330);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(113, 45);
            btnPrint.TabIndex = 26;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 0, 192);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Wide Latin", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(433, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(113, 29);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber.ForeColor = Color.DodgerBlue;
            lblNumber.Location = new Point(345, 292);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(191, 18);
            lblNumber.TabIndex = 24;
            lblNumber.Text = "Shirt number";
            lblNumber.Visible = false;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.DodgerBlue;
            lblPosition.Location = new Point(345, 246);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(125, 18);
            lblPosition.TabIndex = 23;
            lblPosition.Text = "Position";
            lblPosition.Visible = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = Color.DodgerBlue;
            lblDate.Location = new Point(345, 200);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(179, 18);
            lblDate.TabIndex = 22;
            lblDate.Text = "Date of birth";
            lblDate.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.DodgerBlue;
            lblLastName.Location = new Point(345, 152);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(149, 18);
            lblLastName.TabIndex = 21;
            lblLastName.Text = "Last name";
            lblLastName.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.DodgerBlue;
            lblFirstName.Location = new Point(345, 106);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(157, 18);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "First name";
            lblFirstName.Visible = false;
            // 
            // txtIdDetails
            // 
            txtIdDetails.Location = new Point(287, 16);
            txtIdDetails.Name = "txtIdDetails";
            txtIdDetails.Size = new Size(140, 27);
            txtIdDetails.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(127, 292);
            label7.Name = "label7";
            label7.Size = new Size(191, 18);
            label7.TabIndex = 9;
            label7.Text = "Shirt number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(127, 246);
            label6.Name = "label6";
            label6.Size = new Size(125, 18);
            label6.TabIndex = 8;
            label6.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(127, 200);
            label5.Name = "label5";
            label5.Size = new Size(179, 18);
            label5.TabIndex = 7;
            label5.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(127, 152);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 6;
            label4.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(127, 106);
            label3.Name = "label3";
            label3.Size = new Size(157, 18);
            label3.TabIndex = 5;
            label3.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(90, 21);
            label2.Name = "label2";
            label2.Size = new Size(194, 18);
            label2.TabIndex = 4;
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
            // ViewFootballer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(716, 497);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblX);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFootballer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFootballer";
            Load += ViewFootballer_Load;
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvFootballer;
        private Button btnHome;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtNumber;
        private ComboBox cmbPosition;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtIdDetails;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblNumber;
        private Label lblPosition;
        private Label lblDate;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnPrint;
        private Button btnRefresh;
        private Label lblFootballerId;
        private Label label8;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}