using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelBase.Model;
using HostelBase.HelpMethod;
using System.Net.Mail;

namespace HostelBase
{
    public partial class Login : Form
    {
        HostelEntities _context;
        
        
        public Login()
        {
            InitializeComponent();
            _context = new HostelEntities();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool isAdmin = chAdmin.Checked;

            if (isAdmin)
            {
                if (Properties.Settings.Default.adminEmail == email &&
                   Properties.Settings.Default.adminPassword == password)
                {
                    new AdminPanel().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Admin email or password is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                Employee selectedemp = _context.Employees.FirstOrDefault(s => s.Email == email);
                if (selectedemp == null)
                {
                    MessageBox.Show("Email or password is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //CheckPassword
                if (!HelpMethod.HashAndCheck.CheckPassword(password, selectedemp.Password))
                {
                    MessageBox.Show("Email or password is wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((bool)selectedemp.isDeleted)
                {
                    MessageBox.Show("Your Account Is Deleted .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                loginid.LoginInfo.UserID = selectedemp.ID;
                new HostelReg().ShowDialog();
            }
            txtEmail.Clear();
            txtPassword.Clear();
            
        }

        private void chAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Visible = true;
            txtforgot.Visible = true;
            btnforgot.Visible = true;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtforgot.Visible = false;
            btnforgot.Visible = false;
        }

        private void btnforgot_Click(object sender, EventArgs e)
        {
            string currentemail = txtforgot.Text.Trim();
            try
            {
                MailAddress mailAddress = new MailAddress(currentemail);
            }
            catch (Exception)
            {
                MessageBox.Show("Email address not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee employee = _context.Employees.FirstOrDefault(emp => emp.Email == currentemail);

            if (employee == null)
            {
                MessageBox.Show(" You entered email addressdoes not match any accounts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Recovery Message Sended Your Email.Pleace Open {currentemail}");
            
            txtforgot.Clear();
            label4.Visible = false;
            txtforgot.Visible = false;
            btnforgot.Visible = false;
        }
    }
}
