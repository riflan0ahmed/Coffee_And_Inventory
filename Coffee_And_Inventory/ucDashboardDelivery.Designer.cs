namespace Coffee_And_Inventory
{
    partial class ucDashboardDelivery
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
            this.mtDelivery_delivery = new MetroFramework.Controls.MetroTile();
            this.mtDelivery_delivered = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtDelivery_delivery
            // 
            this.mtDelivery_delivery.ActiveControl = null;
            this.mtDelivery_delivery.Location = new System.Drawing.Point(13, 17);
            this.mtDelivery_delivery.Name = "mtDelivery_delivery";
            this.mtDelivery_delivery.Size = new System.Drawing.Size(256, 156);
            this.mtDelivery_delivery.TabIndex = 2;
            this.mtDelivery_delivery.Text = "Delivery";
            this.mtDelivery_delivery.UseSelectable = true;
            this.mtDelivery_delivery.Click += new System.EventHandler(this.mtDelivery_delivery_Click);
            // 
            // mtDelivery_delivered
            // 
            this.mtDelivery_delivered.ActiveControl = null;
            this.mtDelivery_delivered.Location = new System.Drawing.Point(275, 17);
            this.mtDelivery_delivered.Name = "mtDelivery_delivered";
            this.mtDelivery_delivered.Size = new System.Drawing.Size(256, 156);
            this.mtDelivery_delivered.TabIndex = 3;
            this.mtDelivery_delivered.Text = "Delivered";
            this.mtDelivery_delivered.UseSelectable = true;
            // 
            // ucDashboardDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtDelivery_delivered);
            this.Controls.Add(this.mtDelivery_delivery);
            this.Name = "ucDashboardDelivery";
            this.Size = new System.Drawing.Size(950, 520);
            this.Load += new System.EventHandler(this.ucDashboardDelivery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtDelivery_delivery;
        private MetroFramework.Controls.MetroTile mtDelivery_delivered;
    }
}
