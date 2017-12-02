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
    public partial class frmInventory : MetroFramework.Forms.MetroForm
    {
        static frmInventory _instanceInventory;
        public static frmInventory InstanceInventory
        {
            get
            {
                if (_instanceInventory == null)
                    _instanceInventory = new frmInventory();
                return _instanceInventory;
            }
        }

        //call the mPanel
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get
            {
                return mPanelInventory;
            }
            set
            {
                mPanelInventory = value;
            }
        }

        //Call the mlBack
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get
            {
                return mlBackInventory;
            }
            set
            {
                mlBackInventory = value;
            }
        }

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            mlBackInventory.Visible = false;
            _instanceInventory = this;
            ucDashboardDelivery uc = new ucDashboardDelivery();
            uc.Dock = DockStyle.Fill;
            mPanelInventory.Controls.Add(uc);
        }

        private void mlBackInventory_Click(object sender, EventArgs e)
        {
            mPanelInventory.Controls["ucDeliveryDashboard"].BringToFront();
            mlBackInventory.Visible = false;
        }
    }
}
