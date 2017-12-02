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
    public partial class ucAccount_sales : UserControl
    {
        public ucAccount_sales()
        {
            InitializeComponent();
        }

        private void btn_loginSales_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameSales.Text, txt_passwordSales.Text).Rows.Count > 0)
                { 
                    foreach (cacDataSet.tbl_accountsRow row in tbl_accountsTableAdapter.GetDataByAccounts(txt_usernameSales.Text, txt_passwordSales.Text))
                    {
                        switch (row.AC_Username)
                        {
                            case "sales":
                                frmSales dAdmin = new frmSales();
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
