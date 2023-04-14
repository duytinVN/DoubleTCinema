using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema.View.Login
{
    public partial class ucFinishReset : UserControl
    {
        
        public ucFinishReset()
        {
            
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            this.Dispose();
            panel.Controls.Add(new ucLogin());
        }
    }
}
