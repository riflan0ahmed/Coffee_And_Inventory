using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_And_Inventory
{
    public partial class ucDashboardAdmin : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboardAdmin()
        {
            InitializeComponent();
        }

        private void mtAdmin_Account_Click(object sender, EventArgs e)
        {
            if (!frmAdmin.InstanceAdmin.MetroContainer.Controls.ContainsKey("ucDashboardAdmin_accounts"))
            {
                ucDashboardAdmin_accounts uc = new ucDashboardAdmin_accounts();
                uc.Dock = DockStyle.Fill;
                frmAdmin.InstanceAdmin.MetroContainer.Controls.Add(uc);
            }
            frmAdmin.InstanceAdmin.MetroContainer.Controls["ucDashboardAdmin_accounts"].BringToFront();
            frmAdmin.InstanceAdmin.MetroBack.Visible = true;
        }

        private void mtAdmin_Employee_Click(object sender, EventArgs e)
        {
            if (!frmAdmin.InstanceAdmin.MetroContainer.Controls.ContainsKey("ucDashboardAdmin_employee"))
            {
                ucDashboardAdmin_employee uc = new ucDashboardAdmin_employee();
                uc.Dock = DockStyle.Fill;
                frmAdmin.InstanceAdmin.MetroContainer.Controls.Add(uc);
            }
            frmAdmin.InstanceAdmin.MetroContainer.Controls["ucDashboardAdmin_employee"].BringToFront();
            frmAdmin.InstanceAdmin.MetroBack.Visible = true;
        }

        private void mtAdmin_Inventory_Click(object sender, EventArgs e)
        {
            if (!frmAdmin.InstanceAdmin.MetroContainer.Controls.ContainsKey("ucDashboardAdmin_inventory"))
            {
                ucDashboardAdmin_inventory uc = new ucDashboardAdmin_inventory();
                uc.Dock = DockStyle.Fill;
                frmAdmin.InstanceAdmin.MetroContainer.Controls.Add(uc);
            }
            frmAdmin.InstanceAdmin.MetroContainer.Controls["ucDashboardAdmin_inventory"].BringToFront();
            frmAdmin.InstanceAdmin.MetroBack.Visible = true;
        }

        private void mtAdmin_Sales_Click(object sender, EventArgs e)
        {
            if (!frmAdmin.InstanceAdmin.MetroContainer.Controls.ContainsKey("ucDashboardAdmin_sales"))
            {
                ucDashboardAdmin_sales uc = new ucDashboardAdmin_sales();
                uc.Dock = DockStyle.Fill;
                frmAdmin.InstanceAdmin.MetroContainer.Controls.Add(uc);
            }
            frmAdmin.InstanceAdmin.MetroContainer.Controls["ucDashboardAdmin_sales"].BringToFront();
            frmAdmin.InstanceAdmin.MetroBack.Visible = true;
        }

        private void mtAdmin_Delivery_Click(object sender, EventArgs e)
        {
            if (!frmAdmin.InstanceAdmin.MetroContainer.Controls.ContainsKey("ucDashboardAdmin_delivery"))
            {
                ucDashboardAdmin_delivery uc = new ucDashboardAdmin_delivery();
                uc.Dock = DockStyle.Fill;
                frmAdmin.InstanceAdmin.MetroContainer.Controls.Add(uc);
            }
            frmAdmin.InstanceAdmin.MetroContainer.Controls["ucDashboardAdmin_delivery"].BringToFront();
            frmAdmin.InstanceAdmin.MetroBack.Visible = true;
        }
    }
}
