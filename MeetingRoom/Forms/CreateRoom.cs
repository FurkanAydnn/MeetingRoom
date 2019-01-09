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
            CreateRoom_Load(sender, e);
        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            dgv_Rooms.DataSource = null;
            dgv_Rooms.DataSource = db.MeetingRooms.Select(x => new
            {
                OdaId = x.RoomID,
                OdaAdı = x.RoomName   
            })
            .ToList();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MeetingRoomMain f = new MeetingRoomMain();
            f.Show();
            this.Close();
        }

        private void CreateRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
