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
    public partial class AddRomOrBrone : Form
    {
        HostelEntities _context;
        public AddRomOrBrone()
        {
            InitializeComponent();
            _context = new HostelEntities();
        }

        private async void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomname = txtnewroomname.Text.Trim();
            var roomnumber = numericUpDown1.Value;
            var isDelete = false;
            Room room = _context.Rooms.FirstOrDefault(r => r.Name.ToLower() == roomname.ToLower());
            if (roomname.Length ==0 || roomnumber == 0)
            {
                MessageBox.Show("Pleace insert room Name or Room Number");
                return;
            }
            if (room!=null)
            {
                MessageBox.Show("This Roomname already assigned!Pleace edit name...","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            Room roomnum = _context.Rooms.FirstOrDefault(r=>r.Number == roomnumber);
            if (roomnum != null)
            {
                MessageBox.Show("This Number already assigned!Pleace edit number...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Room roomadd = new Room {

                Name = roomname,
                isDeleted = isDelete,
                Number = (int)roomnumber,
            };
            _context.Rooms.Add(roomadd);
            await _context.SaveChangesAsync();
            MessageBox.Show("Room added succesful!");
            Close();
        }

        private void AddBed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void txtRoomId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBedsort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numBednum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numBedPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnAddBed_Click(object sender, EventArgs e)
        {
            string _bedsort = cmbBedsort.SelectedItem.ToString();
            var _bedprice = txtBedPrice.Text.Trim();
            var _bednumber = numBednum.Value;
            var _isDelete = false;
            try
            {
                decimal a =decimal.Parse(_bedprice);
            }
            catch (Exception)
            {
                MessageBox.Show("Pleace insert valid price value","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (_bednumber == 0)
            {
                MessageBox.Show("Pleace insert Bed number!");
                return;
            }
            
            Room room = _context.Rooms.FirstOrDefault(r=>r.Name.ToLower() == txtRoomId.Text.Trim().ToLower());
            if (room == null)
            {
                MessageBox.Show("This Room is not Registeren...Pleace insert correct room name");
                return;
            }
            Bed bedmum = _context.Beds.FirstOrDefault(b => b.Number == _bednumber);
            if (bedmum != null && bedmum.RoomID ==room.ID)
            {
                MessageBox.Show("This Bednumber already assigned.Pleace change numrer value!");
                return;
            }
            
            Bed bed = new Bed {
                RoomID = room.ID,
                isDeleted = _isDelete,
                Number =(int)_bednumber,
                Price= Convert.ToDecimal(_bedprice),
                Sort = _bedsort,
            };
            _context.Beds.Add(bed);
           await  _context.SaveChangesAsync();
            MessageBox.Show($"Bed successful added to {room.Name}");
            Close();
        }

        private void AddRomOrBrone_Load(object sender, EventArgs e)
        {
            cmbBedsort.Text = "simple";
        }
    }
}
