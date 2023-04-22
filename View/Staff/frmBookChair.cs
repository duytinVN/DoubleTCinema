using BLL1;
using DAL1;
using DoubleTCinema.View.Control;
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
    public partial class frmBookChair : Form
    {
        
        public int price;
        //public int movie_price, room_type_price_percent, schedule_price_percent;
        //private static int s = 0;
        TBScheduleDTO temp;
        TBMovieDTO movieDTO;
        TBRoomDTO roomDTO;
        List<TBSeatBookingDTO> list;
        public frmBookChair()
        {
            InitializeComponent();
            //LoadSeat(150, 15);
        }
        public frmBookChair(int schedule_id)
        {
            InitializeComponent();
            //MessageBox.Show(schedule_id.ToString());
            temp= TBScheduleBLL.Instance.GetScheduleDTO(schedule_id);
            movieDTO = TBMovieBLL.Instance.GetMovie(temp.movie_id);
            roomDTO = TBRoomBLL.Instance.GetRoom(temp.room_id);
            //movie_price = movieDTO.movie_price;
            //room_type_price_percent=roomDTO.room_type_price_percent;
            //schedule_price_percent = temp.schedule_price_percent;
            LoadSeat(roomDTO,temp);
            lblViewMovie.Text = movieDTO.movie_name;
            lblViewDate.Text = temp.schedule_date.ToString("dd/MM/yyyy");
            lblViewSchedule.Text = temp.schedule_start.ToString("hh\\:mm") + " ~ " + temp.schedule_end.ToString("hh\\:mm");
            lblViewRoom.Text=roomDTO.room_name;
            lblViewSeat.Text = "";
            lblViewSumOfSeat.Text = 0.ToString();
            price = TBScheduleBLL.Instance.GetPrice(temp.schedule_id);
            lblViewPrice.Text = price.ToString();
            lblViewSumOfPrice.Text = 0 + "";
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CloseForm();
            
        }
        public void CloseForm()
        {
            this.Close();
        }
        public void LoadSeat(TBRoomDTO room,TBScheduleDTO schedule)
        {
            List<string> list = TBSeatBookingBLL.Instance.GetSeatBooking(schedule.schedule_id);
            
            int sum = room.room_number_of_seat;
            int row = room.room_number_of_row;
            int midx = (pnSeat.Width / 2) - 40 / 2;
            //int midy = (pnSeat.Height / 2) - 40 / 2;
            int col = sum / row;
            int sur = sum % row;
            int x;
            int y = 20;
            int t = 65;
            for (int j = 1; j <= row; j++)
            {
                for (int i = 1; i <= col; i++)
                {
                    char tx = Convert.ToChar(t);
                    string text = tx + "" + i;
                    if (i < 10)
                    {
                        text = tx + "0" + i;
                    }
                    else
                    {
                        text = tx + "" + i;
                    }
                    

                    SeatButton btn = new SeatButton(text);
                    string temp = TBSeatBLL.Instance.GetSeatType(text, room.room_id);
                    if (temp != "")
                    {
                        if (temp == "VIP")
                        {
                            btn.FillColor = Color.FromArgb(192, 0, 0);
                            btn.isVip = true;
                        }
                        else
                        {
                            btn.FillColor = Color.FromArgb(231, 0, 221);
                            btn.isVip = false;
                        }
                    }
                    else
                    {
                        btn.Enabled = false;
                    }
                    //if (Math.Abs(row / 2 - j) >= 3)
                    //{
                    //    btn.FillColor = Color.FromArgb(231, 0, 221);
                    //    btn.isVip = false;
                    //}
                    //else
                    //{
                    //    btn.FillColor = Color.FromArgb(192, 0, 0);
                    //    btn.isVip = true;
                    //}
                    if (i <= col / 2)
                    {
                        x = midx - 40 * (col / 2 - i + 1) - 5 * (col / 2 - i);
                        btn.Left = x;
                        btn.Top = y;


                    }
                    else
                    {
                        x = midx + 40 * (i - col / 2) + 5 * (i - col / 2 - 1);
                        btn.Left = x;
                        btn.Top = y;
                    }
                    //btn.Click += new EventHandler(SeatButton_Click);
                    btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                    pnSeat.Controls.Add(btn);
                    bool ck = list.Contains(btn.Text);
                    if(ck==true)
                    {
                        btn.Enabled=false;
                    }
                    
                }
                t++;
                y += 40 + 5;
            }
            if (sur != 0)
            {
                for (int i = 1; i <= sur; i++)
                {
                    char tx = Convert.ToChar(t);
                    string text = tx + "" + i;
                    SeatButton btn = new SeatButton(text);
                    string temp = TBSeatBLL.Instance.GetSeatType(text, room.room_id);
                    if (temp != "")
                    {
                        if (temp == "VIP")
                        {
                            btn.FillColor = Color.FromArgb(192, 0, 0);
                            btn.isVip = true;
                        }
                        else
                        {
                            btn.FillColor = Color.FromArgb(231, 0, 221);
                            btn.isVip = false;
                        }
                    }
                    if (i <= sur / 2)
                    {
                        x = midx - 40 * (sur / 2 - i + 1) - 5 * (sur / 2 - i);
                        btn.Left = x;
                        btn.Top = y;
                    }
                    else
                    {
                        x = midx + 40 * (i - sur / 2) + 5 * (i - sur / 2 - 1);
                        btn.Left = x;
                        btn.Top = y;
                    }
                    btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                    pnSeat.Controls.Add(btn);
                }
            }
        }
        
        private void SeatButton_CheckedChanged(object sender, EventArgs e)
        {
            SeatButton btn= (SeatButton)sender;
            if (btn.Checked==true)
            {
                string text = btn.Text;
                lblViewSeat.Text += text + " ";
                int s=int.Parse(lblViewSumOfSeat.Text);
                s++;
                lblViewSumOfSeat.Text= s.ToString();
                int sum=int.Parse(lblViewSumOfPrice.Text);
                int seat_per = TBSeatBLL.Instance.GetPricePersent(btn.isVip);
                sum += price + movieDTO.movie_price * seat_per / 100;
                lblViewSumOfPrice.Text= sum.ToString();
            }
            else
            {
                string text = btn.Text;
                int index = lblViewSeat.Text.IndexOf(text);
                if (index != -1)
                {
                    lblViewSeat.Text = lblViewSeat.Text.Remove(index, btn.Text.Length+1);
                }
                int s = int.Parse(lblViewSumOfSeat.Text);
                s--;
                lblViewSumOfSeat.Text = s.ToString();
                int sum = int.Parse(lblViewSumOfPrice.Text);
                int seat_per = TBSeatBLL.Instance.GetPricePersent(btn.isVip);
                sum -= price + movieDTO.movie_price * seat_per / 100;
                lblViewSumOfPrice.Text = sum.ToString();
            }
        }
        

        private void btnContinue_Click(object sender, EventArgs e)
        {
            TBReceiptDTO result = new TBReceiptDTO();
            result.staff_id = TBStaffBLL.Instance.GetId();
            result.schedule_id = temp.schedule_id;
            result.number_of_tickets = int.Parse(lblViewSumOfSeat.Text);
            result.total_price = int.Parse(lblViewSumOfPrice.Text);
            
            if (lblViewSeat.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ghế đặt");
                return;
            }
            List<TBSeatBookingDTO> list=TBSeatBookingBLL.Instance.SetSeatBooking(lblViewSeat.Text.TrimEnd(),temp.schedule_id);
            frmPayment form=new frmPayment(result,list);
            form.ShowDialog(this);
        }

        private void frmBookChair_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStaffMain frm=this.Owner as frmStaffMain;
            if (frm != null)
            {
                frm.LoadForm();
            }
        }
    }
}
