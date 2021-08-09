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
    public partial class GetBookfrm : Form
    {
        public GetBookfrm()
        {
            InitializeComponent();
        }
        private void getBook()
        {
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Books", connect);
            adtr.Fill(daset, "Books");
            dataGridView1.DataSource = daset.Tables["Books"];
            connect.Close();
        }

        private void GetBookfrm_Load(object sender, EventArgs e)
        {
            getBook();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBookName.Text = dataGridView1.CurrentRow.Cells["BookName"].Value.ToString();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Books"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Books where BookName like '%" + txtFind.Text + "%' ", connect);
            adtr.Fill(daset, "Books");
            dataGridView1.DataSource = daset.Tables["Books"];
            connect.Close();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Books where BookName like '" + txtBookName.Text + "' ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtBookName.Text = read["BookName"].ToString();
                comboCategories.Text = read["CategoryForNet"].ToString();
                comboAuthors.Text = read["AuthorForNet"].ToString();
                txtYearOfPublication.Text = read["YearOfPublication"].ToString();
                txtPublisher.Text = read["Publisher"].ToString();
                txtPage.Text = read["Page"].ToString();

            }
            connect.Close();
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
                SqlCommand command = new SqlCommand("delete from Books where BookName=@BookName", connect);
                command.Parameters.AddWithValue("@BookName", dataGridView1.CurrentRow.Cells["BookName"].Value.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                daset.Tables["Books"].Clear();
                getBook();
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
            SqlCommand command = new SqlCommand("update Books set BookName=@BookName,CategoryForNet=@CategoryForNet,AuthorForNet=@AuthorForNet,YearOfPublication=@YearOfPublication,Publisher=@Publisher,Page=@Page where BookName=@BookName ", connect);
            command.Parameters.AddWithValue("@BookName", txtBookName.Text);
            command.Parameters.AddWithValue("@CategoryForNet", comboCategories.Text);
            command.Parameters.AddWithValue("@AuthorForNet", comboAuthors.Text);
            command.Parameters.AddWithValue("@YearOfPublication", txtYearOfPublication.Text);
            command.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@Page", txtPage.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
            daset.Tables["Books"].Clear();
            getBook();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
