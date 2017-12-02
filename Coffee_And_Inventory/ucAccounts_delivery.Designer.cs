namespace Coffee_And_Inventory
{
    partial class ucAccounts_delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccounts_delivery));
            this.btn_loginDelivery = new MetroFramework.Controls.MetroButton();
            this.lbl_passwordDelivery = new MetroFramework.Controls.MetroLabel();
            this.lbl_usernameDelivery = new MetroFramework.Controls.MetroLabel();
            this.txt_passwordDelivery = new MetroFramework.Controls.MetroTextBox();
            this.txt_usernameDelivery = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Delivery = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSourceDelivery = new System.Windows.Forms.BindingSource(this.components);
            this.cacDataSet = new Coffee_And_Inventory.cacDataSet();
            this.tbl_accountsTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_accountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loginDelivery
            // 
            this.btn_loginDelivery.Location = new System.Drawing.Point(547, 280);
            this.btn_loginDelivery.Name = "btn_loginDelivery";
            this.btn_loginDelivery.Size = new System.Drawing.Size(75, 23);
            this.btn_loginDelivery.TabIndex = 2;
            this.btn_loginDelivery.Text = "Login";
            this.btn_loginDelivery.UseSelectable = true;
            this.btn_loginDelivery.Click += new System.EventHandler(this.btn_loginDelivery_Click);
            // 
            // lbl_passwordDelivery
            // 
            this.lbl_passwordDelivery.AutoSize = true;
            this.lbl_passwordDelivery.Location = new System.Drawing.Point(402, 224);
            this.lbl_passwordDelivery.Name = "lbl_passwordDelivery";
            this.lbl_passwordDelivery.Size = new System.Drawing.Size(63, 19);
            this.lbl_passwordDelivery.TabIndex = 5;
            this.lbl_passwordDelivery.Text = "Password";
            // 
            // lbl_usernameDelivery
            // 
            this.lbl_usernameDelivery.AutoSize = true;
            this.lbl_usernameDelivery.Location = new System.Drawing.Point(402, 160);
            this.lbl_usernameDelivery.Name = "lbl_usernameDelivery";
            this.lbl_usernameDelivery.Size = new System.Drawing.Size(68, 19);
            this.lbl_usernameDelivery.TabIndex = 3;
            this.lbl_usernameDelivery.Text = "Username";
            // 
            // txt_passwordDelivery
            // 
            // 
            // 
            // 
            this.txt_passwordDelivery.CustomButton.Image = null;
            this.txt_passwordDelivery.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_passwordDelivery.CustomButton.Name = "";
            this.txt_passwordDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_passwordDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_passwordDelivery.CustomButton.TabIndex = 1;
            this.txt_passwordDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_passwordDelivery.CustomButton.UseSelectable = true;
            this.txt_passwordDelivery.CustomButton.Visible = false;
            this.txt_passwordDelivery.Lines = new string[0];
            this.txt_passwordDelivery.Location = new System.Drawing.Point(402, 250);
            this.txt_passwordDelivery.MaxLength = 32767;
            this.txt_passwordDelivery.Name = "txt_passwordDelivery";
            this.txt_passwordDelivery.PasswordChar = '\0';
            this.txt_passwordDelivery.PromptText = "Enter your password";
            this.txt_passwordDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_passwordDelivery.SelectedText = "";
            this.txt_passwordDelivery.SelectionLength = 0;
            this.txt_passwordDelivery.SelectionStart = 0;
            this.txt_passwordDelivery.ShortcutsEnabled = true;
            this.txt_passwordDelivery.Size = new System.Drawing.Size(221, 23);
            this.txt_passwordDelivery.TabIndex = 1;
            this.txt_passwordDelivery.UseSelectable = true;
            this.txt_passwordDelivery.WaterMark = "Enter your password";
            this.txt_passwordDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_passwordDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_usernameDelivery
            // 
            // 
            // 
            // 
            this.txt_usernameDelivery.CustomButton.Image = null;
            this.txt_usernameDelivery.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_usernameDelivery.CustomButton.Name = "";
            this.txt_usernameDelivery.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_usernameDelivery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_usernameDelivery.CustomButton.TabIndex = 1;
            this.txt_usernameDelivery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_usernameDelivery.CustomButton.UseSelectable = true;
            this.txt_usernameDelivery.CustomButton.Visible = false;
            this.txt_usernameDelivery.Lines = new string[0];
            this.txt_usernameDelivery.Location = new System.Drawing.Point(402, 185);
            this.txt_usernameDelivery.MaxLength = 32767;
            this.txt_usernameDelivery.Name = "txt_usernameDelivery";
            this.txt_usernameDelivery.PasswordChar = '\0';
            this.txt_usernameDelivery.PromptText = "Enter your username";
            this.txt_usernameDelivery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_usernameDelivery.SelectedText = "";
            this.txt_usernameDelivery.SelectionLength = 0;
            this.txt_usernameDelivery.SelectionStart = 0;
            this.txt_usernameDelivery.ShortcutsEnabled = true;
            this.txt_usernameDelivery.Size = new System.Drawing.Size(221, 23);
            this.txt_usernameDelivery.TabIndex = 0;
            this.txt_usernameDelivery.UseSelectable = true;
            this.txt_usernameDelivery.WaterMark = "Enter your username";
            this.txt_usernameDelivery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_usernameDelivery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Delivery
            // 
            this.lbl_Delivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Delivery.AutoSize = true;
            this.lbl_Delivery.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Delivery.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_Delivery.Location = new System.Drawing.Point(89, 78);
            this.lbl_Delivery.Name = "lbl_Delivery";
            this.lbl_Delivery.Size = new System.Drawing.Size(137, 25);
            this.lbl_Delivery.TabIndex = 4;
            this.lbl_Delivery.Text = "Delivery System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSourceDelivery
            // 
            this.bindingSourceDelivery.DataMember = "tbl_accounts";
            this.bindingSourceDelivery.DataSource = this.cacDataSet;
            // 
            // cacDataSet
            // 
            this.cacDataSet.DataSetName = "cacDataSet";
            this.cacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_accountsTableAdapter
            // 
            this.tbl_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // ucAccounts_delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_loginDelivery);
            this.Controls.Add(this.lbl_passwordDelivery);
            this.Controls.Add(this.lbl_usernameDelivery);
            this.Controls.Add(this.txt_passwordDelivery);
            this.Controls.Add(this.txt_usernameDelivery);
            this.Controls.Add(this.lbl_Delivery);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucAccounts_delivery";
            this.Size = new System.Drawing.Size(950, 520);
            this.Load += new System.EventHandler(this.ucAccounts_delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_loginDelivery;
        private MetroFramework.Controls.MetroLabel lbl_passwordDelivery;
        private MetroFramework.Controls.MetroLabel lbl_usernameDelivery;
        private MetroFramework.Controls.MetroTextBox txt_passwordDelivery;
        private MetroFramework.Controls.MetroTextBox txt_usernameDelivery;
        private MetroFramework.Controls.MetroLabel lbl_Delivery;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSourceDelivery;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
    }
}
