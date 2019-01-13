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

        int now = DateTime.Now.Hour;

        private void MeetingRoomMain_Load(object sender, EventArgs e)
        {
            Meetings();
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

        public void Meetings()
        {
            flpRooms.Controls.Clear();
            foreach (var room in Program.db.MeetingRooms)
            {
                Button b = new Button();
                b.Height = 100;
                b.Width = 130;
                bool isThereMeeting = CheckMeeting(room.RoomName);
                var meeting = Program.db.Meetings
                    .Where(x => x.MeetingRoomID == room.RoomID && (x.Hour == now || x.Hour == now - 1))
                    .FirstOrDefault();
                if (isThereMeeting)
                {
                    b.Text = room.RoomName;
                    b.Text += SetButtonText(meeting);
                    b.Name = meeting.MeetingID.ToString();
                }
                else
                    b.Text = room.RoomName + "\n Oda Boş";
                flpRooms.Controls.Add(b);
                b.Click += new EventHandler(b_Click);
            }
        }

        private bool CheckMeeting(string roomName)
        {
            List<Meetings> AllMeetings = Program.db.Meetings
                .Where(x => (x.Hour == now || x.Hour == now - 1) && x.Date == DateTime.Today && x.MeetingRooms.RoomName == roomName)
                .ToList();
            if (AllMeetings.Count > 0)
                return true;
            else
                return false;
        }

        private void b_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name != "")
            {
                int selectedID = Convert.ToInt32(button.Name);

                Meetings MeetingOnButton = Program.db.Meetings
                    .Where(x => x.MeetingID == selectedID)
                    .FirstOrDefault();
                MessageBox.Show(MeetingOnButton.Description);
            }
        }

        private string SetButtonText(Meetings meeting)
        {
            string buttonText = Environment.NewLine;
            buttonText += meeting.Companies.CompanyName;
            buttonText += Environment.NewLine;
            buttonText += meeting.Date.ToShortDateString();
            buttonText += Environment.NewLine;
            buttonText += meeting.Hour + ":00" + " - " + (meeting.Hour + 2) + ":00";
            return buttonText;
        }
    }
}
