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
            this.dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(32, 44);
            this.lbl_RoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(63, 17);
            this.lbl_RoomName.TabIndex = 0;
            this.lbl_RoomName.Text = "Oda Adı:";
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Location = new System.Drawing.Point(129, 44);
            this.tb_RoomName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(185, 22);
            this.tb_RoomName.TabIndex = 1;
            // 
            // btn_RoomAdd
            // 
            this.btn_RoomAdd.Location = new System.Drawing.Point(214, 74);
            this.btn_RoomAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RoomAdd.Name = "btn_RoomAdd";
            this.btn_RoomAdd.Size = new System.Drawing.Size(100, 28);
            this.btn_RoomAdd.TabIndex = 2;
            this.btn_RoomAdd.Text = "Ekle";
            this.btn_RoomAdd.UseVisualStyleBackColor = true;
            this.btn_RoomAdd.Click += new System.EventHandler(this.btn_RoomAdd_Click);
            // 
            // dgv_Rooms
            // 
            this.dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Rooms.Location = new System.Drawing.Point(0, 129);
            this.dgv_Rooms.Name = "dgv_Rooms";
            this.dgv_Rooms.RowTemplate.Height = 24;
            this.dgv_Rooms.Size = new System.Drawing.Size(342, 205);
            this.dgv_Rooms.TabIndex = 3;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(60, 25);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Geri";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 334);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_Rooms);
            this.Controls.Add(this.btn_RoomAdd);
            this.Controls.Add(this.tb_RoomName);
            this.Controls.Add(this.lbl_RoomName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateRoom_FormClosed);
            this.Load += new System.EventHandler(this.CreateRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.Button btn_RoomAdd;
        private System.Windows.Forms.DataGridView dgv_Rooms;
        private System.Windows.Forms.Button btn_Back;
    }
}