namespace DoubleTCinema.View.Staff
{
    partial class ucStatistical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbChoose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTimes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtvView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbbItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbChoose
            // 
            this.cbbChoose.BackColor = System.Drawing.Color.Transparent;
            this.cbbChoose.BorderRadius = 5;
            this.cbbChoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChoose.FocusedColor = System.Drawing.Color.Empty;
            this.cbbChoose.FocusedState.Parent = this.cbbChoose;
            this.cbbChoose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbChoose.FormattingEnabled = true;
            this.cbbChoose.HoverState.Parent = this.cbbChoose;
            this.cbbChoose.ItemHeight = 30;
            this.cbbChoose.Items.AddRange(new object[] {
            "Phim",
            "Khách hàng"});
            this.cbbChoose.ItemsAppearance.Parent = this.cbbChoose;
            this.cbbChoose.Location = new System.Drawing.Point(20, 91);
            this.cbbChoose.Name = "cbbChoose";
            this.cbbChoose.ShadowDecoration.Parent = this.cbbChoose;
            this.cbbChoose.Size = new System.Drawing.Size(154, 36);
            this.cbbChoose.TabIndex = 3;
            // 
            // cbbTimes
            // 
            this.cbbTimes.BackColor = System.Drawing.Color.Transparent;
            this.cbbTimes.BorderRadius = 5;
            this.cbbTimes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimes.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTimes.FocusedState.Parent = this.cbbTimes;
            this.cbbTimes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTimes.FormattingEnabled = true;
            this.cbbTimes.HoverState.Parent = this.cbbTimes;
            this.cbbTimes.ItemHeight = 30;
            this.cbbTimes.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cbbTimes.ItemsAppearance.Parent = this.cbbTimes;
            this.cbbTimes.Location = new System.Drawing.Point(265, 91);
            this.cbbTimes.Name = "cbbTimes";
            this.cbbTimes.ShadowDecoration.Parent = this.cbbTimes;
            this.cbbTimes.Size = new System.Drawing.Size(140, 36);
            this.cbbTimes.TabIndex = 4;
            this.cbbTimes.SelectedIndexChanged += new System.EventHandler(this.cbbTimes_SelectedIndexChanged);
            // 
            // dtvView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtvView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvView.BackgroundColor = System.Drawing.Color.White;
            this.dtvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtvView.EnableHeadersVisualStyles = false;
            this.dtvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvView.Location = new System.Drawing.Point(0, 182);
            this.dtvView.Name = "dtvView";
            this.dtvView.RowHeadersVisible = false;
            this.dtvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvView.Size = new System.Drawing.Size(980, 468);
            this.dtvView.TabIndex = 5;
            this.dtvView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtvView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtvView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtvView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtvView.ThemeStyle.HeaderStyle.Height = 4;
            this.dtvView.ThemeStyle.ReadOnly = false;
            this.dtvView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtvView.ThemeStyle.RowsStyle.Height = 22;
            this.dtvView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbbItems
            // 
            this.cbbItems.BackColor = System.Drawing.Color.Transparent;
            this.cbbItems.BorderRadius = 5;
            this.cbbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbItems.FocusedColor = System.Drawing.Color.Empty;
            this.cbbItems.FocusedState.Parent = this.cbbItems;
            this.cbbItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbItems.FormattingEnabled = true;
            this.cbbItems.HoverState.Parent = this.cbbItems;
            this.cbbItems.ItemHeight = 30;
            this.cbbItems.ItemsAppearance.Parent = this.cbbItems;
            this.cbbItems.Location = new System.Drawing.Point(510, 91);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.ShadowDecoration.Parent = this.cbbItems;
            this.cbbItems.Size = new System.Drawing.Size(140, 36);
            this.cbbItems.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(154, 43);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Thống kê";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtvView);
            this.Controls.Add(this.cbbItems);
            this.Controls.Add(this.cbbTimes);
            this.Controls.Add(this.cbbChoose);
            this.Name = "ucStatistical";
            this.Size = new System.Drawing.Size(980, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dtvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbbChoose;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTimes;
        private Guna.UI2.WinForms.Guna2DataGridView dtvView;
        private Guna.UI2.WinForms.Guna2ComboBox cbbItems;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Button button1;
    }
}
