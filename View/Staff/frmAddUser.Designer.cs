namespace DoubleTCinema.View.Staff
{
    partial class frmAddUser
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtPhoneUsers = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAddressUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtBirthday = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBirthday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderColor = System.Drawing.Color.Silver;
            this.pnMain.BorderRadius = 2;
            this.pnMain.BorderThickness = 2;
            this.pnMain.Controls.Add(this.btnCancel);
            this.pnMain.Controls.Add(this.btnSave);
            this.pnMain.Controls.Add(this.txtPhoneUsers);
            this.pnMain.Controls.Add(this.txtAddressUser);
            this.pnMain.Controls.Add(this.txtBirthday);
            this.pnMain.Controls.Add(this.txtName);
            this.pnMain.Controls.Add(this.lblPhone);
            this.pnMain.Controls.Add(this.lblAddress);
            this.pnMain.Controls.Add(this.lblBirthday);
            this.pnMain.Controls.Add(this.lblName);
            this.pnMain.Location = new System.Drawing.Point(-1, 79);
            this.pnMain.Name = "pnMain";
            this.pnMain.ShadowDecoration.Parent = this.pnMain;
            this.pnMain.Size = new System.Drawing.Size(901, 424);
            this.pnMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(149)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(629, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(105, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(112)))), ((int)(((byte)(182)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(772, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            // 
            // txtPhoneUsers
            // 
            this.txtPhoneUsers.BackColor = System.Drawing.Color.White;
            this.txtPhoneUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneUsers.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhoneUsers.Font = new System.Drawing.Font("Arial", 20F);
            this.txtPhoneUsers.LineColor = System.Drawing.Color.Silver;
            this.txtPhoneUsers.LineSize = 2;
            this.txtPhoneUsers.Location = new System.Drawing.Point(258, 224);
            this.txtPhoneUsers.Name = "txtPhoneUsers";
            this.txtPhoneUsers.PasswordChar = '\0';
            this.txtPhoneUsers.SelectedText = "";
            this.txtPhoneUsers.Size = new System.Drawing.Size(511, 47);
            this.txtPhoneUsers.TabIndex = 2;
            // 
            // txtAddressUser
            // 
            this.txtAddressUser.BackColor = System.Drawing.Color.White;
            this.txtAddressUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressUser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddressUser.Font = new System.Drawing.Font("Arial", 20F);
            this.txtAddressUser.LineColor = System.Drawing.Color.Silver;
            this.txtAddressUser.LineSize = 2;
            this.txtAddressUser.Location = new System.Drawing.Point(258, 164);
            this.txtAddressUser.Name = "txtAddressUser";
            this.txtAddressUser.PasswordChar = '\0';
            this.txtAddressUser.SelectedText = "";
            this.txtAddressUser.Size = new System.Drawing.Size(511, 44);
            this.txtAddressUser.TabIndex = 1;
            // 
            // txtBirthday
            // 
            this.txtBirthday.BackColor = System.Drawing.Color.White;
            this.txtBirthday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirthday.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBirthday.Font = new System.Drawing.Font("Arial", 20F);
            this.txtBirthday.LineColor = System.Drawing.Color.Silver;
            this.txtBirthday.LineSize = 2;
            this.txtBirthday.Location = new System.Drawing.Point(258, 93);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.PasswordChar = '\0';
            this.txtBirthday.SelectedText = "";
            this.txtBirthday.Size = new System.Drawing.Size(511, 44);
            this.txtBirthday.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.LineColor = System.Drawing.Color.Silver;
            this.txtName.LineSize = 2;
            this.txtName.Location = new System.Drawing.Point(258, 20);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(511, 44);
            this.txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 21.75F);
            this.lblPhone.Location = new System.Drawing.Point(36, 235);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(172, 35);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 21.75F);
            this.lblAddress.Location = new System.Drawing.Point(36, 170);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 35);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblBirthday
            // 
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Arial", 21.75F);
            this.lblBirthday.Location = new System.Drawing.Point(36, 100);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(131, 35);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "Ngày sinh";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(36, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(468, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Thông tin khách hàng";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI.WinForms.GunaLineTextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI.WinForms.GunaLineTextBox txtAddressUser;
        private Guna.UI.WinForms.GunaLineTextBox txtBirthday;
        private Guna.UI.WinForms.GunaLineTextBox txtPhoneUsers;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}