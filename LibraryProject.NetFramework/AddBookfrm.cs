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
    public partial class AddBookfrm : Form
    {
        public AddBookfrm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        private void AddBookfrm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Categories ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboCategories.Items.Add(read["CategoryName"]);
            }
            connect.Close();
            connect.Open();
            SqlCommand command1 = new SqlCommand("select * from Authors ", connect);
            SqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                comboAuthors.Items.Add(read1["AuthorLastName"]);
            }

            connect.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Books(BookName,CategoryForNet,AuthorForNet,YearOfPublication,Publisher,Page) values(@BookName,@CategoryForNet,@AuthorForNet,@YearOfPublication,@Publisher,@Page)", connect);
            command.Parameters.AddWithValue("@BookName", txtBookName.Text);
            command.Parameters.AddWithValue("@CategoryForNet", comboCategories.Text);
            command.Parameters.AddWithValue("@AuthorForNet", comboAuthors.Text);
            command.Parameters.AddWithValue("@YearOfPublication", txtYearOfPublication.Text);
            command.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@Page", txtPage.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kitap Kaydı Başarılı Bir Şekilde Gerçekleştirildi.");
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

        private void comboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBookPhoto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
