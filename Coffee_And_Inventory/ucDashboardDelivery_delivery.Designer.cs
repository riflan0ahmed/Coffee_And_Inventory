namespace Coffee_And_Inventory
{
    partial class ucDashboardDelivery_delivery
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
            this.tbldeliverysystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_deliverysystemTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_deliverysystemTableAdapter();
            this.dSItemcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSDatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTimeTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTimeGivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSItemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSDeliveryPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSTotalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblsalessystemSSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeliverysystemBindingSource)).BeginInit();
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
            this.dSItemcodeDataGridViewTextBoxColumn,
            this.dSDescriptionDataGridViewTextBoxColumn,
            this.dSDatelDataGridViewTextBoxColumn,
            this.dSTimeTakenDataGridViewTextBoxColumn,
            this.dSTimeGivenDataGridViewTextBoxColumn,
            this.dSItemPriceDataGridViewTextBoxColumn,
            this.dSDeliveryPriceDataGridViewTextBoxColumn,
            this.dSTotalCostDataGridViewTextBoxColumn,
            this.tblsalessystemSSIDDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.tbldeliverysystemBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(17, 15);
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
            this.metroGrid1.Size = new System.Drawing.Size(914, 443);
            this.metroGrid1.TabIndex = 0;
            // 
            // cacDataSet
            // 
            this.cacDataSet.DataSetName = "cacDataSet";
            this.cacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldeliverysystemBindingSource
            // 
            this.tbldeliverysystemBindingSource.DataMember = "tbl_deliverysystem";
            this.tbldeliverysystemBindingSource.DataSource = this.cacDataSet;
            // 
            // tbl_deliverysystemTableAdapter
            // 
            this.tbl_deliverysystemTableAdapter.ClearBeforeFill = true;
            // 
            // dSItemcodeDataGridViewTextBoxColumn
            // 
            this.dSItemcodeDataGridViewTextBoxColumn.DataPropertyName = "DS_Item_code";
            this.dSItemcodeDataGridViewTextBoxColumn.HeaderText = "DS_Item_code";
            this.dSItemcodeDataGridViewTextBoxColumn.Name = "dSItemcodeDataGridViewTextBoxColumn";
            // 
            // dSDescriptionDataGridViewTextBoxColumn
            // 
            this.dSDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DS_Description";
            this.dSDescriptionDataGridViewTextBoxColumn.HeaderText = "DS_Description";
            this.dSDescriptionDataGridViewTextBoxColumn.Name = "dSDescriptionDataGridViewTextBoxColumn";
            // 
            // dSDatelDataGridViewTextBoxColumn
            // 
            this.dSDatelDataGridViewTextBoxColumn.DataPropertyName = "DS_Datel";
            this.dSDatelDataGridViewTextBoxColumn.HeaderText = "DS_Datel";
            this.dSDatelDataGridViewTextBoxColumn.Name = "dSDatelDataGridViewTextBoxColumn";
            // 
            // dSTimeTakenDataGridViewTextBoxColumn
            // 
            this.dSTimeTakenDataGridViewTextBoxColumn.DataPropertyName = "DS_Time_Taken";
            this.dSTimeTakenDataGridViewTextBoxColumn.HeaderText = "DS_Time_Taken";
            this.dSTimeTakenDataGridViewTextBoxColumn.Name = "dSTimeTakenDataGridViewTextBoxColumn";
            // 
            // dSTimeGivenDataGridViewTextBoxColumn
            // 
            this.dSTimeGivenDataGridViewTextBoxColumn.DataPropertyName = "DS_Time_Given";
            this.dSTimeGivenDataGridViewTextBoxColumn.HeaderText = "DS_Time_Given";
            this.dSTimeGivenDataGridViewTextBoxColumn.Name = "dSTimeGivenDataGridViewTextBoxColumn";
            // 
            // dSItemPriceDataGridViewTextBoxColumn
            // 
            this.dSItemPriceDataGridViewTextBoxColumn.DataPropertyName = "DS_Item_Price";
            this.dSItemPriceDataGridViewTextBoxColumn.HeaderText = "DS_Item_Price";
            this.dSItemPriceDataGridViewTextBoxColumn.Name = "dSItemPriceDataGridViewTextBoxColumn";
            // 
            // dSDeliveryPriceDataGridViewTextBoxColumn
            // 
            this.dSDeliveryPriceDataGridViewTextBoxColumn.DataPropertyName = "DS_Delivery_Price";
            this.dSDeliveryPriceDataGridViewTextBoxColumn.HeaderText = "DS_Delivery_Price";
            this.dSDeliveryPriceDataGridViewTextBoxColumn.Name = "dSDeliveryPriceDataGridViewTextBoxColumn";
            // 
            // dSTotalCostDataGridViewTextBoxColumn
            // 
            this.dSTotalCostDataGridViewTextBoxColumn.DataPropertyName = "DS_Total_Cost";
            this.dSTotalCostDataGridViewTextBoxColumn.HeaderText = "DS_Total_Cost";
            this.dSTotalCostDataGridViewTextBoxColumn.Name = "dSTotalCostDataGridViewTextBoxColumn";
            // 
            // tblsalessystemSSIDDataGridViewTextBoxColumn
            // 
            this.tblsalessystemSSIDDataGridViewTextBoxColumn.DataPropertyName = "tbl_salessystem_SS_ID";
            this.tblsalessystemSSIDDataGridViewTextBoxColumn.HeaderText = "tbl_salessystem_SS_ID";
            this.tblsalessystemSSIDDataGridViewTextBoxColumn.Name = "tblsalessystemSSIDDataGridViewTextBoxColumn";
            // 
            // ucDashboardDelivery_delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Name = "ucDashboardDelivery_delivery";
            this.Size = new System.Drawing.Size(950, 520);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeliverysystemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSItemcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSDatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSTimeTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSTimeGivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSItemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSDeliveryPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSTotalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblsalessystemSSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbldeliverysystemBindingSource;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_deliverysystemTableAdapter tbl_deliverysystemTableAdapter;
    }
}
