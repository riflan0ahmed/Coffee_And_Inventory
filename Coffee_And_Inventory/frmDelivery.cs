using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_And_Inventory
{
    public partial class frmDelivery : MetroFramework.Forms.MetroForm
    {
        static frmDelivery _instanceDelivery;
        public static frmDelivery InstanceDelivery
        {
            get
            {
                if (_instanceDelivery == null)
                    _instanceDelivery = new frmDelivery();
                return _instanceDelivery;
            }
        }

        //call the mPanel
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get
            {
                return mPanelDelivery;
            }
            set
            {
                mPanelDelivery = value;
            }
        }

        //Call the mlBack
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get
            {
                return mlBackDelivery;
            }
            set
            {
                mlBackDelivery = value;
            }
        }

        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDeliery_Load(object sender, EventArgs e)
        {
            mlBackDelivery.Visible = false;
            _instanceDelivery = this;
            ucDashboardDelivery uc = new ucDashboardDelivery();
            uc.Dock = DockStyle.Fill;
            mPanelDelivery.Controls.Add(uc);


        }

        private void mlBackDelivery_Click(object sender, EventArgs e)
        {
            mPanelDelivery.Controls["ucDashboardDelivery"].BringToFront();
            mlBackDelivery.Visible = false;
        }

        private void mPanelDelivery_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
