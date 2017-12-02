namespace Coffee_And_Inventory
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mlBack
            // 
            this.mlBack.Image = ((System.Drawing.Image)(resources.GetObject("mlBack.Image")));
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(32, 19);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(35, 37);
            this.mlBack.TabIndex = 0;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(32, 64);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(950, 520);
            this.mPanel.TabIndex = 1;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mlBack);
            this.Name = "frmMain";
            this.Opacity = 0.98D;
            this.Text = "       Coffee And Inventory System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroPanel mPanel;
    }
}

