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
    public partial class ucAccounts_delivery : MetroFramework.Controls.MetroUserControl
    {
        public ucAccounts_delivery()
        {
            InitializeComponent();
        }

        private void btn_loginDelivery_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameDelivery.Text, txt_passwordDelivery.Text).Rows.Count > 0)
                {
                    foreach (cacDataSet.tbl_accountsRow row in tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameDelivery.Text, txt_passwordDelivery.Text))
                    {
                        switch (row.AC_Username)
                        {
                            case "delivery":
                                frmDelivery dAdmin = new frmDelivery();
                                dAdmin.Show();
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "oK", "invalid username", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            catch (Exception)
            {
                throw;
            }*/
        }

        

        private void ucAccounts_delivery_Load(object sender, EventArgs e)
        {

        }
    }
}
