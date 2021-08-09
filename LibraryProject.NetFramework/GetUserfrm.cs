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
    public partial class GetUserfrm : Form
    {
        public GetUserfrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstName.Text = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Users"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Users where UserName like '%" + txtFind.Text + "%' ", connect);
            adtr.Fill(daset, "Users");
            dataGridView1.DataSource = daset.Tables["Users"];
            connect.Close();

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Users where UserName like '" + txtUserName.Text + "' ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtFirstName.Text = read["FirstName"].ToString();
                txtLastName.Text = read["LastName"].ToString();
                txtMail.Text = read["Mail"].ToString();
                txtPassword.Text = read["Password"].ToString();
                txtTelephone.Text = read["Telephone"].ToString();
                txtSchool.Text = read["School"].ToString();
                comboEducationStatusForNet.Text = read["EducationStatusForNet"].ToString();

            }
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz ?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                connect.Open();
                SqlCommand command = new SqlCommand("delete from Users where UserName=@UserName", connect);
                command.Parameters.AddWithValue("@UserName", dataGridView1.CurrentRow.Cells["UserName"].Value.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                daset.Tables["Users"].Clear();
                getUser();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            
        }
        private void getUser()
        {
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Users", connect);
            adtr.Fill(daset, "Users");
            dataGridView1.DataSource = daset.Tables["Users"];
            connect.Close();
        }

        private void GetUserfrm_Load(object sender, EventArgs e)
        {
            getUser();
        }

        private void btnUptdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update Users set FirstName=@FirstName,LastName=@LastName,Mail=@Mail,Password=@Password,Telephone=@Telephone,School=@School,EducationStatusForNet=@EducationStatusForNet where UserName=@UserName ", connect);
            command.Parameters.AddWithValue("@UserName", txtUserName.Text);
            command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            command.Parameters.AddWithValue("@LastName", txtLastName.Text);
            command.Parameters.AddWithValue("@Mail", txtMail.Text);
            command.Parameters.AddWithValue("@Password", txtPassword.Text);
            command.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
            command.Parameters.AddWithValue("@School", txtSchool.Text);
            command.Parameters.AddWithValue("@EducationStatusForNet", comboEducationStatusForNet.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
            daset.Tables["Users"].Clear();
            getUser();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
