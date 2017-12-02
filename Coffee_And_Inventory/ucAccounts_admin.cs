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
    public partial class ucAccounts_admin : MetroFramework.Controls.MetroUserControl
    {
        public ucAccounts_admin()
        {
            InitializeComponent();
        }

        private void ucAccounts_admin_Load(object sender, EventArgs e)
        {
           
        }


        private void btn_loginAdmin_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameAdmin.Text, txt_passwordAdmin.Text).Rows.Count > 0)
                {
                    foreach (cacDataSet.tbl_accountsRow row in tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameAdmin.Text, txt_passwordAdmin.Text))
                    {
                        switch (row.AC_Username)
                        {
                            case "admin":
                                frmAdmin dAdmin = new frmAdmin();
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
