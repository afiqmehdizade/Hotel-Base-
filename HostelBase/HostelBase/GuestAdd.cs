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
    public partial class GuestAdd : Form
    {
        HostelEntities _context;
        public GuestAdd()
        {
            InitializeComponent();
            _context = new HostelEntities();

        }

        private async void btnRegistrarion_Click(object sender, EventArgs e)
        {
            string fname = txtGFirstname.Text.Trim();
            string lname = txtgLastname.Text.Trim();
            var identityguest = "AZE" + txtIdentity.Text.Trim();
            var borndata = dtBorndate.Value;
            string telephone ="0"+txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (fname.Length < 3 || string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Firstname is not valid!");
                return;
            }
            if (lname.Length < 3 || string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Lastname is not valid!");
                return;
            }
            try
            {
                MailAddress mailAddress = new MailAddress(email);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Email is not Valid!");
                return;
            }
            Guest guest = _context.Guests.FirstOrDefault(g => g.IdentityNum == identityguest || g.Email.ToLower() == email.ToLower());
            if (guest != null)
            {
                MessageBox.Show("This Guest already assigned!Pleace entred only Identity NUmber in Registration");
                return;
            }
            if (borndata.Date>DateTime.Now.Date)
            {
                MessageBox.Show("BirthDay is not valid!");
                return;
            }
            Guest guest2 = new Guest
            {
                Firstname = fname,
                Lastname = lname,
                Email = email,
                Telephone = telephone,
                Born = borndata,
                IdentityNum = identityguest,
                
            };
            MessageBox.Show("Guest succefuly added!");
            _context.Guests.Add(guest2);
           await _context.SaveChangesAsync();
            
        }
    }
}
