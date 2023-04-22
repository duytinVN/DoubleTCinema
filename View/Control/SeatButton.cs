using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
namespace DoubleTCinema.View.Control
{
    public class SeatButton : Guna2Button
    {
        public bool isVip { get; set; }
        public bool book { get; set; }
        public SeatButton(string st)
        {
            //this.Font=new Font("Arial");
            this.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.Size = new Size(40, 40);
            this.Font = new Font("Arial", 11, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.FillColor = Color.FromArgb(231, 0, 221);
            this.HoverState.FillColor = Color.FromArgb(22, 155, 20);
            this.Text = st;
            this.BorderRadius = 4;
            this.BackColor = Color.Transparent;
            this.isVip = false;
        }
        protected override void OnClick(EventArgs e)
        {

            base.OnClick(e);
        }
    }
}
