
namespace LibraryProject.NetFramework
{
    partial class HomePagefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetAuthor = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnOnLoan = new System.Windows.Forms.Button();
            this.btnToLend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetUser);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(34, 48);
            this.btnGetUser.Name = "btnGetUser";
            this.btnGetUser.Size = new System.Drawing.Size(180, 23);
            this.btnGetUser.TabIndex = 2;
            this.btnGetUser.Text = "Üye Listeleme";
            this.btnGetUser.UseVisualStyleBackColor = true;
            this.btnGetUser.Click += new System.EventHandler(this.btnGetUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(34, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(180, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Üye Ekleme";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetBook);
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnGetBook
            // 
            this.btnGetBook.Location = new System.Drawing.Point(34, 48);
            this.btnGetBook.Name = "btnGetBook";
            this.btnGetBook.Size = new System.Drawing.Size(180, 23);
            this.btnGetBook.TabIndex = 3;
            this.btnGetBook.Text = "Kitap Listeleme";
            this.btnGetBook.UseVisualStyleBackColor = true;
            this.btnGetBook.Click += new System.EventHandler(this.btnGetBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(34, 19);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(180, 23);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Kitap Ekleme";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetAuthor);
            this.groupBox3.Controls.Add(this.btnAddAuthor);
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yazar İşlemleri";
            // 
            // btnGetAuthor
            // 
            this.btnGetAuthor.Location = new System.Drawing.Point(34, 48);
            this.btnGetAuthor.Name = "btnGetAuthor";
            this.btnGetAuthor.Size = new System.Drawing.Size(180, 23);
            this.btnGetAuthor.TabIndex = 3;
            this.btnGetAuthor.Text = "Yazar Listeleme";
            this.btnGetAuthor.UseVisualStyleBackColor = true;
            this.btnGetAuthor.Click += new System.EventHandler(this.btnGetAuthor_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(34, 19);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(180, 23);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Yazar Ekleme";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetCategory);
            this.groupBox4.Controls.Add(this.btnAddCategory);
            this.groupBox4.Location = new System.Drawing.Point(12, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kategori İşlemleri";
            // 
            // btnGetCategory
            // 
            this.btnGetCategory.Location = new System.Drawing.Point(34, 48);
            this.btnGetCategory.Name = "btnGetCategory";
            this.btnGetCategory.Size = new System.Drawing.Size(180, 23);
            this.btnGetCategory.TabIndex = 3;
            this.btnGetCategory.Text = "Kategori Listeleme";
            this.btnGetCategory.UseVisualStyleBackColor = true;
            this.btnGetCategory.Click += new System.EventHandler(this.btnGetCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(34, 19);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 23);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Kategori Ekleme";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGetEmployee);
            this.groupBox5.Controls.Add(this.btnAddEmployee);
            this.groupBox5.Location = new System.Drawing.Point(327, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 96);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personel İşlemleri";
            // 
            // btnGetEmployee
            // 
            this.btnGetEmployee.Location = new System.Drawing.Point(34, 48);
            this.btnGetEmployee.Name = "btnGetEmployee";
            this.btnGetEmployee.Size = new System.Drawing.Size(180, 23);
            this.btnGetEmployee.TabIndex = 2;
            this.btnGetEmployee.Text = "Personel Listeleme";
            this.btnGetEmployee.UseVisualStyleBackColor = true;
            this.btnGetEmployee.Click += new System.EventHandler(this.btnGetEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(34, 19);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(180, 23);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Personel Ekleme";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnOnLoan);
            this.groupBox6.Controls.Add(this.btnToLend);
            this.groupBox6.Location = new System.Drawing.Point(327, 246);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ödünç Kitap İşlemleri";
            // 
            // btnOnLoan
            // 
            this.btnOnLoan.Location = new System.Drawing.Point(34, 48);
            this.btnOnLoan.Name = "btnOnLoan";
            this.btnOnLoan.Size = new System.Drawing.Size(180, 23);
            this.btnOnLoan.TabIndex = 3;
            this.btnOnLoan.Text = "Ödünç Kitap Al";
            this.btnOnLoan.UseVisualStyleBackColor = true;
            this.btnOnLoan.Click += new System.EventHandler(this.btnOnLoan_Click_1);
            // 
            // btnToLend
            // 
            this.btnToLend.Location = new System.Drawing.Point(34, 19);
            this.btnToLend.Name = "btnToLend";
            this.btnToLend.Size = new System.Drawing.Size(180, 23);
            this.btnToLend.TabIndex = 1;
            this.btnToLend.Text = "Ödünç Kitap Ver";
            this.btnToLend.UseVisualStyleBackColor = true;
            this.btnToLend.Click += new System.EventHandler(this.btnToLend_Click);
            // 
            // HomePagefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(582, 400);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePagefrm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.HomePagefrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnGetCategory;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGetEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnToLend;
        private System.Windows.Forms.Button btnOnLoan;
    }
}

