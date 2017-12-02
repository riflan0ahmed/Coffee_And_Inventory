namespace Coffee_And_Inventory
{
    partial class ucDashboardAdmin_sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.cacDataSet = new Coffee_And_Inventory.cacDataSet();
            this.tblsalessystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_salessystemTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_salessystemTableAdapter();
            this.sSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblItemCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSOrderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSQuatityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSSellingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSQTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSTotalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPaymentDocnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalessystemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSIDDataGridViewTextBoxColumn,
            this.tblItemCreationDataGridViewTextBoxColumn,
            this.sSDescriptionDataGridViewTextBoxColumn,
            this.sSOrderTypeDataGridViewTextBoxColumn,
            this.sSQuatityDataGridViewTextBoxColumn,
            this.sSSellingDataGridViewTextBoxColumn,
            this.sSDiscountDataGridViewTextBoxColumn,
            this.sSQTotalDataGridViewTextBoxColumn,
            this.sSTotalCostDataGridViewTextBoxColumn,
            this.tblPaymentDocnoDataGridViewTextBoxColumn,
            this.tblEidDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.tblsalessystemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 72);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(934, 403);
            this.metroGrid1.TabIndex = 0;
            // 
            // cacDataSet
            // 
            this.cacDataSet.DataSetName = "cacDataSet";
            this.cacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsalessystemBindingSource
            // 
            this.tblsalessystemBindingSource.DataMember = "tbl_salessystem";
            this.tblsalessystemBindingSource.DataSource = this.cacDataSet;
            // 
            // tbl_salessystemTableAdapter
            // 
            this.tbl_salessystemTableAdapter.ClearBeforeFill = true;
            // 
            // sSIDDataGridViewTextBoxColumn
            // 
            this.sSIDDataGridViewTextBoxColumn.DataPropertyName = "SS_ID";
            this.sSIDDataGridViewTextBoxColumn.HeaderText = "SS_ID";
            this.sSIDDataGridViewTextBoxColumn.Name = "sSIDDataGridViewTextBoxColumn";
            // 
            // tblItemCreationDataGridViewTextBoxColumn
            // 
            this.tblItemCreationDataGridViewTextBoxColumn.DataPropertyName = "tbl_ItemCreation";
            this.tblItemCreationDataGridViewTextBoxColumn.HeaderText = "tbl_ItemCreation";
            this.tblItemCreationDataGridViewTextBoxColumn.Name = "tblItemCreationDataGridViewTextBoxColumn";
            // 
            // sSDescriptionDataGridViewTextBoxColumn
            // 
            this.sSDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SS_Description";
            this.sSDescriptionDataGridViewTextBoxColumn.HeaderText = "SS_Description";
            this.sSDescriptionDataGridViewTextBoxColumn.Name = "sSDescriptionDataGridViewTextBoxColumn";
            // 
            // sSOrderTypeDataGridViewTextBoxColumn
            // 
            this.sSOrderTypeDataGridViewTextBoxColumn.DataPropertyName = "SS_Order_Type";
            this.sSOrderTypeDataGridViewTextBoxColumn.HeaderText = "SS_Order_Type";
            this.sSOrderTypeDataGridViewTextBoxColumn.Name = "sSOrderTypeDataGridViewTextBoxColumn";
            // 
            // sSQuatityDataGridViewTextBoxColumn
            // 
            this.sSQuatityDataGridViewTextBoxColumn.DataPropertyName = "SS_Quatity";
            this.sSQuatityDataGridViewTextBoxColumn.HeaderText = "SS_Quatity";
            this.sSQuatityDataGridViewTextBoxColumn.Name = "sSQuatityDataGridViewTextBoxColumn";
            // 
            // sSSellingDataGridViewTextBoxColumn
            // 
            this.sSSellingDataGridViewTextBoxColumn.DataPropertyName = "SS_Selling";
            this.sSSellingDataGridViewTextBoxColumn.HeaderText = "SS_Selling";
            this.sSSellingDataGridViewTextBoxColumn.Name = "sSSellingDataGridViewTextBoxColumn";
            // 
            // sSDiscountDataGridViewTextBoxColumn
            // 
            this.sSDiscountDataGridViewTextBoxColumn.DataPropertyName = "SS_Discount";
            this.sSDiscountDataGridViewTextBoxColumn.HeaderText = "SS_Discount";
            this.sSDiscountDataGridViewTextBoxColumn.Name = "sSDiscountDataGridViewTextBoxColumn";
            // 
            // sSQTotalDataGridViewTextBoxColumn
            // 
            this.sSQTotalDataGridViewTextBoxColumn.DataPropertyName = "SS_Q_Total";
            this.sSQTotalDataGridViewTextBoxColumn.HeaderText = "SS_Q_Total";
            this.sSQTotalDataGridViewTextBoxColumn.Name = "sSQTotalDataGridViewTextBoxColumn";
            // 
            // sSTotalCostDataGridViewTextBoxColumn
            // 
            this.sSTotalCostDataGridViewTextBoxColumn.DataPropertyName = "SS_Total_Cost";
            this.sSTotalCostDataGridViewTextBoxColumn.HeaderText = "SS_Total_Cost";
            this.sSTotalCostDataGridViewTextBoxColumn.Name = "sSTotalCostDataGridViewTextBoxColumn";
            // 
            // tblPaymentDocnoDataGridViewTextBoxColumn
            // 
            this.tblPaymentDocnoDataGridViewTextBoxColumn.DataPropertyName = "tbl_Payment_Doc_no";
            this.tblPaymentDocnoDataGridViewTextBoxColumn.HeaderText = "tbl_Payment_Doc_no";
            this.tblPaymentDocnoDataGridViewTextBoxColumn.Name = "tblPaymentDocnoDataGridViewTextBoxColumn";
            // 
            // tblEidDataGridViewTextBoxColumn
            // 
            this.tblEidDataGridViewTextBoxColumn.DataPropertyName = "tbl_E_id";
            this.tblEidDataGridViewTextBoxColumn.HeaderText = "tbl_E_id";
            this.tblEidDataGridViewTextBoxColumn.Name = "tblEidDataGridViewTextBoxColumn";
            // 
            // ucDashboardAdmin_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Name = "ucDashboardAdmin_sales";
            this.Size = new System.Drawing.Size(950, 520);
            this.Load += new System.EventHandler(this.ucDashboardAdmin_sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsalessystemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblItemCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSOrderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSQuatityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSSellingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSQTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSTotalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblPaymentDocnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblEidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblsalessystemBindingSource;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_salessystemTableAdapter tbl_salessystemTableAdapter;
    }
}
