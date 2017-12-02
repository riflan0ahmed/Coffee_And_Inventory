namespace Coffee_And_Inventory
{
    partial class frmDelivery
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.mPanelDelivery = new MetroFramework.Controls.MetroPanel();
            this.mlBackDelivery = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanelDelivery
            // 
            this.mPanelDelivery.HorizontalScrollbarBarColor = true;
            this.mPanelDelivery.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelDelivery.HorizontalScrollbarSize = 10;
            this.mPanelDelivery.Location = new System.Drawing.Point(25, 63);
            this.mPanelDelivery.Name = "mPanelDelivery";
            this.mPanelDelivery.Size = new System.Drawing.Size(950, 520);
            this.mPanelDelivery.TabIndex = 7;
            this.mPanelDelivery.VerticalScrollbarBarColor = true;
            this.mPanelDelivery.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelDelivery.VerticalScrollbarSize = 10;
            this.mPanelDelivery.Paint += new System.Windows.Forms.PaintEventHandler(this.mPanelDelivery_Paint);
            // 
            // mlBackDelivery
            // 
            this.mlBackDelivery.Image = ((System.Drawing.Image)(resources.GetObject("mlBackDelivery.Image")));
            this.mlBackDelivery.ImageSize = 32;
            this.mlBackDelivery.Location = new System.Drawing.Point(25, 18);
            this.mlBackDelivery.Name = "mlBackDelivery";
            this.mlBackDelivery.Size = new System.Drawing.Size(35, 37);
            this.mlBackDelivery.TabIndex = 6;
            this.mlBackDelivery.UseSelectable = true;
            this.mlBackDelivery.Click += new System.EventHandler(this.mlBackDelivery_Click);
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mPanelDelivery);
            this.Controls.Add(this.mlBackDelivery);
            this.Name = "frmDelivery";
            this.Opacity = 0.98D;
            this.Text = "     Delivery";
            this.Load += new System.EventHandler(this.frmDeliery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelDelivery;
        private MetroFramework.Controls.MetroLink mlBackDelivery;
    }
}