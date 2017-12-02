namespace Coffee_And_Inventory
{
    partial class ucDashboardAdmin_employee
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
            this.mtAdmin_employee = new MetroFramework.Controls.MetroGrid();
            this.cacDataSet = new Coffee_And_Inventory.cacDataSet();
            this.tblemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_employeeTableAdapter = new Coffee_And_Inventory.cacDataSetTableAdapters.tbl_employeeTableAdapter();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eEnrolnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mtAdmin_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdmin_employee
            // 
            this.mtAdmin_employee.AllowUserToResizeRows = false;
            this.mtAdmin_employee.AutoGenerateColumns = false;
            this.mtAdmin_employee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtAdmin_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtAdmin_employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtAdmin_employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtAdmin_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mtAdmin_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtAdmin_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.eEnrolnoDataGridViewTextBoxColumn,
            this.eNameDataGridViewTextBoxColumn,
            this.eDOBDataGridViewTextBoxColumn,
            this.eGenderDataGridViewTextBoxColumn,
            this.eTelephoneDataGridViewTextBoxColumn});
            this.mtAdmin_employee.DataSource = this.tblemployeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtAdmin_employee.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtAdmin_employee.EnableHeadersVisualStyles = false;
            this.mtAdmin_employee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtAdmin_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtAdmin_employee.Location = new System.Drawing.Point(16, 78);
            this.mtAdmin_employee.Name = "mtAdmin_employee";
            this.mtAdmin_employee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtAdmin_employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mtAdmin_employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtAdmin_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtAdmin_employee.Size = new System.Drawing.Size(687, 394);
            this.mtAdmin_employee.TabIndex = 0;
            // 
            // cacDataSet
            // 
            this.cacDataSet.DataSetName = "cacDataSet";
            this.cacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblemployeeBindingSource
            // 
            this.tblemployeeBindingSource.DataMember = "tbl_employee";
            this.tblemployeeBindingSource.DataSource = this.cacDataSet;
            // 
            // tbl_employeeTableAdapter
            // 
            this.tbl_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "E_id";
            this.eidDataGridViewTextBoxColumn.HeaderText = "E_id";
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            // 
            // eEnrolnoDataGridViewTextBoxColumn
            // 
            this.eEnrolnoDataGridViewTextBoxColumn.DataPropertyName = "E_Enrol_no";
            this.eEnrolnoDataGridViewTextBoxColumn.HeaderText = "E_Enrol_no";
            this.eEnrolnoDataGridViewTextBoxColumn.Name = "eEnrolnoDataGridViewTextBoxColumn";
            // 
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "E_Name";
            this.eNameDataGridViewTextBoxColumn.HeaderText = "E_Name";
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            // 
            // eDOBDataGridViewTextBoxColumn
            // 
            this.eDOBDataGridViewTextBoxColumn.DataPropertyName = "E_DOB";
            this.eDOBDataGridViewTextBoxColumn.HeaderText = "E_DOB";
            this.eDOBDataGridViewTextBoxColumn.Name = "eDOBDataGridViewTextBoxColumn";
            // 
            // eGenderDataGridViewTextBoxColumn
            // 
            this.eGenderDataGridViewTextBoxColumn.DataPropertyName = "E_Gender";
            this.eGenderDataGridViewTextBoxColumn.HeaderText = "E_Gender";
            this.eGenderDataGridViewTextBoxColumn.Name = "eGenderDataGridViewTextBoxColumn";
            // 
            // eTelephoneDataGridViewTextBoxColumn
            // 
            this.eTelephoneDataGridViewTextBoxColumn.DataPropertyName = "E_Telephone";
            this.eTelephoneDataGridViewTextBoxColumn.HeaderText = "E_Telephone";
            this.eTelephoneDataGridViewTextBoxColumn.Name = "eTelephoneDataGridViewTextBoxColumn";
            // 
            // ucDashboardAdmin_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtAdmin_employee);
            this.Name = "ucDashboardAdmin_employee";
            this.Size = new System.Drawing.Size(950, 520);
            ((System.ComponentModel.ISupportInitialize)(this.mtAdmin_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mtAdmin_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEnrolnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource;
        private cacDataSet cacDataSet;
        private cacDataSetTableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter;
    }
}
