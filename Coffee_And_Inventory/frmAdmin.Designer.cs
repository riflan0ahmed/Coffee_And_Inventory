namespace Coffee_And_Inventory
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.mPanelAdmin = new MetroFramework.Controls.MetroPanel();
            this.mlBackAdmin = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanelAdmin
            // 
            this.mPanelAdmin.HorizontalScrollbarBarColor = true;
            this.mPanelAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanelAdmin.HorizontalScrollbarSize = 10;
            this.mPanelAdmin.Location = new System.Drawing.Point(25, 63);
            this.mPanelAdmin.Name = "mPanelAdmin";
            this.mPanelAdmin.Size = new System.Drawing.Size(950, 520);
            this.mPanelAdmin.TabIndex = 9;
            this.mPanelAdmin.VerticalScrollbarBarColor = true;
            this.mPanelAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.mPanelAdmin.VerticalScrollbarSize = 10;
            // 
            // mlBackAdmin
            // 
            this.mlBackAdmin.Image = ((System.Drawing.Image)(resources.GetObject("mlBackAdmin.Image")));
            this.mlBackAdmin.ImageSize = 32;
            this.mlBackAdmin.Location = new System.Drawing.Point(25, 18);
            this.mlBackAdmin.Name = "mlBackAdmin";
            this.mlBackAdmin.Size = new System.Drawing.Size(35, 37);
            this.mlBackAdmin.TabIndex = 8;
            this.mlBackAdmin.UseSelectable = true;
            this.mlBackAdmin.Click += new System.EventHandler(this.mlBackAdmin_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mPanelAdmin);
            this.Controls.Add(this.mlBackAdmin);
            this.Name = "frmAdmin";
            this.Text = "     Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanelAdmin;
        private MetroFramework.Controls.MetroLink mlBackAdmin;
    }
}