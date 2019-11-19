using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelBase;
using HostelBase.Model;
using HostelBase.HelpMethod;
using System.Net.Mail;


namespace HostelBase
{

    public partial class FormRegist : Form
    {
       
       private readonly  HostelEntities _context;
        public FormRegist()
        {
            InitializeComponent();
            _context = new HostelEntities();
            
        }
        

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string reppasword = txtRepeatPassword.Text.Trim();
            bool isDelete = false;



            if (ModelStateIsValid(email, fullname, password, reppasword))
            {

                if (_context.Employees.Any(em => em.Email == email))
                {
                    MessageBox.Show("This email has been assigned!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.Employees.Add(new Employee
                {
                    Email = email,
                    FullName = fullname,
                    isDeleted = isDelete,
                    Password = HelpMethod.HashAndCheck.HashPassword(password)

                });
                await _context.SaveChangesAsync();
                MessageBox.Show("Registration hass been success!");
                Close();

            }

        }
        private bool ModelStateIsValid(string email, string fullname, string pass, string repPass)
        {
            //checks email
            try
            {
                MailAddress mailAddress = new MailAddress(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email is not valid.", "Sorry, babe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //checks fullname
            if (fullname.Length < 3)
            {
                MessageBox.Show("Fullname is not valid.", "Sorry, babe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //checks pass
            if (pass.Length < 5)
            {
                MessageBox.Show("Password is not valid.", "Sorry, babe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //checks pass == repPass
            if (pass != repPass)
            {
                MessageBox.Show("Password and Repeat Password don't match.", "Sorry, babe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FormRegist_Load(object sender, EventArgs e)
        {
            
        }
    }

}
