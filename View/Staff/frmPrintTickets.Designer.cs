namespace DoubleTCinema.View.Staff
{
    partial class frmPrintTickets
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rvTickets = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tBTicketsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tBTicketsDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvTickets
            // 
            this.rvTickets.LocalReport.ReportEmbeddedResource = "DoubleTCinema.View.Staff.ReportTicket.rdlc";
            this.rvTickets.Location = new System.Drawing.Point(-1, 71);
            this.rvTickets.Name = "rvTickets";
            this.rvTickets.ServerReport.BearerToken = null;
            this.rvTickets.Size = new System.Drawing.Size(757, 426);
            this.rvTickets.TabIndex = 0;
            this.rvTickets.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // cbbItems
            // 
            this.cbbItems.BackColor = System.Drawing.Color.Transparent;
            this.cbbItems.DataSource = this.tBTicketsDTOBindingSource;
            this.cbbItems.DisplayMember = "ticket_id";
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
            this.cbbItems.Location = new System.Drawing.Point(12, 12);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.ShadowDecoration.Parent = this.cbbItems;
            this.cbbItems.Size = new System.Drawing.Size(193, 36);
            this.cbbItems.TabIndex = 1;
            this.cbbItems.ValueMember = "ticket_id";
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
            this.btnSearch.Location = new System.Drawing.Point(211, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(35, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tBTicketsDTOBindingSource
            // 
            this.tBTicketsDTOBindingSource.DataSource = typeof(DTO1.TBTicketsDTO);
            // 
            // frmPrintTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 497);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbItems);
            this.Controls.Add(this.rvTickets);
            this.Name = "frmPrintTickets";
            this.Text = "frmPrintTickets";
            this.Load += new System.EventHandler(this.frmPrintTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBTicketsDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTickets;
        private Guna.UI2.WinForms.Guna2ComboBox cbbItems;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.BindingSource tBTicketsDTOBindingSource;
    }
}