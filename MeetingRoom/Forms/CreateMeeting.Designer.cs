namespace MeetingRoom.Forms
{
    partial class CreateMeeting
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpHours = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            this.cbMeetingRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(311, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(108, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(103, 67);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(142, 96);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // cbCompanies
            // 
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(103, 13);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(142, 21);
            this.cbCompanies.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şirket Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplantı Tanımı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpHours);
            this.groupBox1.Location = new System.Drawing.Point(274, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saat: ";
            // 
            // flpHours
            // 
            this.flpHours.AutoScroll = true;
            this.flpHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHours.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpHours.Location = new System.Drawing.Point(3, 16);
            this.flpHours.Margin = new System.Windows.Forms.Padding(1);
            this.flpHours.Name = "flpHours";
            this.flpHours.Size = new System.Drawing.Size(147, 105);
            this.flpHours.TabIndex = 0;
            this.flpHours.WrapContents = false;
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.Location = new System.Drawing.Point(352, 170);
            this.btnCreateMeeting.Name = "btnCreateMeeting";
            this.btnCreateMeeting.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMeeting.TabIndex = 10;
            this.btnCreateMeeting.Text = "Kaydet";
            this.btnCreateMeeting.UseVisualStyleBackColor = true;
            this.btnCreateMeeting.Click += new System.EventHandler(this.btnCreateMeeting_Click);
            // 
            // cbMeetingRoom
            // 
            this.cbMeetingRoom.FormattingEnabled = true;
            this.cbMeetingRoom.Location = new System.Drawing.Point(103, 40);
            this.cbMeetingRoom.Name = "cbMeetingRoom";
            this.cbMeetingRoom.Size = new System.Drawing.Size(142, 21);
            this.cbMeetingRoom.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Toplantı Odası: ";
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 208);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMeetingRoom);
            this.Controls.Add(this.btnCreateMeeting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.dtpDate);
            this.Name = "CreateMeeting";
            this.Text = "Rezervasyon Oluştur";
            this.Load += new System.EventHandler(this.CreateMeeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.ComboBox cbCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateMeeting;
        private System.Windows.Forms.ComboBox cbMeetingRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpHours;
    }
}