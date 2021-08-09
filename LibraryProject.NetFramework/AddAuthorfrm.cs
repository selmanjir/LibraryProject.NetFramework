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
    public partial class AddAuthorfrm : Form
    {
        public AddAuthorfrm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAuthorfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Authors(AuthorFirstName,AuthorLastName,Detail) values(@AuthorFirstName,@AuthorLastName,@Detail)", connect);
            command.Parameters.AddWithValue("@AuthorFirstName", txtAuthorFirstName.Text);
            command.Parameters.AddWithValue("@AuthorLastName", txttxtAuthorLastName.Text);
            command.Parameters.AddWithValue("@Detail", txtDetail.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Yazar Kaydı Başarılı Bir Şekilde Gerçekleştirildi.");
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
