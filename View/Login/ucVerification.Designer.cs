namespace DoubleTCinema
{
    partial class ucVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVerification));
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.txtVerification = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnComeback = new Guna.UI2.WinForms.Guna2Button();
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.btnNotification = new Guna.UI.WinForms.GunaLabel();
            this.pbLock = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.SuspendLayout();
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
            this.pnMain.Controls.Add(this.txtVerification);
            this.pnMain.Controls.Add(this.btnComeback);
            this.pnMain.Controls.Add(this.lblResult);
            this.pnMain.Controls.Add(this.btnNotification);
            this.pnMain.Controls.Add(this.pbLock);
            this.pnMain.Controls.Add(this.btnSave);
            this.pnMain.Controls.Add(this.lblTitle);
            this.pnMain.Location = new System.Drawing.Point(21, 50);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.BorderRadius = 20;
            this.pnMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnMain.ShadowDecoration.Depth = 15;
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnMain.Size = new System.Drawing.Size(583, 525);
            this.pnMain.TabIndex = 2;
            // 
            // txtVerification
            // 
            this.txtVerification.BackColor = System.Drawing.Color.White;
            this.txtVerification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVerification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerification.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtVerification.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerification.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtVerification.LineColor = System.Drawing.Color.Gainsboro;
            this.txtVerification.Location = new System.Drawing.Point(149, 186);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.PasswordChar = '\0';
            this.txtVerification.SelectedText = "";
            this.txtVerification.Size = new System.Drawing.Size(303, 35);
            this.txtVerification.TabIndex = 19;
            // 
            // btnComeback
            // 
            this.btnComeback.CheckedState.Parent = this.btnComeback;
            this.btnComeback.CustomImages.Parent = this.btnComeback;
            this.btnComeback.FillColor = System.Drawing.Color.White;
            this.btnComeback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComeback.ForeColor = System.Drawing.Color.White;
            this.btnComeback.HoverState.Parent = this.btnComeback;
            this.btnComeback.Image = ((System.Drawing.Image)(resources.GetObject("btnComeback.Image")));
            this.btnComeback.ImageSize = new System.Drawing.Size(30, 30);
            this.btnComeback.Location = new System.Drawing.Point(13, 14);
            this.btnComeback.Name = "btnComeback";
            this.btnComeback.ShadowDecoration.Parent = this.btnComeback;
            this.btnComeback.Size = new System.Drawing.Size(67, 35);
            this.btnComeback.TabIndex = 11;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(145, 240);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(288, 19);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Mã xác nhận không chính xác vui lòng nhập lại";
            this.lblResult.Visible = false;
            // 
            // btnNotification
            // 
            this.btnNotification.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.Location = new System.Drawing.Point(102, 259);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(370, 120);
            this.btnNotification.TabIndex = 9;
            this.btnNotification.Text = "Nhập mã xác nhận đã gửi qua email";
            this.btnNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLock
            // 
            this.pbLock.Image = global::DoubleTCinema.Properties.Resources.icons8_lock_30;
            this.pbLock.Location = new System.Drawing.Point(102, 183);
            this.pbLock.Name = "pbLock";
            this.pbLock.ShadowDecoration.Parent = this.pbLock;
            this.pbLock.Size = new System.Drawing.Size(40, 40);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLock.TabIndex = 8;
            this.pbLock.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnSave.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(290, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(182, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Xác nhận";
            this.btnSave.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // ucVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Name = "ucVerification";
            this.Size = new System.Drawing.Size(625, 625);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI.WinForms.GunaLabel btnNotification;
        private Guna.UI2.WinForms.Guna2PictureBox pbLock;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel lblResult;
        private Guna.UI2.WinForms.Guna2Button btnComeback;
        private Guna.UI.WinForms.GunaLineTextBox txtVerification;
    }
}
