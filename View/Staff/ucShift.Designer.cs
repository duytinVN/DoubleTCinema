namespace DoubleTCinema.View.Staff
{
    partial class ucShift
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtvShift = new Guna.UI2.WinForms.Guna2DataGridView();
            this.shiftidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shifttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBShiftDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtvShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBShiftDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(174, 48);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Lịch trực";
            // 
            // dtpDate
            // 
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.FillColor = System.Drawing.Color.Transparent;
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(34, 98);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(200, 36);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2023, 5, 13, 7, 48, 51, 619);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtvShift
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtvShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvShift.AutoGenerateColumns = false;
            this.dtvShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvShift.BackgroundColor = System.Drawing.Color.White;
            this.dtvShift.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvShift.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvShift.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftidDataGridViewTextBoxColumn,
            this.shiftdateDataGridViewTextBoxColumn,
            this.shifttimeDataGridViewTextBoxColumn,
            this.staffnameDataGridViewTextBoxColumn});
            this.dtvShift.DataSource = this.tBShiftDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvShift.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtvShift.EnableHeadersVisualStyles = false;
            this.dtvShift.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvShift.Location = new System.Drawing.Point(0, 214);
            this.dtvShift.Name = "dtvShift";
            this.dtvShift.ReadOnly = true;
            this.dtvShift.RowHeadersVisible = false;
            this.dtvShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvShift.Size = new System.Drawing.Size(980, 436);
            this.dtvShift.TabIndex = 2;
            this.dtvShift.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtvShift.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvShift.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtvShift.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtvShift.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtvShift.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtvShift.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtvShift.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvShift.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtvShift.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtvShift.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvShift.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtvShift.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtvShift.ThemeStyle.HeaderStyle.Height = 23;
            this.dtvShift.ThemeStyle.ReadOnly = true;
            this.dtvShift.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvShift.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvShift.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvShift.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtvShift.ThemeStyle.RowsStyle.Height = 22;
            this.dtvShift.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvShift.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // shiftidDataGridViewTextBoxColumn
            // 
            this.shiftidDataGridViewTextBoxColumn.DataPropertyName = "shift_id";
            this.shiftidDataGridViewTextBoxColumn.HeaderText = "Id Lịch trực";
            this.shiftidDataGridViewTextBoxColumn.Name = "shiftidDataGridViewTextBoxColumn";
            this.shiftidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftdateDataGridViewTextBoxColumn
            // 
            this.shiftdateDataGridViewTextBoxColumn.DataPropertyName = "shift_date";
            this.shiftdateDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.shiftdateDataGridViewTextBoxColumn.Name = "shiftdateDataGridViewTextBoxColumn";
            this.shiftdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shifttimeDataGridViewTextBoxColumn
            // 
            this.shifttimeDataGridViewTextBoxColumn.DataPropertyName = "shift_time";
            this.shifttimeDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.shifttimeDataGridViewTextBoxColumn.Name = "shifttimeDataGridViewTextBoxColumn";
            this.shifttimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffnameDataGridViewTextBoxColumn
            // 
            this.staffnameDataGridViewTextBoxColumn.DataPropertyName = "staff_name";
            this.staffnameDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.staffnameDataGridViewTextBoxColumn.Name = "staffnameDataGridViewTextBoxColumn";
            this.staffnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBShiftDTOBindingSource
            // 
            this.tBShiftDTOBindingSource.DataSource = typeof(DTO1.TBShiftDTO);
            // 
            // ucShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtvShift);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ucShift";
            this.Size = new System.Drawing.Size(980, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dtvShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBShiftDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dtvShift;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shifttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBShiftDTOBindingSource;
    }
}
