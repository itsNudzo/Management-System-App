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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\MSSQLSERVER16;Initial Catalog=MyFootballerDb;Integrated Security=True");

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FetchFootballerData()
        {
            if (txtFootballerId.Text == "")
            {
                MessageBox.Show("Enter footballer's ID.");
            }
            else
            {
                con.Open();
                string query = "select * from FootballerTbl where Id='" + txtFootballerId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    txtFirstName.Text = row["FirstName"].ToString();
                    txtLastName.Text = row["LastName"].ToString();
                    txtPosition.Text = row["Position"].ToString();
                }
                con.Close();
            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            FetchFootballerData();
        }

        int Dailybase, Total;
        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text == "")
            {
                MessageBox.Show("Select footballer's position.");
            }
            else if (txtPlayedGames.Text == "" || int.Parse(txtPlayedGames.Text) > 20)
            {
                MessageBox.Show("Please enter valid number of games.");
            }
            else
            {
                if (txtPosition.Text == "Goalkeeper")
                {
                    Dailybase = 300;
                }
                else if (txtPosition.Text == "Defender")
                {
                    Dailybase = 250;
                }
                else if (txtPosition.Text == "Midfielder")
                {
                    Dailybase = 200;
                }
                else if (txtPosition.Text == "Winger")
                {
                    Dailybase = 400;
                }
                else
                {
                    Dailybase = 500;
                }
                Total = Dailybase * int.Parse(txtPlayedGames.Text);
                rtbSalarySlip.Text = "Footballer's ID: " + txtFootballerId.Text + "\n" + "First name: " + txtFirstName.Text + "\n" + "Last name: " + txtLastName.Text + "\n" + "Position: " + txtPosition.Text + "\n" + "Played games this season: " + txtPlayedGames.Text + "\n" + "Total wage: " + Total + "KM";
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====FOOTBALLER'S SALARY=====", new Font("Latin", 20, FontStyle.Bold), Brushes.DarkBlue, new Point(130, 50));
            e.Graphics.DrawString("Footballer's ID: " + txtFootballerId.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 130));
            e.Graphics.DrawString("First name: " + txtFirstName.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 180));
            e.Graphics.DrawString("Last name: " + txtLastName.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 230));
            e.Graphics.DrawString("Position: " + txtPosition.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 280));
            e.Graphics.DrawString("Played games this season: " + txtPlayedGames.Text, new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 330));
            e.Graphics.DrawString("Total wage: " + Total + "KM", new Font("Latin", 18, FontStyle.Bold), Brushes.DodgerBlue, new Point(50, 380));
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
