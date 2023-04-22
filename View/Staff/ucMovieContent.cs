using DoubleTCinema.View.Control;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO1;
using BLL1;

namespace DoubleTCinema.View.Staff
{
    public partial class ucMovieContent : UserControl
    {
        TBMovieDTO movieDTO;
        public ucMovieContent(int id_movie=1002)
        {
            InitializeComponent();    
            movieDTO = new TBMovieDTO();
            movieDTO =TBMovieBLL.Instance.GetMovie(id_movie);
            LoadUc();
            GUI();

        }
        
        public void LoadUc()
        {
                pbMovieImage.Image = Image.FromFile(movieDTO.movie_image.ToString());
                lblNameMovie.Text=movieDTO.movie_name.ToString();
                lblShowDirector.Text=movieDTO.movie_director.ToString();
                lblShowGenges.Text=movieDTO.movie_genres.ToString();
                lblShowNation.Text= movieDTO.movie_nation.ToString();
                lblShowRelease.Text=movieDTO.movie_release.ToString("dd/MM/yyyy");
                lblShowLenght.Text=movieDTO.movie_length.ToString()+" phút";
        }
        public void GUI()
        {
            pnDateMovie.AutoScroll = true;
            GunaHScrollBar hScrollBar = new GunaHScrollBar();
            hScrollBar.Dock = DockStyle.Bottom;
            hScrollBar.Visible = false; // Ẩn thanh cuộn mặc định
            hScrollBar.Minimum = 0;
            hScrollBar.Maximum = pnDateMovie.Width;
            hScrollBar.LargeChange = pnDateMovie.Width / 10;
            hScrollBar.SmallChange = pnDateMovie.Width / 20;
            pnDateMovie.Controls.Add(hScrollBar);
            int x = 20;
            DateTime dateTime = DateTime.Now.Date;

            for(int i=0;i<8;i++)
            {
                DateTime temp=dateTime.AddDays(i);
                DayButton btn = new DayButton(temp);
                btn.Left = x;
                btn.Top = (pnDateMovie.Height - btn.Height) / 2;
                pnDateMovie.Controls.Add(btn);
                x += btn.Width + 20;
                btn.Click+= new EventHandler(DayButton_Click);
            }
            
        }
        public void DayButton_Click(object sender, EventArgs e)
        {
            DayButton btn = (DayButton)sender;
            
            int id = movieDTO.movie_id;
            Show_Schedule(btn.date, id);
            
        }
        public void Show_Schedule(DateTime date,int movie_id)
        {
            if(pn2D.Controls.Count>0)
            {
                pn2D.Controls.Clear();
            }
            if (pn3D.Controls.Count > 0)
            {
                pn3D.Controls.Clear();
            }
            List<TBScheduleDTO> list = new List<TBScheduleDTO>();
            list=TBScheduleBLL.Instance.GetListSchedule(date,movie_id);
            //list=TBScheduleBLL.Instance.GetListSchedule(date,movie_id);
            GunaHScrollBar hScrollBar = new GunaHScrollBar();
            hScrollBar.Dock = DockStyle.Bottom;
            hScrollBar.Visible = false; // Ẩn thanh cuộn mặc định
            hScrollBar.Minimum = 0;
            hScrollBar.Maximum = pnDateMovie.Width;
            hScrollBar.LargeChange = pnDateMovie.Width / 10;
            hScrollBar.SmallChange = pnDateMovie.Width / 20;
            pn2D.Controls.Add(hScrollBar);
            pn3D.Controls.Add(hScrollBar);
            int x = 20, y = 20;
            if(list.Count > 0 )
            {
                foreach (TBScheduleDTO dto in list)
                {

                    ShowtimeButton btn = new ShowtimeButton(dto);
                    if(dto.room_type)
                    {
                        btn.Left = x;
                        btn.Top = (pn2D.Height - btn.Height) / 2;
                        pn2D.Controls.Add(btn);
                        btn.Click += new EventHandler(ShowTimeButton_Click);
                        x += btn.Width + 20;
                    }
                    else
                    {
                        btn.Left = y;
                        btn.Top=(pn3D.Height- btn.Height) / 2;
                        pn3D.Controls.Add(btn);
                        btn.Click += new EventHandler(ShowTimeButton_Click);
                        y+= btn.Width + 20;
                    }
                    
                }
            }
        }
        public void ShowTimeButton_Click(object sender, EventArgs e)
        {
            ShowtimeButton btn=(ShowtimeButton)sender;
            frmBookChair frm=new frmBookChair(btn.shedule_id);
            frmStaffMain frmStaff = (frmStaffMain)this.ParentForm;
            frm.ShowDialog(frmStaff);
            
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            frmStaffMain frm = (frmStaffMain)this.ParentForm;
            ucMovieBooking uc = new ucMovieBooking();
            uc.ChangedUC += frm.ReloadUC;
            frm.ReloadUC(uc,this);
        }
    }
}
