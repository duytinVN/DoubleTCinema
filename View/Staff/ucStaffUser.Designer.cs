namespace DoubleTCinema.View.Staff
{
    partial class ucStaffUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.dtvUser = new Guna.UI.WinForms.GunaDataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerbirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBCustomerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCustomerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(45, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(297, 35);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tìm kiếm";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dtvUser
            // 
            this.dtvUser.AllowUserToResizeColumns = false;
            this.dtvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtvUser.AutoGenerateColumns = false;
            this.dtvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvUser.BackgroundColor = System.Drawing.Color.White;
            this.dtvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtvUser.ColumnHeadersHeight = 21;
            this.dtvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customerbirthdayDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.customerphoneDataGridViewTextBoxColumn,
            this.customerpointsDataGridViewTextBoxColumn});
            this.dtvUser.DataSource = this.tBCustomerDTOBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtvUser.EnableHeadersVisualStyles = false;
            this.dtvUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvUser.Location = new System.Drawing.Point(-1, 84);
            this.dtvUser.Name = "dtvUser";
            this.dtvUser.ReadOnly = true;
            this.dtvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtvUser.RowHeadersVisible = false;
            this.dtvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUser.Size = new System.Drawing.Size(980, 565);
            this.dtvUser.TabIndex = 3;
            this.dtvUser.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtvUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtvUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtvUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtvUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtvUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtvUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtvUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtvUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtvUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtvUser.ThemeStyle.HeaderStyle.Height = 21;
            this.dtvUser.ThemeStyle.ReadOnly = true;
            this.dtvUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtvUser.ThemeStyle.RowsStyle.Height = 22;
            this.dtvUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.FillWeight = 50F;
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Width = 75;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.FillWeight = 10F;
            this.customernameDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.customernameDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customernameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customernameDataGridViewTextBoxColumn.Width = 225;
            // 
            // customerbirthdayDataGridViewTextBoxColumn
            // 
            this.customerbirthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerbirthdayDataGridViewTextBoxColumn.DataPropertyName = "customer_birthday";
            this.customerbirthdayDataGridViewTextBoxColumn.FillWeight = 50F;
            this.customerbirthdayDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.customerbirthdayDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.customerbirthdayDataGridViewTextBoxColumn.Name = "customerbirthdayDataGridViewTextBoxColumn";
            this.customerbirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerbirthdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerbirthdayDataGridViewTextBoxColumn.Width = 150;
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.FillWeight = 10F;
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.customeraddressDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeraddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customeraddressDataGridViewTextBoxColumn.Width = 250;
            // 
            // customerphoneDataGridViewTextBoxColumn
            // 
            this.customerphoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerphoneDataGridViewTextBoxColumn.DataPropertyName = "customer_phone";
            this.customerphoneDataGridViewTextBoxColumn.FillWeight = 10F;
            this.customerphoneDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.customerphoneDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.customerphoneDataGridViewTextBoxColumn.Name = "customerphoneDataGridViewTextBoxColumn";
            this.customerphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerphoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerphoneDataGridViewTextBoxColumn.Width = 175;
            // 
            // customerpointsDataGridViewTextBoxColumn
            // 
            this.customerpointsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerpointsDataGridViewTextBoxColumn.DataPropertyName = "customer_points";
            this.customerpointsDataGridViewTextBoxColumn.FillWeight = 10F;
            this.customerpointsDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.customerpointsDataGridViewTextBoxColumn.Name = "customerpointsDataGridViewTextBoxColumn";
            this.customerpointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerpointsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tBCustomerDTOBindingSource
            // 
            this.tBCustomerDTOBindingSource.DataSource = typeof(DTO1.TBCustomerDTO);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(174)))));
            this.btnEdit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::DoubleTCinema.Properties.Resources.icons8_edit_24;
            this.btnEdit.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEdit.Location = new System.Drawing.Point(478, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(110, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(174)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::DoubleTCinema.Properties.Resources.icons8_add_67;
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(348, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(124, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::DoubleTCinema.Properties.Resources.icons8_search_24;
            this.btnSearch.Location = new System.Drawing.Point(3, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(36, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucStaffUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtvUser);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucStaffUser";
            this.Size = new System.Drawing.Size(980, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCustomerDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI.WinForms.GunaDataGridView dtvUser;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.BindingSource tBCustomerDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerbirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerpointsDataGridViewTextBoxColumn;
    }
}
