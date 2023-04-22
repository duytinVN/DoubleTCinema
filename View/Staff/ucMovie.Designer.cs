namespace DoubleTCinema.View.Staff
{
    partial class ucMovie
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnImageMovie = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtNameMovie = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnImageMovie
            // 
            this.btnImageMovie.CheckedState.Parent = this.btnImageMovie;
            this.btnImageMovie.HoverState.ImageSize = new System.Drawing.Size(270, 277);
            this.btnImageMovie.HoverState.Parent = this.btnImageMovie;
            this.btnImageMovie.ImageSize = new System.Drawing.Size(280, 287);
            this.btnImageMovie.Location = new System.Drawing.Point(0, 0);
            this.btnImageMovie.Name = "btnImageMovie";
            this.btnImageMovie.PressedState.Parent = this.btnImageMovie;
            this.btnImageMovie.Size = new System.Drawing.Size(280, 287);
            this.btnImageMovie.TabIndex = 0;
            this.btnImageMovie.Click += new System.EventHandler(this.btnImageMovie_Click);
            // 
            // txtNameMovie
            // 
            this.txtNameMovie.BorderThickness = 0;
            this.txtNameMovie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameMovie.DefaultText = "Name Movie";
            this.txtNameMovie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMovie.DisabledState.Parent = this.txtNameMovie;
            this.txtNameMovie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMovie.FocusedState.Parent = this.txtNameMovie;
            this.txtNameMovie.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameMovie.ForeColor = System.Drawing.Color.Black;
            this.txtNameMovie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMovie.HoverState.Parent = this.txtNameMovie;
            this.txtNameMovie.Location = new System.Drawing.Point(0, 295);
            this.txtNameMovie.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNameMovie.Name = "txtNameMovie";
            this.txtNameMovie.PasswordChar = '\0';
            this.txtNameMovie.PlaceholderText = "";
            this.txtNameMovie.SelectedText = "";
            this.txtNameMovie.SelectionStart = 10;
            this.txtNameMovie.ShadowDecoration.Parent = this.txtNameMovie;
            this.txtNameMovie.Size = new System.Drawing.Size(280, 50);
            this.txtNameMovie.TabIndex = 1;
            this.txtNameMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.btnImageMovie;
            // 
            // ucMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtNameMovie);
            this.Controls.Add(this.btnImageMovie);
            this.Name = "ucMovie";
            this.Size = new System.Drawing.Size(280, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnImageMovie;
        private Guna.UI2.WinForms.Guna2TextBox txtNameMovie;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
