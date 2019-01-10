﻿namespace MeetingRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingRoomMain));
            this.flpRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            this.btnMeetingCancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_CreateAndDeleteRooms = new System.Windows.Forms.ToolStripButton();
            this.tsb_CreateAndDeleteCompanies = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpRooms
            // 
            this.flpRooms.Location = new System.Drawing.Point(16, 84);
            this.flpRooms.Margin = new System.Windows.Forms.Padding(4);
            this.flpRooms.Name = "flpRooms";
            this.flpRooms.Size = new System.Drawing.Size(635, 480);
            this.flpRooms.TabIndex = 0;
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.Location = new System.Drawing.Point(713, 15);
            this.btnCreateMeeting.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnMeetingCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeetingCancel.Name = "btnMeetingCancel";
            this.btnMeetingCancel.Size = new System.Drawing.Size(109, 48);
            this.btnMeetingCancel.TabIndex = 3;
            this.btnMeetingCancel.Text = "Rezervasyon İptal";
            this.btnMeetingCancel.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_CreateAndDeleteRooms,
            this.tsb_CreateAndDeleteCompanies});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_CreateAndDeleteRooms
            // 
            this.tsb_CreateAndDeleteRooms.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CreateAndDeleteRooms.Image")));
            this.tsb_CreateAndDeleteRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CreateAndDeleteRooms.Name = "tsb_CreateAndDeleteRooms";
            this.tsb_CreateAndDeleteRooms.Size = new System.Drawing.Size(114, 24);
            this.tsb_CreateAndDeleteRooms.Text = "Oda Ekle/Sil";
            this.tsb_CreateAndDeleteRooms.Click += new System.EventHandler(this.tsb_CreateAndDeleteRooms_Click);
            // 
            // tsb_CreateAndDeleteCompanies
            // 
            this.tsb_CreateAndDeleteCompanies.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CreateAndDeleteCompanies.Image")));
            this.tsb_CreateAndDeleteCompanies.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CreateAndDeleteCompanies.Name = "tsb_CreateAndDeleteCompanies";
            this.tsb_CreateAndDeleteCompanies.Size = new System.Drawing.Size(123, 24);
            this.tsb_CreateAndDeleteCompanies.Text = "Şirket Ekle/Sil";
            this.tsb_CreateAndDeleteCompanies.Click += new System.EventHandler(this.tsb_CreateAndDeleteCompanies_Click);
            // 
            // MeetingRoomMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 578);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnMeetingCancel);
            this.Controls.Add(this.btnCreateMeeting);
            this.Controls.Add(this.flpRooms);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeetingRoomMain";
            this.Text = "Toplantı Odası";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRooms;
        private System.Windows.Forms.Button btnCreateMeeting;
        private System.Windows.Forms.Button btnMeetingCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_CreateAndDeleteRooms;
        private System.Windows.Forms.ToolStripButton tsb_CreateAndDeleteCompanies;
    }
}

