namespace MeetingRoom
{
    partial class MeetingRoomMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            this.btnMeetingCancel = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpRooms
            // 
            this.flpRooms.Location = new System.Drawing.Point(16, 84);
            this.flpRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpRooms.Name = "flpRooms";
            this.flpRooms.Size = new System.Drawing.Size(635, 480);
            this.flpRooms.TabIndex = 0;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(17, 16);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(109, 48);
            this.btnCreateRoom.TabIndex = 1;
            this.btnCreateRoom.Text = "Yeni Oda";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.Location = new System.Drawing.Point(713, 15);
            this.btnCreateMeeting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateMeeting.Name = "btnCreateMeeting";
            this.btnCreateMeeting.Size = new System.Drawing.Size(109, 48);
            this.btnCreateMeeting.TabIndex = 2;
            this.btnCreateMeeting.Text = "Rezervasyon";
            this.btnCreateMeeting.UseVisualStyleBackColor = true;
            this.btnCreateMeeting.Click += new System.EventHandler(this.btnCreateMeeting_Click);
            // 
            // btnMeetingCancel
            // 
            this.btnMeetingCancel.Location = new System.Drawing.Point(713, 70);
            this.btnMeetingCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMeetingCancel.Name = "btnMeetingCancel";
            this.btnMeetingCancel.Size = new System.Drawing.Size(109, 48);
            this.btnMeetingCancel.TabIndex = 3;
            this.btnMeetingCancel.Text = "Rezervasyon İptal";
            this.btnMeetingCancel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(713, 516);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(109, 48);
            this.btnDeleteRoom.TabIndex = 4;
            this.btnDeleteRoom.Text = "Oda Sil";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // MeetingRoomMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 578);
            this.Controls.Add(this.btnDeleteRoom);
            this.Controls.Add(this.btnMeetingCancel);
            this.Controls.Add(this.btnCreateMeeting);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.flpRooms);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MeetingRoomMain";
            this.Text = "Toplantı Odası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRooms;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Button btnCreateMeeting;
        private System.Windows.Forms.Button btnMeetingCancel;
        private System.Windows.Forms.Button btnDeleteRoom;
    }
}

