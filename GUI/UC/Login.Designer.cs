namespace DoubleTCinema
{
    partial class ucLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLogin));
            this.pnLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPassWord = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblResult = new Guna.UI.WinForms.GunaLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lblFogotPassword = new System.Windows.Forms.Label();
            this.pbPassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pbLogin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnLogin.BorderColor = System.Drawing.Color.Gray;
            this.pnLogin.BorderRadius = 20;
            this.pnLogin.BorderThickness = 1;
            this.pnLogin.Controls.Add(this.txtPassWord);
            this.pnLogin.Controls.Add(this.txtUser);
            this.pnLogin.Controls.Add(this.lblResult);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.lblFogotPassword);
            this.pnLogin.Controls.Add(this.pbPassword);
            this.pnLogin.Controls.Add(this.pbLogin);
            this.pnLogin.Controls.Add(this.lblWelcome);
            this.pnLogin.Location = new System.Drawing.Point(20, 46);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.ShadowDecoration.BorderRadius = 20;
            this.pnLogin.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnLogin.ShadowDecoration.Depth = 15;
            this.pnLogin.ShadowDecoration.Parent = this.pnLogin;
            this.pnLogin.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnLogin.Size = new System.Drawing.Size(573, 515);
            this.pnLogin.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.White;
            this.txtPassWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPassWord.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPassWord.Location = new System.Drawing.Point(168, 293);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(303, 35);
            this.txtPassWord.TabIndex = 18;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.LineColor = System.Drawing.Color.Gainsboro;
            this.txtUser.Location = new System.Drawing.Point(168, 202);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(303, 35);
            this.txtUser.TabIndex = 17;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(165, 343);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(291, 19);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            this.lblResult.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(132, 440);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(340, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFogotPassword
            // 
            this.lblFogotPassword.AutoSize = true;
            this.lblFogotPassword.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFogotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.lblFogotPassword.Location = new System.Drawing.Point(269, 375);
            this.lblFogotPassword.Name = "lblFogotPassword";
            this.lblFogotPassword.Size = new System.Drawing.Size(203, 35);
            this.lblFogotPassword.TabIndex = 6;
            this.lblFogotPassword.Text = "Quên mật khẩu";
            this.lblFogotPassword.Click += new System.EventHandler(this.lblFogotPassword_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.BaseColor = System.Drawing.Color.White;
            this.pbPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbPassword.Image")));
            this.pbPassword.Location = new System.Drawing.Point(132, 295);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(30, 30);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPassword.TabIndex = 3;
            this.pbPassword.TabStop = false;
            this.pbPassword.UseTransfarantBackground = false;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(132, 204);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbLogin.ShadowDecoration.Parent = this.pbLogin;
            this.pbLogin.Size = new System.Drawing.Size(30, 30);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogin.TabIndex = 1;
            this.pbLogin.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblWelcome.Location = new System.Drawing.Point(80, 70);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(442, 70);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME BACK";
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLogin);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(615, 615);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI.WinForms.GunaCirclePictureBox pbPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblFogotPassword;
        private Guna.UI.WinForms.GunaLabel lblResult;
        private Guna.UI.WinForms.GunaLineTextBox txtPassWord;
        private Guna.UI.WinForms.GunaLineTextBox txtUser;
    }
}
