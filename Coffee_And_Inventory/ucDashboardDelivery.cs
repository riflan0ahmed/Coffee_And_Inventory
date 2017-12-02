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
    public partial class ucDashboardDelivery : UserControl
    {
        public ucDashboardDelivery()
        {
            InitializeComponent();
        }

        private void ucDashboardDelivery_Load(object sender, EventArgs e)
        {

        }

        private void mtDelivery_delivery_Click(object sender, EventArgs e)
        {
            if (!frmDelivery.InstanceDelivery.MetroContainer.Controls.ContainsKey("ucDashboardDelivery_delivery"))
            {
                ucDashboardDelivery_delivery uc = new ucDashboardDelivery_delivery();
                uc.Dock = DockStyle.Fill;
                frmDelivery.InstanceDelivery.MetroContainer.Controls.Add(uc);
            }
            frmDelivery.InstanceDelivery.MetroContainer.Controls["ucDashboardDelivery_delivery"].BringToFront();
            frmDelivery.InstanceDelivery.MetroBack.Visible = true;
        }
    }
}
