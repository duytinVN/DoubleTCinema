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
            this.cbbGenges = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnMovie = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenre = new Guna.UI2.WinForms.Guna2Button();
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
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(63, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(285, 35);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Tìm kiếm phim";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // cbbGenges
            // 
            this.cbbGenges.BackColor = System.Drawing.Color.Transparent;
            this.cbbGenges.BorderThickness = 0;
            this.cbbGenges.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGenges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenges.DropDownWidth = 199;
            this.cbbGenges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbGenges.FocusedColor = System.Drawing.Color.Empty;
            this.cbbGenges.FocusedState.Parent = this.cbbGenges;
            this.cbbGenges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbGenges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbGenges.FormattingEnabled = true;
            this.cbbGenges.HoverState.Parent = this.cbbGenges;
            this.cbbGenges.ItemHeight = 30;
            this.cbbGenges.ItemsAppearance.Parent = this.cbbGenges;
            this.cbbGenges.Location = new System.Drawing.Point(408, 75);
            this.cbbGenges.Name = "cbbGenges";
            this.cbbGenges.ShadowDecoration.Parent = this.cbbGenges;
            this.cbbGenges.Size = new System.Drawing.Size(251, 36);
            this.cbbGenges.TabIndex = 4;
            this.cbbGenges.SelectedIndexChanged += new System.EventHandler(this.cbbGenges_SelectedIndexChanged);
            // 
            // pnMovie
            // 
            this.pnMovie.AutoScroll = true;
            this.pnMovie.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.pnMovie.Location = new System.Drawing.Point(0, 117);
            this.pnMovie.Name = "pnMovie";
            this.pnMovie.ShadowDecoration.Parent = this.pnMovie;
            this.pnMovie.Size = new System.Drawing.Size(980, 533);
            this.pnMovie.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::DoubleTCinema.Properties.Resources.icons8_search_24;
            this.guna2Button1.Location = new System.Drawing.Point(22, 78);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(35, 32);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.CheckedState.Parent = this.btnGenre;
            this.btnGenre.CustomImages.Parent = this.btnGenre;
            this.btnGenre.FillColor = System.Drawing.Color.Transparent;
            this.btnGenre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenre.ForeColor = System.Drawing.Color.White;
            this.btnGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenre.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenre.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btnGenre.HoverState.Parent = this.btnGenre;
            this.btnGenre.Image = global::DoubleTCinema.Properties.Resources.icons8_funnel_50;
            this.btnGenre.Location = new System.Drawing.Point(367, 78);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.ShadowDecoration.Parent = this.btnGenre;
            this.btnGenre.Size = new System.Drawing.Size(35, 32);
            this.btnGenre.TabIndex = 7;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // ucMovieBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pnMovie);
            this.Controls.Add(this.cbbGenges);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucMovieBooking";
            this.Size = new System.Drawing.Size(980, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGenges;
        private Guna.UI2.WinForms.Guna2Panel pnMovie;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnGenre;
    }
}
