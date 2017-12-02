namespace Coffee_And_Inventory
{
    partial class ucAccount_inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccount_inventory));
            this.btn_loginInventory = new MetroFramework.Controls.MetroButton();
            this.lbl_passwordInventory = new MetroFramework.Controls.MetroLabel();
            this.lbl_usernameInventory = new MetroFramework.Controls.MetroLabel();
            this.txt_passwordInventory = new MetroFramework.Controls.MetroTextBox();
            this.txt_usernameInventory = new MetroFramework.Controls.MetroTextBox();
            this.lbl_inventory = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSourceInventory = new System.Windows.Forms.BindingSource(this.components);
            this.cacDataSet = new Coffee_And_Inventory.cacDataSet();
            this.tbl_accountsTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_accountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loginInventory
            // 
            this.btn_loginInventory.Location = new System.Drawing.Point(546, 280);
            this.btn_loginInventory.Name = "btn_loginInventory";
            this.btn_loginInventory.Size = new System.Drawing.Size(75, 23);
            this.btn_loginInventory.TabIndex = 2;
            this.btn_loginInventory.Text = "Login";
            this.btn_loginInventory.UseSelectable = true;
            this.btn_loginInventory.Click += new System.EventHandler(this.btn_loginInventory_Click);
            // 
            // lbl_passwordInventory
            // 
            this.lbl_passwordInventory.AutoSize = true;
            this.lbl_passwordInventory.Location = new System.Drawing.Point(401, 224);
            this.lbl_passwordInventory.Name = "lbl_passwordInventory";
            this.lbl_passwordInventory.Size = new System.Drawing.Size(63, 19);
            this.lbl_passwordInventory.TabIndex = 16;
            this.lbl_passwordInventory.Text = "Password";
            // 
            // lbl_usernameInventory
            // 
            this.lbl_usernameInventory.AutoSize = true;
            this.lbl_usernameInventory.Location = new System.Drawing.Point(401, 160);
            this.lbl_usernameInventory.Name = "lbl_usernameInventory";
            this.lbl_usernameInventory.Size = new System.Drawing.Size(68, 19);
            this.lbl_usernameInventory.TabIndex = 17;
            this.lbl_usernameInventory.Text = "Username";
            // 
            // txt_passwordInventory
            // 
            // 
            // 
            // 
            this.txt_passwordInventory.CustomButton.Image = null;
            this.txt_passwordInventory.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_passwordInventory.CustomButton.Name = "";
            this.txt_passwordInventory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_passwordInventory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_passwordInventory.CustomButton.TabIndex = 1;
            this.txt_passwordInventory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_passwordInventory.CustomButton.UseSelectable = true;
            this.txt_passwordInventory.CustomButton.Visible = false;
            this.txt_passwordInventory.Lines = new string[0];
            this.txt_passwordInventory.Location = new System.Drawing.Point(401, 250);
            this.txt_passwordInventory.MaxLength = 32767;
            this.txt_passwordInventory.Name = "txt_passwordInventory";
            this.txt_passwordInventory.PasswordChar = '\0';
            this.txt_passwordInventory.PromptText = "Enter your password";
            this.txt_passwordInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_passwordInventory.SelectedText = "";
            this.txt_passwordInventory.SelectionLength = 0;
            this.txt_passwordInventory.SelectionStart = 0;
            this.txt_passwordInventory.ShortcutsEnabled = true;
            this.txt_passwordInventory.Size = new System.Drawing.Size(221, 23);
            this.txt_passwordInventory.TabIndex = 1;
            this.txt_passwordInventory.UseSelectable = true;
            this.txt_passwordInventory.WaterMark = "Enter your password";
            this.txt_passwordInventory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_passwordInventory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_usernameInventory
            // 
            // 
            // 
            // 
            this.txt_usernameInventory.CustomButton.Image = null;
            this.txt_usernameInventory.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_usernameInventory.CustomButton.Name = "";
            this.txt_usernameInventory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_usernameInventory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_usernameInventory.CustomButton.TabIndex = 1;
            this.txt_usernameInventory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_usernameInventory.CustomButton.UseSelectable = true;
            this.txt_usernameInventory.CustomButton.Visible = false;
            this.txt_usernameInventory.Lines = new string[0];
            this.txt_usernameInventory.Location = new System.Drawing.Point(401, 185);
            this.txt_usernameInventory.MaxLength = 32767;
            this.txt_usernameInventory.Name = "txt_usernameInventory";
            this.txt_usernameInventory.PasswordChar = '\0';
            this.txt_usernameInventory.PromptText = "Enter your username";
            this.txt_usernameInventory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_usernameInventory.SelectedText = "";
            this.txt_usernameInventory.SelectionLength = 0;
            this.txt_usernameInventory.SelectionStart = 0;
            this.txt_usernameInventory.ShortcutsEnabled = true;
            this.txt_usernameInventory.Size = new System.Drawing.Size(221, 23);
            this.txt_usernameInventory.TabIndex = 0;
            this.txt_usernameInventory.UseSelectable = true;
            this.txt_usernameInventory.WaterMark = "Enter your username";
            this.txt_usernameInventory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_usernameInventory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_inventory.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_inventory.Location = new System.Drawing.Point(88, 78);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(149, 25);
            this.lbl_inventory.TabIndex = 13;
            this.lbl_inventory.Text = "Inventory System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSourceInventory
            // 
            this.bindingSourceInventory.DataMember = "tbl_accounts";
            this.bindingSourceInventory.DataSource = this.cacDataSet;
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
            // ucAccount_inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_loginInventory);
            this.Controls.Add(this.lbl_passwordInventory);
            this.Controls.Add(this.lbl_usernameInventory);
            this.Controls.Add(this.txt_passwordInventory);
            this.Controls.Add(this.txt_usernameInventory);
            this.Controls.Add(this.lbl_inventory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucAccount_inventory";
            this.Size = new System.Drawing.Size(950, 520);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_loginInventory;
        private MetroFramework.Controls.MetroLabel lbl_passwordInventory;
        private MetroFramework.Controls.MetroLabel lbl_usernameInventory;
        private MetroFramework.Controls.MetroTextBox txt_passwordInventory;
        private MetroFramework.Controls.MetroTextBox txt_usernameInventory;
        private MetroFramework.Controls.MetroLabel lbl_inventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSourceInventory;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
    }
}
