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
    public partial class AddCategoryfrm : Form
    {
        public AddCategoryfrm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        private void AddCategoryfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Categories (CategoryName) values(@CategoryName)", connect);
            command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kategori Kaydı Başarılı Bir Şekilde Gerçekleştirildi.");
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
