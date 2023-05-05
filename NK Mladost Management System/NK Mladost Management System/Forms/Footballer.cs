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
    public partial class Footballer : Form
    {
        public Footballer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\MSSQLSERVER16;Initial Catalog=MyFootballerDb;Integrated Security=True");

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFootballerId.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cmbPosition.SelectedItem.ToString() == "" || dtpDateOfBirth.Value.Date.ToString() == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Missing information!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into FootballerTbl values('" + txtFootballerId.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + dtpDateOfBirth.Value.Date.ToString() + "', '" + cmbPosition.SelectedItem.ToString() + "', '" + txtNumber.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Footballer added successfully!");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Populate()
        {
            con.Open();
            string query = "select * from FootballerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvFootballer.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Footballer_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFootballerId.Text == "")
            {
                MessageBox.Show("Enter the ID of footballer.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from FootballerTbl where Id='" + txtFootballerId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Footballer deleted successfully!");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dgvFootballer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFootballerId.Text = dgvFootballer.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dgvFootballer.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dgvFootballer.SelectedRows[0].Cells[2].Value.ToString();
            cmbPosition.SelectedItem = dgvFootballer.SelectedRows[0].Cells[4].Value.ToString();
            txtNumber.Text = dgvFootballer.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtFootballerId.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cmbPosition.SelectedItem.ToString() == "" || dtpDateOfBirth.Value.Date.ToString() == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Missing information!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update FootballerTbl set FirstName='" + txtFirstName.Text + "',LastName='" + txtLastName.Text + "',Position='" + cmbPosition.SelectedItem.ToString() + "',DateOfBirth='" + dtpDateOfBirth.Value.Date + "',ShirtNumber='" + txtNumber.Text + "' where Id='" + txtFootballerId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Footballer updated successfully");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
