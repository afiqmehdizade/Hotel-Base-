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
    public partial class AdminPanel : Form
    {
        HostelEntities _context;
        public AdminPanel()
        {
            InitializeComponent();
            _context = new HostelEntities();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Incomes.Select(b => new
            {
                b.Reservation.Employee.FullName,
                b.Amount,
                Guest =  b.Reservation.Guest.Firstname + b.Reservation.Guest.Lastname,
                b.Reservation.Room.Number,
                Bed = b.Reservation.Bed.Number,
                b.Reservation.StartTime,
                b.Reservation.EndTime,
            }).ToList();

            lblTotal.Visible = true;
            lblcount.Text = _context.Incomes.Sum(i => i.Amount).ToString();
            lblcount.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addoutcom_Click(object sender, EventArgs e)
        {
            new AddOutcome().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Reservations.Select(r=>new {
             _Employee = r.Employee.FullName,
             Guest_Info = r.Guest.Firstname + r.Guest.Lastname,
             RoomInfo = r.Room.Number + " " +r.Room.Name,
             BedNumber = r.Bed.Number,
             TotalPrice = r.TotalAmount,
             r.StartTime,
             r.EndTime
            }).ToList();
            lblcount.Visible = false;
            lblTotal.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Outcomes.Select(o => new {
                o.Name,
                o.Date,
                o.Amount
            }).ToList();
            lblTotal.Text = "Total OutCome";
            lblTotal.Visible = true;
            lblcount.Text = _context.Outcomes.Sum(i => i.Amount).ToString();
            lblcount.Visible = true;
        }

        private void btnSIncome_Click(object sender, EventArgs e)
        {
            var incdateStart = dtFrom.Value;
            var incdatceEnd = dtTo.Value;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Incomes.Where(i=>i.Reservation.StartTime.Value>=incdateStart.Date &&
                                                              i.Reservation.EndTime.Value<= incdatceEnd.Date )
                                                              .Select(b => new
            {
                b.Reservation.Employee.FullName,
                b.Amount,
                Guest = b.Reservation.Guest.Firstname + b.Reservation.Guest.Lastname,
                b.Reservation.Room.Number,
                Bed = b.Reservation.Bed.Number,
                b.Reservation.StartTime,
                b.Reservation.EndTime,
            }).ToList();

            lblTotal.Text = "Total of Months";
            lblTotal.Visible = true;
            lblcount.Text = _context.Incomes.Where(i => i.Reservation.StartTime.Value >= incdateStart.Date &&
                                                              i.Reservation.EndTime.Value <= incdatceEnd.Date).Sum(i => i.Amount).ToString();
            lblcount.Visible = true;
        }

        private void btnSregs_Click(object sender, EventArgs e)
        {
            var regdateStart = dtFrom.Value;
            var regdatceEnd = dtTo.Value;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Reservations.Where(r=>r.StartTime.Value>=regdateStart.Date && r.EndTime.Value <= regdatceEnd).Select(r => new {
                _Employee = r.Employee.FullName,
                Guest_Info = r.Guest.Firstname + r.Guest.Lastname,
                RoomInfo = r.Room.Number + " " + r.Room.Name,
                BedNumber = r.Bed.Number,
                TotalPrice = r.TotalAmount,
                r.StartTime,
                r.EndTime
            }).ToList();
            lblcount.Visible = false;
            lblTotal.Visible = false;
        }

        private void btnSoutcome_Click(object sender, EventArgs e)
        {
            var outdateStart = dtFrom.Value;
            var outdatceEnd = dtTo.Value;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _context.Outcomes.Where(r => r.Date.Value >= outdateStart.Date && r.Date.Value <= outdatceEnd).Select(r => new
            {
                r.Date,
                r.Name,
                r.Amount
            }).ToList();

            lblTotal.Text = "Total of Months";
            lblTotal.Visible = true;
            lblcount.Text = _context.Outcomes.Where(r => r.Date.Value >= outdateStart.Date && r.Date.Value <= outdatceEnd).Sum(i => i.Amount).ToString();
            lblcount.Visible = true;
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            new FormRegist().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddRomOrBrone().ShowDialog();
        }

       
    }
}
