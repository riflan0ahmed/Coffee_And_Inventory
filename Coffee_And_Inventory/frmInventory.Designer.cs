namespace Coffee_And_Inventory
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.mPanelInventory = new MetroFramework.Controls.MetroPanel();
            this.mlBackInventory = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanelInventory
            // 
            this.mPanelInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanelInventory.HorizontalScrollbarBarColor = true;
            this.mPanelInventory.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelInventory.HorizontalScrollbarSize = 10;
            this.mPanelInventory.Location = new System.Drawing.Point(25, 63);
            this.mPanelInventory.Name = "mPanelInventory";
            this.mPanelInventory.Size = new System.Drawing.Size(950, 520);
            this.mPanelInventory.TabIndex = 9;
            this.mPanelInventory.VerticalScrollbarBarColor = true;
            this.mPanelInventory.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelInventory.VerticalScrollbarSize = 10;
            // 
            // mlBackInventory
            // 
            this.mlBackInventory.Image = ((System.Drawing.Image)(resources.GetObject("mlBackInventory.Image")));
            this.mlBackInventory.ImageSize = 32;
            this.mlBackInventory.Location = new System.Drawing.Point(25, 18);
            this.mlBackInventory.Name = "mlBackInventory";
            this.mlBackInventory.Size = new System.Drawing.Size(35, 37);
            this.mlBackInventory.TabIndex = 8;
            this.mlBackInventory.UseSelectable = true;
            this.mlBackInventory.Click += new System.EventHandler(this.mlBackInventory_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mPanelInventory);
            this.Controls.Add(this.mlBackInventory);
            this.Name = "frmInventory";
            this.Text = "      Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelInventory;
        private MetroFramework.Controls.MetroLink mlBackInventory;
    }
}