using MeetingRoom.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingRoom
{
    public partial class MeetingRoomMain : Form
    {
        public MeetingRoomMain()
        {
            InitializeComponent();
        }

        private void tsb_CreateAndDeleteRooms_Click(object sender, EventArgs e)
        {
            CreateRoom form = new CreateRoom();
            form.Show();
        }

        private void tsb_CreateAndDeleteCompanies_Click(object sender, EventArgs e)
        {
            CreateCompanies form = new CreateCompanies();
            form.Show();
        }
        
        private void tsb_CreateMeeting_Click(object sender, EventArgs e)
        {
            new CreateMeeting().Show();
        }

        private void tsb_CancelMeeting_Click(object sender, EventArgs e)
        {
            new CancelMeeting().Show();
        }
    }
}
