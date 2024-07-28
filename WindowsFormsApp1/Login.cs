using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private bool is_logged = false;
        public bool get_is_logged()
        {
            return this.is_logged;
        }
        public void set_is_logged(bool is_logged)
        {
            this.is_logged = is_logged;
        }
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Admin" && textBoxPass.Text == "123") //edit user and pass
            {
                MessageBox.Show("Logged in succesfully !");
                this.set_is_logged(true);
                this.Hide();
            }
            else
            {
                textBoxUser.Text = "";
                textBoxPass.Text = "";
                MessageBox.Show("Invalid user name or password.");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


