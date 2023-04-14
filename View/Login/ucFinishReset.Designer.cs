namespace DoubleTCinema.View.Login
{
    partial class ucFinishReset
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
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnMain.SuspendLayout();
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
            this.pnMain.Controls.Add(this.lblResult);
            this.pnMain.Controls.Add(this.btnLogin);
            this.pnMain.Controls.Add(this.lblTitle);
            this.pnMain.Location = new System.Drawing.Point(21, 50);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.BorderRadius = 20;
            this.pnMain.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnMain.ShadowDecoration.Depth = 15;
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnMain.Size = new System.Drawing.Size(573, 515);
            this.pnMain.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResult.Location = new System.Drawing.Point(53, 207);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(474, 99);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Reset mật khẩu thành công vui lòng đăng nhập lại";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(280, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(197, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblTitle.Location = new System.Drawing.Point(53, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(474, 101);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khôi phục mật khẩu thành công";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucFinishReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Name = "ucFinishReset";
            this.Size = new System.Drawing.Size(615, 615);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI.WinForms.GunaLabel lblResult;
    }
}
