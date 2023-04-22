namespace DoubleTCinema.View.Staff
{
    partial class frmPrintRecept
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
            this.tBTicketsDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBSeatBookingDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBTicketsDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSeatBookingDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBTicketsDTOBindingSource
            // 
            this.tBTicketsDTOBindingSource.DataSource = typeof(DTO1.TBTicketsDTO);
            // 
            // tBSeatBookingDTOBindingSource
            // 
            this.tBSeatBookingDTOBindingSource.DataSource = typeof(DTO1.TBSeatBookingDTO);
            // 
            // rvData
            // 
            this.rvData.LocalReport.ReportEmbeddedResource = "DoubleTCinema.View.Staff.ReportReceipt.rdlc";
            this.rvData.Location = new System.Drawing.Point(12, 12);
            this.rvData.Name = "rvData";
            this.rvData.ServerReport.BearerToken = null;
            this.rvData.Size = new System.Drawing.Size(966, 532);
            this.rvData.TabIndex = 2;
            this.rvData.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(112)))), ((int)(((byte)(182)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 550);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(152, 40);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Xuất vé ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmPrintRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 602);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.rvData);
            this.Name = "frmPrintRecept";
            this.Text = "frmPrintRecept";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrintRecept_FormClosed);
            this.Load += new System.EventHandler(this.frmPrintRecept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBTicketsDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSeatBookingDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tBTicketsDTOBindingSource;
        private System.Windows.Forms.BindingSource tBSeatBookingDTOBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvData;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}