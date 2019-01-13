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
    public partial class CancelMeeting : Form
    {
        public CancelMeeting()
        {
            InitializeComponent();
        }

        private void CancelMeeting_Load(object sender, EventArgs e)
        {
            GetCompaniesForDGV();
            SetDGVDisplay();
            SetLabels();
        }

        private void dgvMeetings_SelectionChanged(object sender, EventArgs e)
        {
            SetLabels();
        }

        private void GetCompaniesForDGV()
        {
            dgvMeetings.DataSource = null;
            dgvMeetings.DataSource = Program.db.Meetings
                .Select(x => new
                {
                    ID = x.MeetingID,
                    Tarih = x.Date,
                    Saat = x.Hour,
                    Şirket_Adı = x.Companies.CompanyName,
                    Oda = x.MeetingRooms.RoomName,
                })
                .ToList();
        }

        private void SetDGVDisplay()
        {
            dgvMeetings.RowHeadersWidth = 20;

            foreach (DataGridViewColumn item in dgvMeetings.Columns)
            {
                item.Width = 80;
            }
            dgvMeetings.Columns[0].Visible = false;
        }

        private void SetLabels()
        {
            if (!(dgvMeetings.SelectedRows is null))
            {
                foreach (DataGridViewRow row in dgvMeetings.SelectedRows)
                {
                    lblCompanyName.Text = row.Cells["Şirket_Adı"].Value.ToString();
                    lblDate.Text = ((DateTime)row.Cells["Tarih"].Value).ToString("dd.MM.yyy");
                    lblHour.Text = row.Cells["Saat"].Value.ToString() + ":00";
                    lblRoom.Text = row.Cells["Oda"].Value.ToString();
                }
            }
            else
            {
                lblCompanyName.Text = "";
                lblDate.Text = "";
                lblHour.Text = "";
                lblRoom.Text = "";
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvMeetings.SelectedRows)
            {
                int selectedID = (int)item.Cells["ID"].Value;
                Meetings selectedMeeting = (from r in Program.db.Meetings
                                            where r.MeetingID == selectedID
                                            select r).SingleOrDefault();
                Program.db.Meetings.Remove(selectedMeeting);
                Program.db.SaveChanges();

                GetCompaniesForDGV();
                SetLabels();

                MeetingRoomMain mrm = (MeetingRoomMain)Application.OpenForms["MeetingRoomMain"];
                mrm.Meetings();
            }
        }
    }
}
