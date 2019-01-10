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

        MeetingRoomDBEntities db = new MeetingRoomDBEntities();
        private void btn_RoomAdd_Click(object sender, EventArgs e)
        {
            MeetingRooms meetingRooms = new MeetingRooms();
            meetingRooms.RoomName = tb_RoomName.Text;
            db.MeetingRooms.Add(meetingRooms);
            db.SaveChanges();
            tb_RoomName.Clear();
            CreateRoom_Load(sender, e);
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            lb_Rooms.DataSource = null;
            lb_Rooms.DisplayMember = "RoomName";
            lb_Rooms.ValueMember = "RoomID";
            lb_Rooms.DataSource = db.MeetingRooms.Select(x => new
            {
                x.RoomName,
                x.RoomID
            })
            .ToList();
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            var room = (from r in db.MeetingRooms
                        where r.RoomID == (int)lb_Rooms.SelectedValue
                        select r).SingleOrDefault();
            db.MeetingRooms.Remove(room);
            db.SaveChanges();

            CreateRoom_Load(sender, e);
        }
    }
}
