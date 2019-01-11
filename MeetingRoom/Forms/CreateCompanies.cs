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
    public partial class CreateCompanies : Form
    {
        public CreateCompanies()
        {
            InitializeComponent();
        }

        private void btn_CreateCompany_Click(object sender, EventArgs e)
        {
            Companies company = new Companies();
            company.CompanyName = tb_CompanyName.Text;
            List<string> comp = new List<string>();
            foreach (var item in Program.db.Companies)
            {
                comp.Add(item.CompanyName);
            }
            if (comp.Contains(tb_CompanyName.Text))
                MessageBox.Show("Var olan bir firma eklediniz.");
            else
                Program.db.Companies.Add(company);
            Program.db.SaveChanges();
            tb_CompanyName.Clear();
            CreateCompanies_Load(sender, e);
        }

        private void CreateCompanies_Load(object sender, EventArgs e)
        {
            lb_Companies.DataSource = null;
            lb_Companies.DisplayMember = "CompanyName";
            lb_Companies.ValueMember = "CompanyID";
            lb_Companies.DataSource = Program.db.Companies.Select(x => new
            {
                x.CompanyName,
                x.CompanyID
            })
            .ToList();
        }

        private void btn_DeleteCompany_Click(object sender, EventArgs e)
        {
            Companies selectedCompany = (from r in Program.db.Companies
                                         where r.CompanyID == (int)lb_Companies.SelectedValue
                                         select r).SingleOrDefault();
            Program.db.Companies.Remove(selectedCompany);
            Program.db.SaveChanges();

            CreateCompanies_Load(sender, e);
        }
    }
}
