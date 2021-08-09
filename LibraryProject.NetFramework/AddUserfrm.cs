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
using static System.Net.Mime.MediaTypeNames;

namespace LibraryProject.NetFramework
{
    public partial class AddUserfrm : Form
    {
        public AddUserfrm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUserfrm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from EducationStatuses ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboEducationStatusForNet.Items.Add(read["EducationStatus"]);
            }

            connect.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Users(FirstName,LastName,Mail,UserName,Password,Telephone,School,EducationStatusForNet) values(@FirstName,@LastName,@Mail,@UserName,@Password,@Telephone,@School,@EducationStatusForNet)", connect);
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            command.Parameters.AddWithValue("@LastName", txtLastName.Text);
            command.Parameters.AddWithValue("@Mail", txtMail.Text);
            command.Parameters.AddWithValue("@UserName", txtUserName.Text);
            command.Parameters.AddWithValue("@Password", txtPassword.Text);
            command.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
            command.Parameters.AddWithValue("@School", txtSchool.Text);
            command.Parameters.AddWithValue("@EducationStatusForNet", comboEducationStatusForNet.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Üye Kaydı Başarılı Bir Şekilde Gerçekleştirildi.");
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

        private void comboEducationStatusForNet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
