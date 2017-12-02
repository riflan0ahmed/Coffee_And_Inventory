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
    public partial class frmSales : MetroFramework.Forms.MetroForm
    {
        static frmSales _instanceSales;
        public static frmSales InstanceSales
        {
            get
            {
                if (_instanceSales == null)
                    _instanceSales = new frmSales();
                return _instanceSales;
            }
        }

        //call the mPanel
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get
            {
                return mPanelSales;
            }
            set
            {
                mPanelSales = value;
            }
        }

        //Call the mlBack
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get
            {
                return mlBackSales;
            }
            set
            {
                mlBackSales = value;
            }
        }

        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            mlBackSales.Visible = false;
            _instanceSales = this;
            ucDashboardSales uc = new ucDashboardSales();
            uc.Dock = DockStyle.Fill;
            mPanelSales.Controls.Add(uc);
        }

        private void mlBackSales_Click(object sender, EventArgs e)
        {
            mPanelSales.Controls["ucSalesDashboard"].BringToFront();
            mlBackSales.Visible = false;
        }
    }
}
