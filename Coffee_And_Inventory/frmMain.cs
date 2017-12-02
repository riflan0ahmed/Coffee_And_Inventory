﻿using System;
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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }

        //call the mPanel
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get
            {
                return mPanel;
            }
            set
            {
                mPanel = value;
            }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get
            {
                return mlBack;
            }
            set
            {
                mlBack = value;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mlBack.Visible = false;
            _instance = this;
            ucDashboardfrmMain uc = new ucDashboardfrmMain();
            uc.Dock = DockStyle.Fill;
            mPanel.Controls.Add(uc);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["ucDashboard"].BringToFront();
            mlBack.Visible = false;
        }
    }
}
