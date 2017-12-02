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
    public partial class ucAccount_inventory : MetroFramework.Controls.MetroUserControl
    {
        public ucAccount_inventory()
        {
            InitializeComponent();
        }

        private void btn_loginInventory_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameInventory.Text, txt_passwordInventory.Text).Rows.Count > 0)
                {
                    foreach (cacDataSet.tbl_accountsRow row in tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameInventory.Text, txt_passwordInventory.Text))
                    {
                        switch (row.AC_Username)
                        {
                            case "inventory":
                                frmInventory dAdmin = new frmInventory();
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
    }
}
