namespace Coffee_And_Inventory
{
    partial class ucAccounts_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccounts_admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_admin = new MetroFramework.Controls.MetroLabel();
            this.txt_usernameAdmin = new MetroFramework.Controls.MetroTextBox();
            this.txt_passwordAdmin = new MetroFramework.Controls.MetroTextBox();
            this.lbl_usernameAdmin = new MetroFramework.Controls.MetroLabel();
            this.lbl_passwordAdmin = new MetroFramework.Controls.MetroLabel();
            this.btn_loginAdmin = new MetroFramework.Controls.MetroButton();
            this.bindingSourceAdmin = new System.Windows.Forms.BindingSource(this.components);
            this.cacDataSet = new Coffee_And_Inventory.cacDataSet();
            this.tbl_accountsTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_accountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_admin
            // 
            this.lbl_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_admin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_admin.Location = new System.Drawing.Point(88, 78);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(65, 25);
            this.lbl_admin.TabIndex = 1;
            this.lbl_admin.Text = "Admin";
            // 
            // txt_usernameAdmin
            // 
            // 
            // 
            // 
            this.txt_usernameAdmin.CustomButton.Image = null;
            this.txt_usernameAdmin.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_usernameAdmin.CustomButton.Name = "";
            this.txt_usernameAdmin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_usernameAdmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_usernameAdmin.CustomButton.TabIndex = 1;
            this.txt_usernameAdmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_usernameAdmin.CustomButton.UseSelectable = true;
            this.txt_usernameAdmin.CustomButton.Visible = false;
            this.txt_usernameAdmin.Lines = new string[0];
            this.txt_usernameAdmin.Location = new System.Drawing.Point(401, 185);
            this.txt_usernameAdmin.MaxLength = 32767;
            this.txt_usernameAdmin.Name = "txt_usernameAdmin";
            this.txt_usernameAdmin.PasswordChar = '\0';
            this.txt_usernameAdmin.PromptText = "Enter your username";
            this.txt_usernameAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_usernameAdmin.SelectedText = "";
            this.txt_usernameAdmin.SelectionLength = 0;
            this.txt_usernameAdmin.SelectionStart = 0;
            this.txt_usernameAdmin.ShortcutsEnabled = true;
            this.txt_usernameAdmin.Size = new System.Drawing.Size(221, 23);
            this.txt_usernameAdmin.TabIndex = 0;
            this.txt_usernameAdmin.UseSelectable = true;
            this.txt_usernameAdmin.WaterMark = "Enter your username";
            this.txt_usernameAdmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_usernameAdmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_passwordAdmin
            // 
            // 
            // 
            // 
            this.txt_passwordAdmin.CustomButton.Image = null;
            this.txt_passwordAdmin.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_passwordAdmin.CustomButton.Name = "";
            this.txt_passwordAdmin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_passwordAdmin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_passwordAdmin.CustomButton.TabIndex = 1;
            this.txt_passwordAdmin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_passwordAdmin.CustomButton.UseSelectable = true;
            this.txt_passwordAdmin.CustomButton.Visible = false;
            this.txt_passwordAdmin.Lines = new string[0];
            this.txt_passwordAdmin.Location = new System.Drawing.Point(401, 250);
            this.txt_passwordAdmin.MaxLength = 32767;
            this.txt_passwordAdmin.Name = "txt_passwordAdmin";
            this.txt_passwordAdmin.PasswordChar = '\0';
            this.txt_passwordAdmin.PromptText = "Enter your password";
            this.txt_passwordAdmin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_passwordAdmin.SelectedText = "";
            this.txt_passwordAdmin.SelectionLength = 0;
            this.txt_passwordAdmin.SelectionStart = 0;
            this.txt_passwordAdmin.ShortcutsEnabled = true;
            this.txt_passwordAdmin.Size = new System.Drawing.Size(221, 23);
            this.txt_passwordAdmin.TabIndex = 1;
            this.txt_passwordAdmin.UseSelectable = true;
            this.txt_passwordAdmin.WaterMark = "Enter your password";
            this.txt_passwordAdmin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_passwordAdmin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_usernameAdmin
            // 
            this.lbl_usernameAdmin.AutoSize = true;
            this.lbl_usernameAdmin.Location = new System.Drawing.Point(401, 160);
            this.lbl_usernameAdmin.Name = "lbl_usernameAdmin";
            this.lbl_usernameAdmin.Size = new System.Drawing.Size(68, 19);
            this.lbl_usernameAdmin.TabIndex = 3;
            this.lbl_usernameAdmin.Text = "Username";
            // 
            // lbl_passwordAdmin
            // 
            this.lbl_passwordAdmin.AutoSize = true;
            this.lbl_passwordAdmin.Location = new System.Drawing.Point(401, 224);
            this.lbl_passwordAdmin.Name = "lbl_passwordAdmin";
            this.lbl_passwordAdmin.Size = new System.Drawing.Size(63, 19);
            this.lbl_passwordAdmin.TabIndex = 3;
            this.lbl_passwordAdmin.Text = "Password";
            // 
            // btn_loginAdmin
            // 
            this.btn_loginAdmin.Location = new System.Drawing.Point(546, 280);
            this.btn_loginAdmin.Name = "btn_loginAdmin";
            this.btn_loginAdmin.Size = new System.Drawing.Size(75, 23);
            this.btn_loginAdmin.TabIndex = 2;
            this.btn_loginAdmin.Text = "Login";
            this.btn_loginAdmin.UseSelectable = true;
            this.btn_loginAdmin.Click += new System.EventHandler(this.btn_loginAdmin_Click);
            // 
            // bindingSourceAdmin
            // 
            this.bindingSourceAdmin.DataMember = "tbl_accounts";
            this.bindingSourceAdmin.DataSource = this.cacDataSet;
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
            // ucAccounts_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_loginAdmin);
            this.Controls.Add(this.lbl_passwordAdmin);
            this.Controls.Add(this.lbl_usernameAdmin);
            this.Controls.Add(this.txt_passwordAdmin);
            this.Controls.Add(this.txt_usernameAdmin);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucAccounts_admin";
            this.Size = new System.Drawing.Size(950, 520);
            this.Load += new System.EventHandler(this.ucAccounts_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lbl_admin;
        private MetroFramework.Controls.MetroTextBox txt_usernameAdmin;
        private MetroFramework.Controls.MetroTextBox txt_passwordAdmin;
        private MetroFramework.Controls.MetroLabel lbl_usernameAdmin;
        private MetroFramework.Controls.MetroLabel lbl_passwordAdmin;
        private MetroFramework.Controls.MetroButton btn_loginAdmin;
        private System.Windows.Forms.BindingSource bindingSourceAdmin;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
    }
}
