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
    public partial class ucStatistical : UserControl
    {
        public ucStatistical()
        {
            InitializeComponent();
            string time = DateTime.Now.Year.ToString();
            cbbChoose.SelectedIndex = 0;
        }
        public void SetCBB()
        {
            if(cbbTimes.SelectedIndex == 0)
            {
                cbbItems.Items.Clear();
                for(int i = 1; i <= 12; i++)
                {
                    cbbItems.Items.Add(i.ToString());
                }
            }
            else if(cbbTimes.SelectedIndex==1)
            {
                cbbItems.Items.Clear();
                for(int i=2;i>=0; i--)
                {
                    cbbItems.Items.Add(DateTime.Now.AddYears(-i).Year.ToString());
                }
            }
        }

        private void cbbTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCBB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TBMovieStatiticsDTO> list=TBMovieBLL.Instance.GetStatitics();
            dtvView.DataSource = list;
        }
    }
}
