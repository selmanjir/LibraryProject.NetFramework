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
    public partial class OnLoanfrm : Form
    {
        public OnLoanfrm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();
        private void actionsList()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select ActionId,BookId,UserId,EmployeeId,ReceiveDate,ReturnDate from Actions where ActionStatus = 'false' ", connect);
            adapter.Fill(daset, "Actions");
            dataGridView1.DataSource = daset.Tables["Actions"];
            connect.Close();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFind.Text = dataGridView1.CurrentRow.Cells["ActionId"].Value.ToString();
        }

        private void OnLoanfrm_Load(object sender, EventArgs e)
        {
            actionsList();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Actions"].Clear();
            connect.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ActionId,BookId,UserId,EmployeeId,ReceiveDate,ReturnDate from Actions where ActionId like '%" + txtFind.Text + "%' and ActionStatus='false'  ", connect);
            adtr.Fill(daset, "Actions");
            dataGridView1.DataSource = daset.Tables["Actions"];
            connect.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnLoan_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("update Actions set UserReturnDate=@UserReturnDate,ActionStatus=@ActionStatus where ActionId=@ActionId ", connect);
            command.Parameters.AddWithValue("@ActionId", dataGridView1.CurrentRow.Cells["ActionId"].Value.ToString());
            command.Parameters.AddWithValue("@UserReturnDate", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@ActionStatus", true);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kitap teslim işlemi gerçekleştirildi");
            daset.Tables["Actions"].Clear();
            actionsList();
            foreach (Control item in dataGridView1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
