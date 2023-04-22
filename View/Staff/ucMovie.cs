using BLL1;
using Guna.UI2.WinForms;
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
    
    public partial class ucMovie : UserControl
    {
        int id;
        public delegate void LoadMovie(int id);
        public event LoadMovie GetUC;
        public ucMovie(int movie_id)
        {
            InitializeComponent();
            id = movie_id;
            txtNameMovie.Text = TBMovieBLL.Instance.GetNameMovie(movie_id);
            string local=TBMovieBLL.Instance.GetImageMovie(movie_id);
            btnImageMovie.Image=Image.FromFile(local);
        }
        
        
        private void btnImageMovie_Click(object sender, EventArgs e)
        {
            GetUC?.Invoke(id);
        }
    }
}
