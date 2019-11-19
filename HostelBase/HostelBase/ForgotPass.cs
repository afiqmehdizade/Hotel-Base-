using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelBase.HelpMethod;
using HostelBase.Model;
using HostelBase;


namespace HostelBase
{
    public partial class ForgotPass : Form
    {
       private readonly HostelEntities _context;
        public ForgotPass()
        {
            InitializeComponent();
            _context = new HostelEntities();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrentPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();
            Employee employee = _context.Employees.Find(loginid.LoginInfo.UserID);
            

            if (currentPass.Length == 0 || newPass.Length == 0|| confirmPass.Length == 0)
            {
                MessageBox.Show("Pleace enter password!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (newPass.Length <= 5)
            {
                MessageBox.Show("Password Short! ");
                return;
            }
            if (newPass!=confirmPass )
            {
                MessageBox.Show("Pleace enter valid confirm password");
                return;
            }
            if (HelpMethod.HashAndCheck.HashPassword(currentPass) != employee.Password)
            {
                MessageBox.Show("Current Password Not Valid!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            employee.Password = HelpMethod.HashAndCheck.HashPassword(newPass);
            await  _context.SaveChangesAsync();
            MessageBox.Show("Password Change Succesfull!");
            Close();
            
        }
    }
}
