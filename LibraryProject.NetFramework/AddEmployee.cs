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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Employees(EmployeeName,UserName,Password) values(@EmployeeName,@UserName,@Password)", connect);
            command.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text);
            command.Parameters.AddWithValue("@UserName", txtUserName.Text);
            command.Parameters.AddWithValue("@Password", txtPassword.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Personel Kaydı Başarılı Bir Şekilde Gerçekleştirildi.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
