namespace Coffee_And_Inventory
{
    partial class ucAccount_sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccount_sales));
            this.btn_loginSales = new MetroFramework.Controls.MetroButton();
            this.lbl_passwordSales = new MetroFramework.Controls.MetroLabel();
            this.lbl_usernameSales = new MetroFramework.Controls.MetroLabel();
            this.txt_passwordSales = new MetroFramework.Controls.MetroTextBox();
            this.txt_usernameSales = new MetroFramework.Controls.MetroTextBox();
            this.lbl_sales = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSourceSales = new System.Windows.Forms.BindingSource(this.components);
            this.cacDataSet = new Coffee_And_Inventory.cacDataSet();
            this.tbl_accountsTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_accountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_loginSales
            // 
            this.btn_loginSales.Location = new System.Drawing.Point(547, 280);
            this.btn_loginSales.Name = "btn_loginSales";
            this.btn_loginSales.Size = new System.Drawing.Size(75, 23);
            this.btn_loginSales.TabIndex = 3;
            this.btn_loginSales.Text = "Login";
            this.btn_loginSales.UseSelectable = true;
            this.btn_loginSales.Click += new System.EventHandler(this.btn_loginSales_Click);
            // 
            // lbl_passwordSales
            // 
            this.lbl_passwordSales.AutoSize = true;
            this.lbl_passwordSales.Location = new System.Drawing.Point(402, 224);
            this.lbl_passwordSales.Name = "lbl_passwordSales";
            this.lbl_passwordSales.Size = new System.Drawing.Size(63, 19);
            this.lbl_passwordSales.TabIndex = 5;
            this.lbl_passwordSales.Text = "Password";
            // 
            // lbl_usernameSales
            // 
            this.lbl_usernameSales.AutoSize = true;
            this.lbl_usernameSales.Location = new System.Drawing.Point(402, 160);
            this.lbl_usernameSales.Name = "lbl_usernameSales";
            this.lbl_usernameSales.Size = new System.Drawing.Size(68, 19);
            this.lbl_usernameSales.TabIndex = 4;
            this.lbl_usernameSales.Text = "Username";
            // 
            // txt_passwordSales
            // 
            // 
            // 
            // 
            this.txt_passwordSales.CustomButton.Image = null;
            this.txt_passwordSales.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_passwordSales.CustomButton.Name = "";
            this.txt_passwordSales.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_passwordSales.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_passwordSales.CustomButton.TabIndex = 1;
            this.txt_passwordSales.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_passwordSales.CustomButton.UseSelectable = true;
            this.txt_passwordSales.CustomButton.Visible = false;
            this.txt_passwordSales.Lines = new string[0];
            this.txt_passwordSales.Location = new System.Drawing.Point(402, 250);
            this.txt_passwordSales.MaxLength = 32767;
            this.txt_passwordSales.Name = "txt_passwordSales";
            this.txt_passwordSales.PasswordChar = '\0';
            this.txt_passwordSales.PromptText = "Enter your password";
            this.txt_passwordSales.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_passwordSales.SelectedText = "";
            this.txt_passwordSales.SelectionLength = 0;
            this.txt_passwordSales.SelectionStart = 0;
            this.txt_passwordSales.ShortcutsEnabled = true;
            this.txt_passwordSales.Size = new System.Drawing.Size(221, 23);
            this.txt_passwordSales.TabIndex = 2;
            this.txt_passwordSales.UseSelectable = true;
            this.txt_passwordSales.WaterMark = "Enter your password";
            this.txt_passwordSales.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_passwordSales.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_usernameSales
            // 
            // 
            // 
            // 
            this.txt_usernameSales.CustomButton.Image = null;
            this.txt_usernameSales.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txt_usernameSales.CustomButton.Name = "";
            this.txt_usernameSales.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_usernameSales.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_usernameSales.CustomButton.TabIndex = 1;
            this.txt_usernameSales.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_usernameSales.CustomButton.UseSelectable = true;
            this.txt_usernameSales.CustomButton.Visible = false;
            this.txt_usernameSales.Lines = new string[0];
            this.txt_usernameSales.Location = new System.Drawing.Point(402, 185);
            this.txt_usernameSales.MaxLength = 32767;
            this.txt_usernameSales.Name = "txt_usernameSales";
            this.txt_usernameSales.PasswordChar = '\0';
            this.txt_usernameSales.PromptText = "Enter your username";
            this.txt_usernameSales.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_usernameSales.SelectedText = "";
            this.txt_usernameSales.SelectionLength = 0;
            this.txt_usernameSales.SelectionStart = 0;
            this.txt_usernameSales.ShortcutsEnabled = true;
            this.txt_usernameSales.Size = new System.Drawing.Size(221, 23);
            this.txt_usernameSales.TabIndex = 1;
            this.txt_usernameSales.UseSelectable = true;
            this.txt_usernameSales.WaterMark = "Enter your username";
            this.txt_usernameSales.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_usernameSales.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_sales
            // 
            this.lbl_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_sales.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_sales.Location = new System.Drawing.Point(89, 78);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(106, 25);
            this.lbl_sales.TabIndex = 6;
            this.lbl_sales.Text = "Sale System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSourceSales
            // 
            this.bindingSourceSales.DataMember = "tbl_accounts";
            this.bindingSourceSales.DataSource = this.cacDataSet;
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
            // ucAccount_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_loginSales);
            this.Controls.Add(this.lbl_passwordSales);
            this.Controls.Add(this.lbl_usernameSales);
            this.Controls.Add(this.txt_passwordSales);
            this.Controls.Add(this.txt_usernameSales);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucAccount_sales";
            this.Size = new System.Drawing.Size(950, 520);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_loginSales;
        private MetroFramework.Controls.MetroLabel lbl_passwordSales;
        private MetroFramework.Controls.MetroLabel lbl_usernameSales;
        private MetroFramework.Controls.MetroTextBox txt_passwordSales;
        private MetroFramework.Controls.MetroTextBox txt_usernameSales;
        private MetroFramework.Controls.MetroLabel lbl_sales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSourceSales;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_accountsTableAdapter tbl_accountsTableAdapter;
    }
}
