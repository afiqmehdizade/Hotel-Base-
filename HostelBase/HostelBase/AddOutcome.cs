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
    public partial class AddOutcome : Form
    {
        HostelEntities _context;
        public AddOutcome()
        {
           InitializeComponent();
            _context = new HostelEntities();
        }

       

        private async void addoutcom_Click(object sender, EventArgs e)
        {
            
            string outcomename = txtoutcomename.Text.Trim();
            var ocdate = dateTimePicker1.Value;
            string Price = txtPrice.Text.Trim();

            if (outcomename.Length == 0)
            { MessageBox.Show("Pleace insert outcome Name!");
                return;
            }
            if (ocdate.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Date is not valid!");
                return;
            }
            if (Price.Length>8)
            {
                MessageBox.Show("This number not valid!");
                return;
            }
            try
            {
                int a = int.Parse(Price);
            }
            catch (Exception)
            {
                MessageBox.Show("Pleace insert Valid price value!");
                return;

            }

            Outcome outcome = new Outcome
            {
                Amount = int.Parse(Price),
                Date = dateTimePicker1.Value,
                Name = outcomename
            };
            _context.Outcomes.Add(outcome);
           await _context.SaveChangesAsync();
            MessageBox.Show("Outcome info added successful!");
            Close();
        }
    }
}
