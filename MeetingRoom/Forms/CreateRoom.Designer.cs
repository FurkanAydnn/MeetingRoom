namespace MeetingRoom.Forms
{
    partial class CreateRoom
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
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.tb_RoomName = new System.Windows.Forms.TextBox();
            this.btn_RoomAdd = new System.Windows.Forms.Button();
            this.lb_Rooms = new System.Windows.Forms.ListBox();
            this.btn_DeleteRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(32, 28);
            this.lbl_RoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(63, 17);
            this.lbl_RoomName.TabIndex = 0;
            this.lbl_RoomName.Text = "Oda Adı:";
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Location = new System.Drawing.Point(129, 28);
            this.tb_RoomName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(185, 22);
            this.tb_RoomName.TabIndex = 1;
            // 
            // btn_RoomAdd
            // 
            this.btn_RoomAdd.Location = new System.Drawing.Point(249, 60);
            this.btn_RoomAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RoomAdd.Name = "btn_RoomAdd";
            this.btn_RoomAdd.Size = new System.Drawing.Size(67, 28);
            this.btn_RoomAdd.TabIndex = 2;
            this.btn_RoomAdd.Text = "Ekle";
            this.btn_RoomAdd.UseVisualStyleBackColor = true;
            this.btn_RoomAdd.Click += new System.EventHandler(this.btn_RoomAdd_Click);
            // 
            // lb_Rooms
            // 
            this.lb_Rooms.FormattingEnabled = true;
            this.lb_Rooms.ItemHeight = 16;
            this.lb_Rooms.Location = new System.Drawing.Point(0, 112);
            this.lb_Rooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_Rooms.Name = "lb_Rooms";
            this.lb_Rooms.Size = new System.Drawing.Size(345, 196);
            this.lb_Rooms.TabIndex = 3;
            // 
            // btn_DeleteRoom
            // 
            this.btn_DeleteRoom.Location = new System.Drawing.Point(249, 316);
            this.btn_DeleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DeleteRoom.Name = "btn_DeleteRoom";
            this.btn_DeleteRoom.Size = new System.Drawing.Size(67, 28);
            this.btn_DeleteRoom.TabIndex = 4;
            this.btn_DeleteRoom.Text = "Sil";
            this.btn_DeleteRoom.UseVisualStyleBackColor = true;
            this.btn_DeleteRoom.Click += new System.EventHandler(this.btn_DeleteRoom_Click);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.btn_DeleteRoom);
            this.Controls.Add(this.lb_Rooms);
            this.Controls.Add(this.btn_RoomAdd);
            this.Controls.Add(this.tb_RoomName);
            this.Controls.Add(this.lbl_RoomName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.Load += new System.EventHandler(this.CreateRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.Button btn_RoomAdd;
        private System.Windows.Forms.ListBox lb_Rooms;
        private System.Windows.Forms.Button btn_DeleteRoom;
    }
}