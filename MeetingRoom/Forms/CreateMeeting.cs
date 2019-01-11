﻿using System;
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
        public CreateMeeting()
        {
            InitializeComponent();
        }

        private void CreateMeeting_Load(object sender, EventArgs e)
        {
            GetCompanies();
            GetMeetingRooms();
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
            Program.db.Meetings.Add(newMeeting);
            Program.db.SaveChanges();
            MeetingRoomMain mrm = (MeetingRoomMain)Application.OpenForms["MeetingRoomMain"];
            mrm.Meetings();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            GetHours();
        }
        private void GetHours()
        {
            //var hourList = (from meeting in Program.db.Meetings
            //                join hour in Program.db.Hours
            //                on meeting.HourID equals hour.HourID
            //                select new
            //                {
            //                    hour.Hour,
            //                    hour.HourID
            //                }).ToList();
            var hourList = Program.db.Hours.Select(x => new
            {
                x.Hour,
                x.HourID
            }).ToList();

            foreach (var item in hourList)
            {
                RadioButton rbtn = new RadioButton();
                rbtn.Margin = new Padding(1);
                rbtn.Width = 70;
                rbtn.Font = new Font("Georgia", 10);
                //rbtn.Text = ((DateTime)item.Hour).ToString("HH:mm");
                flpHours.Controls.Add(rbtn);
            }
        }
    }
}
