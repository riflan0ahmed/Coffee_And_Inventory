namespace Coffee_And_Inventory
{
    partial class ucDashboardAdmin
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
            this.mtAdmin_Account = new MetroFramework.Controls.MetroTile();
            this.mtAdmin_Inventory = new MetroFramework.Controls.MetroTile();
            this.mtAdmin_Sales = new MetroFramework.Controls.MetroTile();
            this.mtAdmin_Delivery = new MetroFramework.Controls.MetroTile();
            this.mtAdmin_Employee = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtAdmin_Account
            // 
            this.mtAdmin_Account.ActiveControl = null;
            this.mtAdmin_Account.Location = new System.Drawing.Point(24, 21);
            this.mtAdmin_Account.Name = "mtAdmin_Account";
            this.mtAdmin_Account.Size = new System.Drawing.Size(256, 156);
            this.mtAdmin_Account.TabIndex = 0;
            this.mtAdmin_Account.Text = "Accounts";
            this.mtAdmin_Account.UseSelectable = true;
            this.mtAdmin_Account.Click += new System.EventHandler(this.mtAdmin_Account_Click);
            // 
            // mtAdmin_Inventory
            // 
            this.mtAdmin_Inventory.ActiveControl = null;
            this.mtAdmin_Inventory.Location = new System.Drawing.Point(548, 22);
            this.mtAdmin_Inventory.Name = "mtAdmin_Inventory";
            this.mtAdmin_Inventory.Size = new System.Drawing.Size(256, 156);
            this.mtAdmin_Inventory.TabIndex = 2;
            this.mtAdmin_Inventory.Text = "Inventory";
            this.mtAdmin_Inventory.UseSelectable = true;
            this.mtAdmin_Inventory.Click += new System.EventHandler(this.mtAdmin_Inventory_Click);
            // 
            // mtAdmin_Sales
            // 
            this.mtAdmin_Sales.ActiveControl = null;
            this.mtAdmin_Sales.Location = new System.Drawing.Point(24, 183);
            this.mtAdmin_Sales.Name = "mtAdmin_Sales";
            this.mtAdmin_Sales.Size = new System.Drawing.Size(256, 156);
            this.mtAdmin_Sales.TabIndex = 3;
            this.mtAdmin_Sales.Text = "Sales";
            this.mtAdmin_Sales.UseSelectable = true;
            this.mtAdmin_Sales.Click += new System.EventHandler(this.mtAdmin_Sales_Click);
            // 
            // mtAdmin_Delivery
            // 
            this.mtAdmin_Delivery.ActiveControl = null;
            this.mtAdmin_Delivery.Location = new System.Drawing.Point(287, 184);
            this.mtAdmin_Delivery.Name = "mtAdmin_Delivery";
            this.mtAdmin_Delivery.Size = new System.Drawing.Size(255, 155);
            this.mtAdmin_Delivery.TabIndex = 4;
            this.mtAdmin_Delivery.Text = "Delivery";
            this.mtAdmin_Delivery.UseSelectable = true;
            this.mtAdmin_Delivery.Click += new System.EventHandler(this.mtAdmin_Delivery_Click);
            // 
            // mtAdmin_Employee
            // 
            this.mtAdmin_Employee.ActiveControl = null;
            this.mtAdmin_Employee.Location = new System.Drawing.Point(287, 22);
            this.mtAdmin_Employee.Name = "mtAdmin_Employee";
            this.mtAdmin_Employee.Size = new System.Drawing.Size(255, 155);
            this.mtAdmin_Employee.TabIndex = 1;
            this.mtAdmin_Employee.Text = "Employee";
            this.mtAdmin_Employee.UseSelectable = true;
            this.mtAdmin_Employee.Click += new System.EventHandler(this.mtAdmin_Employee_Click);
            // 
            // ucDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtAdmin_Employee);
            this.Controls.Add(this.mtAdmin_Delivery);
            this.Controls.Add(this.mtAdmin_Sales);
            this.Controls.Add(this.mtAdmin_Inventory);
            this.Controls.Add(this.mtAdmin_Account);
            this.Name = "ucDashboardAdmin";
            this.Size = new System.Drawing.Size(950, 520);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtAdmin_Account;
        private MetroFramework.Controls.MetroTile mtAdmin_Inventory;
        private MetroFramework.Controls.MetroTile mtAdmin_Sales;
        private MetroFramework.Controls.MetroTile mtAdmin_Delivery;
        private MetroFramework.Controls.MetroTile mtAdmin_Employee;
    }
}
