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
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        static frmAdmin _instanceAdmin;
        public static frmAdmin InstanceAdmin
        {
            get
            {
                if (_instanceAdmin == null)
                    _instanceAdmin = new frmAdmin();
                return _instanceAdmin;
            }
        }

        //call the mPanel
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get
            {
                return mPanelAdmin;
            }
            set
            {
                mPanelAdmin = value;
            }
        }

        //Call the mlBack
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get
            {
                return mlBackAdmin;
            }
            set
            {
                mlBackAdmin = value;
            }
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            mlBackAdmin.Visible = false;
            _instanceAdmin = this;
            ucDashboardAdmin uc = new ucDashboardAdmin();
            uc.Dock = DockStyle.Fill;
            mPanelAdmin.Controls.Add(uc);
        }

        private void mlBackAdmin_Click(object sender, EventArgs e)
        {
            mPanelAdmin.Controls["ucDashboardDelivery"].BringToFront();
            mlBackAdmin.Visible = false;
        }
    }
}
