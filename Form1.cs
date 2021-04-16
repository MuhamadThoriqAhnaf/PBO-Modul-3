using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbUsername.Text, tbPassword.Text);
            if (employee.Login(employee.LoginName, employee.Password))
            {
                MessageBox.Show("Login Berhasil, ID anda adalah " + employee.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
