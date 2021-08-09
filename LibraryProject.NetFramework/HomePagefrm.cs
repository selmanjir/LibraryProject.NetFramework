using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.NetFramework
{
    public partial class HomePagefrm : Form
    {
        public HomePagefrm()
        {
            InitializeComponent();
        }

        private void HomePagefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserfrm addUser = new AddUserfrm();
            addUser.ShowDialog();
        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            GetUserfrm getUser = new GetUserfrm();
            getUser.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryfrm addCategoryfrm = new AddCategoryfrm();
            addCategoryfrm.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookfrm addBook = new AddBookfrm();
            addBook.ShowDialog();
        }

        private void btnGetBook_Click(object sender, EventArgs e)
        {
            GetBookfrm getBook = new GetBookfrm();
            getBook.ShowDialog();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorfrm addAuthor = new AddAuthorfrm();
            addAuthor.ShowDialog();
        }

        private void btnGetAuthor_Click(object sender, EventArgs e)
        {
            GetAuthorfrm getAuthorfrm = new GetAuthorfrm();
            getAuthorfrm.ShowDialog();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            GetCategoryfrm getCategoryfrm = new GetCategoryfrm();
            getCategoryfrm.ShowDialog();
        }

        private void btnToLend_Click(object sender, EventArgs e)
        {
            ToLendfrm toLendfrm = new ToLendfrm();
            toLendfrm.ShowDialog();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new  AddEmployee();
            addEmployee.ShowDialog();
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            GetEmployee getEmployee = new GetEmployee();
            getEmployee.ShowDialog();
        }

        private void btnOnLoan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOnLoan_Click_1(object sender, EventArgs e)
        {
            OnLoanfrm onLoanfrm = new OnLoanfrm();
            onLoanfrm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
