using BLL1;
using DTO1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema.View.Staff
{
    public partial class ucShift : UserControl
    {
        public ucShift()
        {
            InitializeComponent();
            SetData(DateTime.Now);
            dtpDate.Value = DateTime.Now;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetData(dtpDate.Value);
        }
        public void SetData(DateTime dt)
        {
            
                List<TBShiftDTO> list = TBShiftBLL.Instance.GetListShift(dt);
                dtvShift.DataSource = list;
            
            
        }
    }
}
