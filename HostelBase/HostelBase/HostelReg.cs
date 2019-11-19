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
    public partial class HostelReg : Form
    {
        HostelEntities _context;
        
        public HostelReg()
        {
            InitializeComponent();
            _context = new HostelEntities();
        }
       

       

        private void btnRegistrarion_Click(object sender, EventArgs e)
        {
            
            var selected = cmbEmRoom.SelectedItem as ComboboxItem;
            var selectedbed = cmbEmBed.SelectedItem as ComboboxItem;
            //My Dates
            int emptroom = selected.Id;
            int emptbed = selectedbed.Id;
            var arrivedata = dtArrival.Value;
            var revrsedate = dtRelease.Value;
            var identityguest = "AZE" + txtGuestIdentity.Text;
            int employeeId = loginid.LoginInfo.UserID;
            Bed bed = _context.Beds.Find(emptbed);
            decimal totalday =(Convert.ToDecimal(revrsedate.Day) - Convert.ToDecimal(arrivedata.Day));
            decimal totalprice = Convert.ToDecimal( bed.Price) * totalday;

            if (arrivedata.Date < DateTime.Now.Date || revrsedate.Date == DateTime.Now.Date || revrsedate.Date < DateTime.Now.Date)
            {
                MessageBox.Show("DateTime is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Guest selectedgues = _context.Guests.FirstOrDefault(s => s.IdentityNum == identityguest);
            lblerror.Visible = false;
            linkGuestRegPage.Visible = false;

            if (selectedgues == null)
            {
                MessageBox.Show("Guest not found!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblerror.Visible = true;
                linkGuestRegPage.Visible = true;
                return;
            }
           
            
           Reservation reservation =  new Reservation
            {
                RoomID = emptroom,
                BedID = emptbed,
                EmployeeID = employeeId,
                StartTime = arrivedata,
                EndTime = revrsedate,
                GuestID = selectedgues.ID,
                TotalAmount = totalprice
            };
            Income ıncome = new Income
            {
                Amount = totalprice,
                ReservationID = reservation.ID
            };
            bed.isDeleted = true;
            _context.Incomes.Add(ıncome);
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            MessageBox.Show($"Registration Succecful!Person {selectedgues.Firstname + " " + selectedgues.Lastname}");
           this.Close();
        }

        private void HostelReg_Load(object sender, EventArgs e)
        {
            var selectedroom = _context.Rooms.Where(r => r.isDeleted == false).Select(r => new ComboboxItem { Id = r.ID, Name = r.Name + " No " + r.Number }).ToArray();
            cmbEmRoom.DataSource = (selectedroom);
            Employee em = _context.Employees.FirstOrDefault(emp=>emp.ID == loginid.LoginInfo.UserID);
            lblUser.Text = em.FullName;
        }

        private void cmbEmRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecteditem = cmbEmRoom.SelectedItem as ComboboxItem;
            var beds = _context.Beds.Where(b => b.RoomID == selecteditem.Id && b.isDeleted == false).Select(c => new ComboboxItem { Id = c.ID, Name = c.Sort + " No" + c.Number.ToString() + " Price " + c.Price.ToString() + " Azn" }).ToArray();
            cmbEmBed.DataSource = beds;
        }

        private void linkGuestRegPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new GuestAdd().ShowDialog();

        }

        private void cmbEmBed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPass().ShowDialog();
        }
    }
}
