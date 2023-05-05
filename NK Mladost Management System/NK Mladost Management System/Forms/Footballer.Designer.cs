namespace NK_Mladost_Management_System.Forms
{
    partial class Footballer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Footballer));
            panel1 = new Panel();
            dgvFootballer = new Guna.UI2.WinForms.Guna2DataGridView();
            btnHome = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtNumber = new TextBox();
            cmbPosition = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtFootballerId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblX = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFootballer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvFootballer);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(cmbPosition);
            panel1.Controls.Add(dtpDateOfBirth);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtFootballerId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1446, 391);
            panel1.TabIndex = 0;
            // 
            // dgvFootballer
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvFootballer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFootballer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFootballer.ColumnHeadersHeight = 25;
            dgvFootballer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFootballer.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFootballer.GridColor = Color.FromArgb(231, 229, 255);
            dgvFootballer.Location = new Point(626, 38);
            dgvFootballer.Name = "dgvFootballer";
            dgvFootballer.RowHeadersVisible = false;
            dgvFootballer.RowHeadersWidth = 51;
            dgvFootballer.RowTemplate.Height = 29;
            dgvFootballer.Size = new Size(766, 336);
            dgvFootballer.TabIndex = 20;
            dgvFootballer.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvFootballer.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvFootballer.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvFootballer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvFootballer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvFootballer.ThemeStyle.BackColor = Color.White;
            dgvFootballer.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvFootballer.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 0, 192);
            dgvFootballer.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFootballer.ThemeStyle.HeaderStyle.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvFootballer.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvFootballer.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvFootballer.ThemeStyle.HeaderStyle.Height = 25;
            dgvFootballer.ThemeStyle.ReadOnly = false;
            dgvFootballer.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvFootballer.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFootballer.ThemeStyle.RowsStyle.Font = new Font("Wide Latin", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgvFootballer.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvFootballer.ThemeStyle.RowsStyle.Height = 29;
            dgvFootballer.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 0, 192);
            dgvFootballer.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvFootballer.CellContentClick += dgvFootballer_CellContentClick;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(0, 0, 192);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(437, 329);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(113, 45);
            btnHome.TabIndex = 19;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 0, 192);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(290, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 45);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 0, 192);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(171, 329);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 45);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 0, 192);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(52, 329);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 45);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(287, 266);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(263, 27);
            txtNumber.TabIndex = 15;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "Goalkeeper", "Defender", "Midfielder", "Winger", "Striker" });
            cmbPosition.Location = new Point(287, 219);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(263, 28);
            cmbPosition.TabIndex = 14;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(287, 174);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(263, 27);
            dtpDateOfBirth.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(287, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(263, 27);
            txtLastName.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(287, 80);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(263, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtFootballerId
            // 
            txtFootballerId.Location = new Point(287, 38);
            txtFootballerId.Name = "txtFootballerId";
            txtFootballerId.Size = new Size(263, 27);
            txtFootballerId.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Wide Latin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(52, 275);
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
            label6.Location = new Point(52, 229);
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
            label5.Location = new Point(52, 183);
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
            label4.Location = new Point(52, 135);
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
            label3.Location = new Point(52, 89);
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
            label2.Location = new Point(52, 43);
            label2.Name = "label2";
            label2.Size = new Size(194, 18);
            label2.TabIndex = 4;
            label2.Text = "Footballer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 31);
            label1.Name = "label1";
            label1.Size = new Size(297, 21);
            label1.TabIndex = 3;
            label1.Text = "Manage Footballer";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.BorderStyle = BorderStyle.Fixed3D;
            lblX.Font = new Font("Wide Latin", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblX.ForeColor = Color.White;
            lblX.Location = new Point(1356, 31);
            lblX.Name = "lblX";
            lblX.Size = new Size(38, 23);
            lblX.TabIndex = 4;
            lblX.Text = "X";
            lblX.Click += lblX_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Footballer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(1444, 497);
            Controls.Add(pictureBox1);
            Controls.Add(lblX);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Footballer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Footballer";
            Load += Footballer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFootballer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtFootballerId;
        private Label label7;
        private Label label6;
        private TextBox txtNumber;
        private ComboBox cmbPosition;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFootballer;
        private Button btnHome;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label lblX;
        private PictureBox pictureBox1;
    }
}