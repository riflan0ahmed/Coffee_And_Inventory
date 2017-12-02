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
    public partial class ucDashboardfrmMain : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboardfrmMain()
        {
            InitializeComponent();
        }

        private void mtAdmin_Click(object sender, EventArgs e)
        {

            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucAccounts_admin"))
            {
                ucAccounts_admin uc = new ucAccounts_admin();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucAccounts_admin"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            timerDashboard.Start();
        }

        private void mtSales_Click(object sender, EventArgs e)
        {
            if(!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucAccount_sales"))
            {
                ucAccount_sales uc = new ucAccount_sales();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucAccount_sales"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mtInventory_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucAccount_inventory"))
            {
                ucAccount_inventory uc = new ucAccount_inventory();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucAccount_inventory"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mtDelivery_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucAccounts_delivery"))
            {
                ucAccounts_delivery uc = new ucAccounts_delivery();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucAccounts_delivery"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            if (mtAdmin.BackColor == Color.LightGray)
            {
                mtAdmin.Text = "Student";
                mtAdmin.BackColor = Color.LightCoral;
                mtAdmin.UseTileImage = false;
            }
            else if (mtAdmin.BackColor == Color.LightCoral)
            {
                mtAdmin.Text = "Student";
                mtAdmin.BackColor = Color.LightSalmon;
                mtAdmin.UseTileImage = true;
                mtAdmin.Refresh();
            }

            else if (mtAdmin.BackColor == Color.LightSalmon)
            {
                mtAdmin.Text = "Student";
                mtAdmin.BackColor = Color.LightGreen;
                mtAdmin.UseTileImage = true;
                mtAdmin.Refresh();
            }
            
            else if (mtAdmin.BackColor == Color.LightGreen)
            {
                mtAdmin.Text = "Student";
                mtAdmin.BackColor = Color.LightPink;
                mtAdmin.UseTileImage = true;
                mtAdmin.Refresh();
            }
            
            else if (mtAdmin.BackColor == Color.LightPink)
            {
                mtAdmin.Text = "Student";
                mtAdmin.BackColor = Color.LightSteelBlue;
                mtAdmin.UseTileImage = true;
                mtAdmin.Refresh();
            }

            else
            {
                mtAdmin.Text = "Student";
                mtAdmin.BackColor = Color.LightGray;
                mtAdmin.UseTileImage = true;
                mtAdmin.Refresh();
            }

            
            //------------INventory color change---------------------------------
            if (mtInventory.BackColor == Color.DarkKhaki)
            {
                mtInventory.Text = "Student";
                mtInventory.BackColor = Color.DeepSkyBlue;
                mtInventory.UseTileImage = false;
            }
            else if (mtInventory.BackColor == Color.DeepSkyBlue)
            {
                mtInventory.Text = "Student";
                mtInventory.BackColor = Color.Wheat;
                mtInventory.UseTileImage = true;
                mtInventory.Refresh();
            }

            else if (mtInventory.BackColor == Color.Wheat)
            {
                mtInventory.Text = "Student";
                mtInventory.BackColor = Color.Tomato;
                mtInventory.UseTileImage = true;
                mtInventory.Refresh();
            }

            else if (mtInventory.BackColor == Color.Tomato)
            {
                mtInventory.Text = "Student";
                mtInventory.BackColor = Color.BlueViolet;
                mtInventory.UseTileImage = true;
                mtInventory.Refresh();
            }

            else if (mtInventory.BackColor == Color.BlueViolet)
            {
                mtInventory.Text = "Student";
                mtInventory.BackColor = Color.Coral;
                mtInventory.UseTileImage = true;
                mtInventory.Refresh();
            }
            
            else
            {
                mtInventory.Text = "Student";
                mtInventory.BackColor = Color.DarkKhaki;
                mtInventory.UseTileImage = true;
                mtInventory.Refresh();
            }
            
            
            //--------------------Sales color change-------------------------------------------
            if (mtSales.BackColor == Color.Plum)
            {
                mtSales.Text = "Teacher";
                mtSales.BackColor = Color.LightSeaGreen;
                mtSales.UseTileImage = false;
            }
            else if (mtSales.BackColor == Color.LightSeaGreen)
            {
                mtSales.Text = "Teacher";
                mtSales.BackColor = Color.IndianRed;
                mtSales.UseTileImage = true;
                mtSales.Refresh();
            }

            else if (mtSales.BackColor == Color.IndianRed)
            {
                mtSales.Text = "Teacher";
                mtSales.BackColor = Color.MediumPurple;
                mtSales.UseTileImage = true;
                mtSales.Refresh();
            }

            else if (mtSales.BackColor == Color.MediumPurple)
            {
                mtSales.Text = "Teacher";
                mtSales.BackColor = Color.MediumAquamarine;
                mtSales.UseTileImage = true;
                mtSales.Refresh();
            }

            else if (mtSales.BackColor == Color.MediumAquamarine)
            {
                mtSales.Text = "Teacher";
                mtSales.BackColor = Color.PaleGoldenrod;
                mtSales.UseTileImage = true;
                mtSales.Refresh();
            }

            else
            {
                mtSales.Text = "Teacher";
                mtSales.BackColor = Color.Plum;
                mtSales.UseTileImage = true;
                mtSales.Refresh();
            }
            
            // ---------------Delivery-----------------------------------------------------
            if (mtDelivery.BackColor == Color.LightCoral)
            {
                mtDelivery.Text = "Subject";
                mtDelivery.BackColor = Color.RosyBrown;
                mtDelivery.UseTileImage = false;
            }
            else if (mtDelivery.BackColor == Color.RosyBrown)
            {
                mtDelivery.Text = "Subject";
                mtDelivery.BackColor = Color.LightSteelBlue;
                mtDelivery.UseTileImage = true;
                mtDelivery.Refresh();
            }

            else if (mtDelivery.BackColor == Color.LightSteelBlue)
            {
                mtDelivery.Text = "Subject";
                mtDelivery.BackColor = Color.Silver;
                mtDelivery.UseTileImage = true;
                mtDelivery.Refresh();
            }

            else if (mtDelivery.BackColor == Color.Silver)
            {
                mtDelivery.Text = "Subject";
                mtDelivery.BackColor = Color.Tan;
                mtDelivery.UseTileImage = true;
                mtDelivery.Refresh();
            }

            else if (mtDelivery.BackColor == Color.Tan)
            {
                mtDelivery.Text = "Subject";
                mtDelivery.BackColor = Color.Thistle;
                mtDelivery.UseTileImage = true;
                mtDelivery.Refresh();
            }

            else
            {
                mtDelivery.Text = "Subje";
                mtDelivery.BackColor = Color.LightCoral;
                mtDelivery.UseTileImage = true;
                mtDelivery.Refresh();
            }
        }
    }
}
