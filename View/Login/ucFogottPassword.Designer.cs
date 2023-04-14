namespace DoubleTCinema
{
    partial class ucFogottPassword
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
            this.btnSendMail = new Guna.UI2.WinForms.Guna2Button();
            this.pbMail = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNotification = new Guna.UI.WinForms.GunaLabel();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.BorderRadius = 20;
            this.btnSendMail.CheckedState.Parent = this.btnSendMail;
            this.btnSendMail.CustomImages.Parent = this.btnSendMail;
            this.btnSendMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnSendMail.Font = new System.Drawing.Font("Cambria", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.HoverState.Parent = this.btnSendMail;
            this.btnSendMail.Location = new System.Drawing.Point(302, 431);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.ShadowDecoration.Parent = this.btnSendMail;
            this.btnSendMail.Size = new System.Drawing.Size(170, 45);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Gửi mã";
            this.btnSendMail.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pbMail
            // 
            this.pbMail.Image = global::DoubleTCinema.Properties.Resources.icons8_mail_50;
            this.pbMail.Location = new System.Drawing.Point(102, 183);
            this.pbMail.Name = "pbMail";
            this.pbMail.ShadowDecoration.Parent = this.pbMail;
            this.pbMail.Size = new System.Drawing.Size(40, 40);
            this.pbMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMail.TabIndex = 8;
            this.pbMail.TabStop = false;
            // 
            // lblNotification
            // 
            this.lblNotification.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(102, 295);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(370, 120);
            this.lblNotification.TabIndex = 9;
            this.lblNotification.Text = "Chúng tôi sẽ gửi lại mã đặt lại thông qua email liên kết với tài khoản trên.";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.BorderColor = System.Drawing.Color.Gray;
            this.pnMain.BorderRadius = 20;
            this.pnMain.BorderThickness = 1;
            this.pnMain.Controls.Add(this.txtEmail);
            this.pnMain.Controls.Add(this.lblResult);
            this.pnMain.Controls.Add(this.btnBack);
            this.pnMain.Controls.Add(this.lblNotification);
            this.pnMain.Controls.Add(this.pbMail);
            this.pnMain.Controls.Add(this.btnSendMail);
            this.pnMain.Controls.Add(this.lblTitle);
            this.pnMain.Location = new System.Drawing.Point(20, 46);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.BorderRadius = 20;
            this.pnMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnMain.ShadowDecoration.Depth = 15;
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnMain.Size = new System.Drawing.Size(573, 515);
            this.pnMain.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(148, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(324, 35);
            this.txtEmail.TabIndex = 18;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(145, 236);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(284, 19);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Không tìm thấy tài khoản liên kết với mail trên";
            this.lblResult.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::DoubleTCinema.Properties.Resources.icons8_left_arrow_50;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(15, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(67, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblTitle.Location = new System.Drawing.Point(72, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khôi phục mật khẩu";
            // 
            // ucFogottPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Name = "ucFogottPassword";
            this.Size = new System.Drawing.Size(615, 615);
            ((System.ComponentModel.ISupportInitialize)(this.pbMail)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSendMail;
        private Guna.UI2.WinForms.Guna2PictureBox pbMail;
        private Guna.UI.WinForms.GunaLabel lblNotification;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel lblResult;
        private Guna.UI.WinForms.GunaLineTextBox txtEmail;
    }
}
