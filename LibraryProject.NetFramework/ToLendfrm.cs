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
    public partial class ToLendfrm : Form
    {
        public ToLendfrm()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryProject;Integrated Security=True");
        DataSet daset = new DataSet();
        private void UserInformation_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actionsList ()
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select ActionId AS 'İşlem Numarası',Books.BookName AS 'Kitap Adı',Users.UserName as 'Kullanıcı Adı',Employees.EmployeeName as 'Personel Adı',ReceiveDate,ReturnDate from Actions inner join Books on Actions.BookId = Books.BookId  inner join Users on Users.UserId  = Actions.UserId inner join Employees on Actions.EmployeeId = Employees.EmployeeId order by ActionId asc ", connect);
            adapter.Fill(daset,"Actions");
            dataGridView1.DataSource = daset.Tables["Actions"];
            connect.Close();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("insert into Actions(BookId,UserId,EmployeeId,ReceiveDate,ReturnDate) values(@BookId,@UserId,@EmployeeId,@ReceiveDate,@ReturnDate)", connect);
            command.Parameters.AddWithValue("@BookId", comboBookId.Text);
            command.Parameters.AddWithValue("@UserId", txtUserName.Text);
            command.Parameters.AddWithValue("@EmployeeId", txtEmployee.Text);
            command.Parameters.AddWithValue("@ReceiveDate", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@ReturnDate", dateTimePicker2.Value);
            command.ExecuteNonQuery();
            connect.Close();
            daset.Tables["Actions"].Clear();
            actionsList();
            MessageBox.Show("Kitap Üyeye Başarılı Bir Şekilde Teslim Edildi.");
            foreach (Control item in ToLendInformation.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ToLendfrm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("select BookId from Books where BookStatus = 'true' ", connect);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                comboBookId.Items.Add(read["BookId"]);
            }
            connect.Close();
            actionsList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBookId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
