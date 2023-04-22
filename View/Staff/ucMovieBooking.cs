using BLL1;
using DTO1;
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
    public partial class ucMovieBooking : UserControl
    {

        public event myDel ChangedUC;
        public ucMovieBooking()
        {
            InitializeComponent();
            LoadSeat(TBMovieBLL.Instance.GetListMovie_id());
            SetCBB();
        }

        
        public void LoadSeat(List<int> movies)
        {
            pnMovie.Controls.Clear();
            int x = 20, y = 20, i = 0;
            foreach (int movie in movies)
            {
                ucMovie uc = new ucMovie(movie);
                if(i==3)
                {
                    x = 20;
                    y += uc.Height + 20;
                    i = 0;
                }
                uc.Location=new Point(x, y);
                uc.GetUC += LoadUC;
                pnMovie.Controls.Add(uc);
                x += uc.Width + 20;
                i++;
            }
        }
        public void LoadUC(int id)
        {
           ucMovieContent uc=new ucMovieContent(id);
            ChangedUC?.Invoke(uc, this);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Tìm kiếm phim")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm phim";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                pnMovie.Controls.Clear();
                List<int> list = TBMovieBLL.Instance.GetMovieByName(txtSearch.Text);
                LoadSeat(list);
            }
        }
        public void SetCBB()
        {
            List<TBMovieGenreDTO> list=TBMovieGenreBLL.Instance.GetListMovieGenre();
            cbbGenges.DataSource = list;
            
        }

        private void cbbGenges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbGenges.SelectedIndex==-1)
            {
                LoadSeat(TBMovieBLL.Instance.GetListMovie_id());
            }
            else
            {
                int i = ((TBMovieGenreDTO)cbbGenges.SelectedItem).movie_genres_id;
                TBMovieGenreDTO genre=cbbGenges.SelectedItem as TBMovieGenreDTO;
                LoadSeat(TBMovieBLL.Instance.GetMovieByMovieGenres(genre));
                
            }
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            if (cbbGenges.SelectedIndex == -1)
            {
                LoadSeat(TBMovieBLL.Instance.GetListMovie_id());
            }
            else
            {
                //int i = ((TBMovieGenreDTO)cbbGenges.SelectedItem).movie_genres_id;
                TBMovieGenreDTO genre = cbbGenges.SelectedItem as TBMovieGenreDTO;
                LoadSeat(TBMovieBLL.Instance.GetMovieByMovieGenres(genre));
            }
        }
    }
}
