namespace Coffee_And_Inventory
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.mPanelSales = new MetroFramework.Controls.MetroPanel();
            this.mlBackSales = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanelSales
            // 
            this.mPanelSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelSales.HorizontalScrollbarBarColor = true;
            this.mPanelSales.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelSales.HorizontalScrollbarSize = 10;
            this.mPanelSales.Location = new System.Drawing.Point(25, 63);
            this.mPanelSales.Name = "mPanelSales";
            this.mPanelSales.Size = new System.Drawing.Size(950, 520);
            this.mPanelSales.TabIndex = 5;
            this.mPanelSales.VerticalScrollbarBarColor = true;
            this.mPanelSales.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelSales.VerticalScrollbarSize = 10;
            // 
            // mlBackSales
            // 
            this.mlBackSales.Image = ((System.Drawing.Image)(resources.GetObject("mlBackSales.Image")));
            this.mlBackSales.ImageSize = 32;
            this.mlBackSales.Location = new System.Drawing.Point(25, 18);
            this.mlBackSales.Name = "mlBackSales";
            this.mlBackSales.Size = new System.Drawing.Size(35, 37);
            this.mlBackSales.TabIndex = 4;
            this.mlBackSales.UseSelectable = true;
            this.mlBackSales.Click += new System.EventHandler(this.mlBackSales_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mPanelSales);
            this.Controls.Add(this.mlBackSales);
            this.Name = "frmSales";
            this.Text = "      Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelSales;
        private MetroFramework.Controls.MetroLink mlBackSales;
    }
}