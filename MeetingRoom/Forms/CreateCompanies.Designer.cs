namespace MeetingRoom.Forms
{
    partial class CreateCompanies
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
            this.btn_DeleteCompany = new System.Windows.Forms.Button();
            this.lb_Companies = new System.Windows.Forms.ListBox();
            this.btn_CreateCompany = new System.Windows.Forms.Button();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.lbl_RoomName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DeleteCompany
            // 
            this.btn_DeleteCompany.Location = new System.Drawing.Point(242, 308);
            this.btn_DeleteCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteCompany.Name = "btn_DeleteCompany";
            this.btn_DeleteCompany.Size = new System.Drawing.Size(67, 28);
            this.btn_DeleteCompany.TabIndex = 9;
            this.btn_DeleteCompany.Text = "Sil";
            this.btn_DeleteCompany.UseVisualStyleBackColor = true;
            this.btn_DeleteCompany.Click += new System.EventHandler(this.btn_DeleteCompany_Click);
            // 
            // lb_Companies
            // 
            this.lb_Companies.FormattingEnabled = true;
            this.lb_Companies.ItemHeight = 16;
            this.lb_Companies.Location = new System.Drawing.Point(-3, 104);
            this.lb_Companies.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Companies.Name = "lb_Companies";
            this.lb_Companies.Size = new System.Drawing.Size(344, 196);
            this.lb_Companies.TabIndex = 8;
            // 
            // btn_CreateCompany
            // 
            this.btn_CreateCompany.Location = new System.Drawing.Point(242, 52);
            this.btn_CreateCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CreateCompany.Name = "btn_CreateCompany";
            this.btn_CreateCompany.Size = new System.Drawing.Size(67, 28);
            this.btn_CreateCompany.TabIndex = 7;
            this.btn_CreateCompany.Text = "Ekle";
            this.btn_CreateCompany.UseVisualStyleBackColor = true;
            this.btn_CreateCompany.Click += new System.EventHandler(this.btn_CreateCompany_Click);
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Location = new System.Drawing.Point(122, 20);
            this.tb_CompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(185, 22);
            this.tb_CompanyName.TabIndex = 6;
            // 
            // lbl_RoomName
            // 
            this.lbl_RoomName.AutoSize = true;
            this.lbl_RoomName.Location = new System.Drawing.Point(25, 20);
            this.lbl_RoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RoomName.Name = "lbl_RoomName";
            this.lbl_RoomName.Size = new System.Drawing.Size(72, 17);
            this.lbl_RoomName.TabIndex = 5;
            this.lbl_RoomName.Text = "Şirket Adı:";
            // 
            // CreateCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.btn_DeleteCompany);
            this.Controls.Add(this.lb_Companies);
            this.Controls.Add(this.btn_CreateCompany);
            this.Controls.Add(this.tb_CompanyName);
            this.Controls.Add(this.lbl_RoomName);
            this.Name = "CreateCompanies";
            this.Text = "CreateCompanies";
            this.Load += new System.EventHandler(this.CreateCompanies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteCompany;
        private System.Windows.Forms.ListBox lb_Companies;
        private System.Windows.Forms.Button btn_CreateCompany;
        private System.Windows.Forms.TextBox tb_CompanyName;
        private System.Windows.Forms.Label lbl_RoomName;
    }
}