namespace Coffee_And_Inventory
{
    partial class ucDashboardfrmMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtAdmin = new MetroFramework.Controls.MetroTile();
            this.mtSales = new MetroFramework.Controls.MetroTile();
            this.mtInventory = new MetroFramework.Controls.MetroTile();
            this.mtDelivery = new MetroFramework.Controls.MetroTile();
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mtAdmin
            // 
            this.mtAdmin.ActiveControl = null;
            this.mtAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mtAdmin.Location = new System.Drawing.Point(23, 26);
            this.mtAdmin.Name = "mtAdmin";
            this.mtAdmin.Size = new System.Drawing.Size(256, 156);
            this.mtAdmin.TabIndex = 0;
            this.mtAdmin.Text = "Admin";
            this.mtAdmin.UseCustomBackColor = true;
            this.mtAdmin.UseSelectable = true;
            this.mtAdmin.UseTileImage = true;
            this.mtAdmin.UseWaitCursor = true;
            this.mtAdmin.Click += new System.EventHandler(this.mtAdmin_Click);
            // 
            // mtSales
            // 
            this.mtSales.ActiveControl = null;
            this.mtSales.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mtSales.Location = new System.Drawing.Point(23, 188);
            this.mtSales.Name = "mtSales";
            this.mtSales.Size = new System.Drawing.Size(256, 156);
            this.mtSales.TabIndex = 2;
            this.mtSales.Text = "Sales";
            this.mtSales.UseCustomBackColor = true;
            this.mtSales.UseSelectable = true;
            this.mtSales.UseTileImage = true;
            this.mtSales.UseWaitCursor = true;
            this.mtSales.Click += new System.EventHandler(this.mtSales_Click);
            // 
            // mtInventory
            // 
            this.mtInventory.ActiveControl = null;
            this.mtInventory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mtInventory.Location = new System.Drawing.Point(285, 26);
            this.mtInventory.Name = "mtInventory";
            this.mtInventory.Size = new System.Drawing.Size(256, 156);
            this.mtInventory.TabIndex = 1;
            this.mtInventory.Text = "Inventory";
            this.mtInventory.UseCustomBackColor = true;
            this.mtInventory.UseSelectable = true;
            this.mtInventory.UseTileImage = true;
            this.mtInventory.UseWaitCursor = true;
            this.mtInventory.Click += new System.EventHandler(this.mtInventory_Click);
            // 
            // mtDelivery
            // 
            this.mtDelivery.ActiveControl = null;
            this.mtDelivery.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mtDelivery.Location = new System.Drawing.Point(285, 188);
            this.mtDelivery.Name = "mtDelivery";
            this.mtDelivery.Size = new System.Drawing.Size(256, 156);
            this.mtDelivery.TabIndex = 3;
            this.mtDelivery.Text = "Delivery";
            this.mtDelivery.UseCustomBackColor = true;
            this.mtDelivery.UseSelectable = true;
            this.mtDelivery.UseTileImage = true;
            this.mtDelivery.UseWaitCursor = true;
            this.mtDelivery.Click += new System.EventHandler(this.mtDelivery_Click);
            // 
            // timerDashboard
            // 
            this.timerDashboard.Interval = 5000;
            this.timerDashboard.Tick += new System.EventHandler(this.timerDashboard_Tick);
            // 
            // ucDashboardfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtDelivery);
            this.Controls.Add(this.mtInventory);
            this.Controls.Add(this.mtSales);
            this.Controls.Add(this.mtAdmin);
            this.Name = "ucDashboardfrmMain";
            this.Size = new System.Drawing.Size(950, 520);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdmin;
        private MetroFramework.Controls.MetroTile mtSales;
        private MetroFramework.Controls.MetroTile mtInventory;
        private MetroFramework.Controls.MetroTile mtDelivery;
        private System.Windows.Forms.Timer timerDashboard;
    }
}
