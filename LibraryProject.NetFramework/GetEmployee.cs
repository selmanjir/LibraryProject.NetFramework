using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.NetFramework
{
    public partial class GetEmployee : Form
    {
        public GetEmployee()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();
        private void getEmployee()
        {
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Employees", connect);
            adtr.Fill(daset, "Employees");
            dataGridView1.DataSource = daset.Tables["Employees"];
            connect.Close();
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Employees"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Employees where EmployeeName like '%" + txtFind.Text + "%' ", connect);
            adtr.Fill(daset, "Employees");
            dataGridView1.DataSource = daset.Tables["Employees"];
            connect.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeName.Text = dataGridView1.CurrentRow.Cells["EmployeeName"].Value.ToString();
        }

        private void GetEmployee_Load(object sender, EventArgs e)
        {
            getEmployee();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from Employees where EmployeeName=@EmployeeName", connect);
                command.Parameters.AddWithValue("@EmployeeName", dataGridView1.CurrentRow.Cells["EmployeeName"].Value.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                daset.Tables["Employees"].Clear();
                getEmployee();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update Employees set UserName=@UserName,EmployeeName=@EmployeeName,Password=@Password where EmployeeName=@EmployeeName ", connect);
            command.Parameters.AddWithValue("@UserName", txtUserName.Text);
            command.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text);
            command.Parameters.AddWithValue("@Password", txtPassword.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
            daset.Tables["Employees"].Clear();
            getEmployee();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Employees where EmployeeName like '" + txtEmployeeName.Text + "' ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtEmployeeName.Text = read["EmployeeName"].ToString();
                txtUserName.Text = read["UserName"].ToString();
                txtPassword.Text = read["Password"].ToString();
            }
            connect.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
