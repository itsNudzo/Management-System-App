using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NK_Mladost_Management_System.Forms
{
    public partial class ViewFootballer : Form
    {
        public ViewFootballer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\MSSQLSERVER16;Initial Catalog=MyFootballerDb;Integrated Security=True");

        private void FetchFootballerData()
        {
            con.Open();
            string query = "select * from FootballerTbl where Id='" + txtIdDetails.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                lblFootballerId.Text = row["Id"].ToString();
                lblFirstName.Text = row["FirstName"].ToString();
                lblLastName.Text = row["LastName"].ToString();
                lblDate.Text = row["DateOfBirth"].ToString();
                lblPosition.Text = row["Position"].ToString();
                lblNumber.Text = row["ShirtNumber"].ToString();
                lblFootballerId.Visible = true;
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblDate.Visible = true;
                lblPosition.Visible = true;
                lblNumber.Visible = true;
            }
            con.Close();
        }

        private void ViewFootballer_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FetchFootballerData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====FOOTBALLER'S SUMMARY=====", new Font("Latin", 20, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 50));
            e.Graphics.DrawString("Footballer's ID: " + lblFootballerId.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 130));
            e.Graphics.DrawString("First name: " + lblFirstName.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 180));
            e.Graphics.DrawString("Last name: " + lblLastName.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 230));
            e.Graphics.DrawString("Date of birth: " + lblDate.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 280));
            e.Graphics.DrawString("Position: " + lblPosition.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 330));
            e.Graphics.DrawString("Shirt number: " + lblNumber.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 380));
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
