namespace DoubleTCinema.View.Login
{
    partial class ucResetPassword
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.txtRePass = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.pbLock2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pbLock1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock1)).BeginInit();
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
            this.pnMain.Controls.Add(this.txtRePass);
            this.pnMain.Controls.Add(this.txtPass);
            this.pnMain.Controls.Add(this.lblResult);
            this.pnMain.Controls.Add(this.pbLock2);
            this.pnMain.Controls.Add(this.btnCancel);
            this.pnMain.Controls.Add(this.pbLock1);
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
            this.pnMain.TabIndex = 3;
            // 
            // txtRePass
            // 
            this.txtRePass.BackColor = System.Drawing.Color.White;
            this.txtRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRePass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRePass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtRePass.Location = new System.Drawing.Point(170, 302);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.SelectedText = "";
            this.txtRePass.Size = new System.Drawing.Size(324, 35);
            this.txtRePass.TabIndex = 17;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPass.Location = new System.Drawing.Point(170, 191);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(324, 35);
            this.txtPass.TabIndex = 16;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(166, 351);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(181, 19);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Mật khẩu không trùng khớp ";
            this.lblResult.Visible = false;
            // 
            // pbLock2
            // 
            this.pbLock2.Image = global::DoubleTCinema.Properties.Resources.icons8_lock_30;
            this.pbLock2.Location = new System.Drawing.Point(124, 299);
            this.pbLock2.Name = "pbLock2";
            this.pbLock2.ShadowDecoration.Parent = this.pbLock2;
            this.pbLock2.Size = new System.Drawing.Size(40, 40);
            this.pbLock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLock2.TabIndex = 13;
            this.pbLock2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(294, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(91, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // pbLock1
            // 
            this.pbLock1.Image = global::DoubleTCinema.Properties.Resources.icons8_lock_30;
            this.pbLock1.Location = new System.Drawing.Point(124, 187);
            this.pbLock1.Name = "pbLock1";
            this.pbLock1.ShadowDecoration.Parent = this.pbLock1;
            this.pbLock1.Size = new System.Drawing.Size(40, 40);
            this.pbLock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLock1.TabIndex = 8;
            this.pbLock1.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(391, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(103, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblTitle.Location = new System.Drawing.Point(77, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khôi phục mật khẩu";
            // 
            // ucResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Name = "ucResetPassword";
            this.Size = new System.Drawing.Size(625, 625);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2PictureBox pbLock2;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2PictureBox pbLock1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel lblResult;
        private Guna.UI.WinForms.GunaLineTextBox txtRePass;
        private Guna.UI.WinForms.GunaLineTextBox txtPass;
    }
}
