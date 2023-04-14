namespace DoubleTCinema.View.Staff
{
    partial class ucMovieBooking
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
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.cboCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dpkTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnMovie = new Guna.UI.WinForms.GunaLinePanel();
            this.pbcombo = new Guna.UI.WinForms.GunaPictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phim đang chiếu";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(63, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(285, 35);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Tìm kiếm phim";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.Transparent;
            this.cboCategory.BorderThickness = 0;
            this.cboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.DropDownWidth = 199;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cboCategory.FocusedState.Parent = this.cboCategory;
            this.cboCategory.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.HoverState.Parent = this.cboCategory;
            this.cboCategory.ItemHeight = 30;
            this.cboCategory.ItemsAppearance.Parent = this.cboCategory;
            this.cboCategory.Location = new System.Drawing.Point(427, 75);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.ShadowDecoration.Parent = this.cboCategory;
            this.cboCategory.Size = new System.Drawing.Size(179, 36);
            this.cboCategory.TabIndex = 4;
            // 
            // dpkTime
            // 
            this.dpkTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dpkTime.CheckedState.Parent = this.dpkTime;
            this.dpkTime.FillColor = System.Drawing.Color.Transparent;
            this.dpkTime.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.dpkTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkTime.HoverState.Parent = this.dpkTime;
            this.dpkTime.Location = new System.Drawing.Point(685, 78);
            this.dpkTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkTime.Name = "dpkTime";
            this.dpkTime.ShadowDecoration.Parent = this.dpkTime;
            this.dpkTime.Size = new System.Drawing.Size(185, 33);
            this.dpkTime.TabIndex = 5;
            this.dpkTime.Value = new System.DateTime(2023, 4, 13, 0, 0, 0, 0);
            // 
            // pnMovie
            // 
            this.pnMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMovie.LineColor = System.Drawing.Color.Black;
            this.pnMovie.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnMovie.Location = new System.Drawing.Point(0, 117);
            this.pnMovie.Name = "pnMovie";
            this.pnMovie.Size = new System.Drawing.Size(980, 530);
            this.pnMovie.TabIndex = 6;
            // 
            // pbcombo
            // 
            this.pbcombo.BaseColor = System.Drawing.Color.White;
            this.pbcombo.Image = global::DoubleTCinema.Properties.Resources.icons8_funnel_50;
            this.pbcombo.Location = new System.Drawing.Point(377, 78);
            this.pbcombo.Name = "pbcombo";
            this.pbcombo.Size = new System.Drawing.Size(30, 30);
            this.pbcombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcombo.TabIndex = 3;
            this.pbcombo.TabStop = false;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::DoubleTCinema.Properties.Resources.icons8_search_24;
            this.pbSearch.Location = new System.Drawing.Point(27, 78);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(30, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 1;
            this.pbSearch.TabStop = false;
            // 
            // ucMovieBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMovie);
            this.Controls.Add(this.dpkTime);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.pbcombo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucMovieBooking";
            this.Size = new System.Drawing.Size(980, 650);
            
            ((System.ComponentModel.ISupportInitialize)(this.pbcombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI.WinForms.GunaPictureBox pbcombo;
        private Guna.UI2.WinForms.Guna2ComboBox cboCategory;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpkTime;
        private Guna.UI.WinForms.GunaLinePanel pnMovie;
    }
}
