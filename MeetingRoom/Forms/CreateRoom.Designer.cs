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
            this.SuspendLayout();
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(24, 36);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(48, 13);
            this.lbl_RoomName.TabIndex = 0;
            this.lbl_RoomName.Text = "Oda Adı:";
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Location = new System.Drawing.Point(97, 36);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(140, 20);
            this.tb_RoomName.TabIndex = 1;
            // 
            // btn_RoomAdd
            // 
            this.btn_RoomAdd.Location = new System.Drawing.Point(162, 113);
            this.btn_RoomAdd.Name = "btn_RoomAdd";
            this.btn_RoomAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_RoomAdd.TabIndex = 2;
            this.btn_RoomAdd.Text = "Ekle";
            this.btn_RoomAdd.UseVisualStyleBackColor = true;
            // 
            // CreateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.btn_RoomAdd);
            this.Controls.Add(this.tb_RoomName);
            this.Controls.Add(this.lbl_RoomName);
            this.Name = "CreateRoom";
            this.Text = "CreateRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomName;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.Button btn_RoomAdd;
    }
}