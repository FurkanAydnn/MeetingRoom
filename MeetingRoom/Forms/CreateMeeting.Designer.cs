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
            this.dtpMeetingDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpMeetingDate
            // 
            this.dtpMeetingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMeetingDate.Location = new System.Drawing.Point(148, 12);
            this.dtpMeetingDate.Name = "dtpMeetingDate";
            this.dtpMeetingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMeetingDate.TabIndex = 0;
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 346);
            this.Controls.Add(this.dtpMeetingDate);
            this.Name = "CreateMeeting";
            this.Text = "Rezervasyon Oluştur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMeetingDate;
    }
}