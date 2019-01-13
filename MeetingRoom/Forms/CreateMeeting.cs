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
    public partial class CreateMeeting : Form
    {
        public enum Hours
        {
            h1 = 8,
            h2 = 10,
            h3 = 12,
            h4 = 14,
            h5 = 16
        }

        public CreateMeeting()
        {
            InitializeComponent();
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            GetCompanies();
            GetMeetingRooms();
            GetHours();
            dtpDate_ValueChanged(sender, e);
        }

        private void GetMeetingRooms()
        {
            cbMeetingRoom.DisplayMember = "RoomName";
            cbMeetingRoom.ValueMember = "RoomID";
            List<MeetingRooms> MeetingRoomsForCB = new List<MeetingRooms>();
            MeetingRooms m = new MeetingRooms() { RoomName = " Bir toplantı odası seçiniz" };
            MeetingRoomsForCB = Program.db.MeetingRooms.ToList();
            MeetingRoomsForCB.Insert(0, m);
            cbMeetingRoom.DataSource = MeetingRoomsForCB;
        }

        private void GetCompanies()
        {
            cbCompanies.DisplayMember = "CompanyName";
            cbCompanies.ValueMember = "CompanyID";
            List<Companies> CompaniesForCB = new List<Companies>();
            Companies c = new Companies() { CompanyName = "Şirket Seçiniz" };
            CompaniesForCB = Program.db.Companies.ToList();
            CompaniesForCB.Insert(0, c);
            cbCompanies.DataSource = CompaniesForCB;
        }

        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            Meetings newMeeting = new Meetings();
            newMeeting.CompanyID = (int)cbCompanies.SelectedValue;
            newMeeting.Date = dtpDate.Value;
            newMeeting.Description = rtbDescription.Text;
            newMeeting.MeetingRoomID = (int)cbMeetingRoom.SelectedValue;
            newMeeting.Hour = GetSelectedRbtn();
            Program.db.Meetings.Add(newMeeting);
            Program.db.SaveChanges();
            MeetingRoomMain mrm = (MeetingRoomMain)Application.OpenForms["MeetingRoomMain"];
            mrm.Meetings();
        }

        private int GetSelectedRbtn()
        {
            int selectedHour = 0;
            foreach (RadioButton rbtn in flpHours.Controls)
            {
                if (rbtn.Checked)
                    selectedHour = Convert.ToInt32(rbtn.Text.Replace(":00", ""));
            }
            return selectedHour;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            List<Meetings> MeetinsgAtDate = Program.db.Meetings
                .Where(x => x.Date == dtpDate.Value.Date)
                .ToList();
            if (MeetinsgAtDate.Count != 0)
            {
                foreach (Meetings meeting in MeetinsgAtDate)
                {
                    foreach (RadioButton rbtn in flpHours.Controls)
                    {
                        if (meeting.Hour.ToString() == rbtn.Text.Replace(":00", ""))
                            rbtn.Visible = false;
                    }
                }
            }
            else
            {
                foreach (RadioButton rbtn in flpHours.Controls)
                {
                    rbtn.Visible = true;
                }
            }
        }

        public void GetHours()
        {
            foreach (int hour in Enum.GetValues(typeof(Hours)))
            {
                RadioButton rbtn = new RadioButton();
                rbtn.Text = hour.ToString() + ":00";
                flpHours.Controls.Add(rbtn);
            }
        }
    }
}
