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

        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            new CreateMeeting().Show();
        }
    }
}
