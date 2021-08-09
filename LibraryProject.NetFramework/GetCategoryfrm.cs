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
    public partial class GetCategoryfrm : Form
    {
        public GetCategoryfrm()
        {
            InitializeComponent();
        }
        private void getCategory()
        {
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Categories", connect);
            adtr.Fill(daset, "Categories");
            dataGridView1.DataSource = daset.Tables["Categories"];
            connect.Close();
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCategoryId.Text = dataGridView1.CurrentRow.Cells["CategoryId"].Value.ToString();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();

        private void GetCategoryfrm_Load(object sender, EventArgs e)
        {
            getCategory();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Categories"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Categories where CategoryId like '%" + txtFind.Text + "%' ", connect);
            adtr.Fill(daset, "Categories");
            dataGridView1.DataSource = daset.Tables["Categories"];
            connect.Close();
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            
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
                SqlCommand command = new SqlCommand("delete from Categories where CategoryId=@CategoryId", connect);
                command.Parameters.AddWithValue("@CategoryId", dataGridView1.CurrentRow.Cells["CategoryId"].Value.ToString());
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                daset.Tables["Categories"].Clear();
                getCategory();
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
            SqlCommand command = new SqlCommand("update Categories set CategoryName=@CategoryName where CategoryId=@CategoryId ", connect);
            command.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
            daset.Tables["Categories"].Clear();
            getCategory();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select * from Categories where CategoryId like '" + txtCategoryId.Text + "' ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtCategoryId.Text = read["CategoryId"].ToString();
                txtCategoryName.Text = read["CategoryName"].ToString();
            }
            connect.Close();
        }
    }
}
