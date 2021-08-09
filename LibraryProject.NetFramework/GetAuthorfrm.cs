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
    public partial class GetAuthorfrm : Form
    {
        public GetAuthorfrm()
        {
            InitializeComponent();
        }
        private void getAuthor()
        {
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Authors", connect);
            adtr.Fill(daset, "Authors");
            dataGridView1.DataSource = daset.Tables["Authors"];
            connect.Close();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAuthorFirstName.Text = dataGridView1.CurrentRow.Cells["AuthorFirstName"].Value.ToString();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();

        private void GetAuthorfrm_Load(object sender, EventArgs e)
        {
            getAuthor();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Authors"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Authors where AuthorFirstName like '%" + txtFind.Text + "%' ", connect);
            adtr.Fill(daset, "Authors");
            dataGridView1.DataSource = daset.Tables["Authors"];
            connect.Close();
        }

        private void txtAuthorFirstName_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Authors where AuthorFirstName like '" + txtAuthorFirstName.Text + "' ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtAuthorFirstName.Text = read["AuthorFirstName"].ToString();
                txtAuthorLastName.Text = read["AuthorLastName"].ToString();
                txtDetail.Text = read["Detail"].ToString();
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
                SqlCommand command = new SqlCommand("delete from Authors where AuthorFirstName=@AuthorFirstName", connect);
                command.Parameters.AddWithValue("@AuthorFirstName", dataGridView1.CurrentRow.Cells["AuthorFirstName"].Value.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                daset.Tables["Authors"].Clear();
                getAuthor();
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
            SqlCommand command = new SqlCommand("update Authors set AuthorFirstName=@AuthorFirstName,AuthorLastName=@AuthorLastName,Detail=@Detail where AuthorFirstName=@AuthorFirstName ", connect);
            command.Parameters.AddWithValue("@AuthorFirstName", txtAuthorFirstName.Text);
            command.Parameters.AddWithValue("@AuthorLastName", txtAuthorLastName.Text);
            command.Parameters.AddWithValue("@Detail", txtDetail.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
            daset.Tables["Authors"].Clear();
            getAuthor();
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
