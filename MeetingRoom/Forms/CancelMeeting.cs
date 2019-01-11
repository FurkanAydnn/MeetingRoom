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
                    Tarih =x.Date,
                    Şirket_Adı =x.Companies.CompanyName,
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
        }

        private void SetLabels()
        {
            foreach (DataGridViewRow row in dgvMeetings.SelectedRows)
            {
                lblCompanyName.Text = row.Cells[1].Value.ToString();
                lblDate.Text = ((DateTime)row.Cells[0].Value).ToString("dd.MM.yyy");
                lblHour.Text = "";
                lblRoom.Text = row.Cells[2].Value.ToString();
            }

        }
    }
}
