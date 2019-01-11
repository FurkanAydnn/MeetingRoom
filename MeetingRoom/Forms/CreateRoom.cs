using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingRoom.Forms
{
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void btn_RoomAdd_Click(object sender, EventArgs e)
        {
            MeetingRooms meetingRooms = new MeetingRooms();
            meetingRooms.RoomName = tb_RoomName.Text;
            List<string> rooms = new List<string>();
            foreach (var item in Program.db.MeetingRooms)
            {
                rooms.Add(item.RoomName);
            }

            if ((rooms.Contains(tb_RoomName.Text)))
                MessageBox.Show("Var olan bir oda eklediniz.");
            else
                Program.db.MeetingRooms.Add(meetingRooms);
            Program.db.SaveChanges();
            tb_RoomName.Clear();
            CreateRoom_Load(sender, e);
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            lb_Rooms.DataSource = null;
            lb_Rooms.DisplayMember = "RoomName";
            lb_Rooms.ValueMember = "RoomID";
            lb_Rooms.DataSource = Program.db.MeetingRooms.Select(x => new
            {
                x.RoomName,
                x.RoomID
            })
            .ToList();
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            MeetingRooms selectedRoom = (from r in Program.db.MeetingRooms
                                         where r.RoomID == (int)lb_Rooms.SelectedValue
                                         select r).SingleOrDefault();
            Program.db.MeetingRooms.Remove(selectedRoom);
            Program.db.SaveChanges();

            CreateRoom_Load(sender, e);
        }
    }
}
