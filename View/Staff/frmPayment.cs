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
    public partial class frmPayment : Form
    {
        TBScheduleDTO schedule;
        TBReceiptDTO receipt;
        List<TBSeatBookingDTO> seats;
        public frmPayment(TBReceiptDTO receipt,List<TBSeatBookingDTO> ls)
        {
            InitializeComponent();
            seats = ls;
            this.receipt = receipt;
            schedule=TBScheduleBLL.Instance.GetScheduleDTO(receipt.schedule_id);
            string seat = TBSeatBookingBLL.Instance.GetSeat(ls);
            lblViewSeat.Text = seat;
            LoadView();
        }
        public void LoadView()
        {
            lblResult.Visible = false;
            string name_movie = TBMovieBLL.Instance.GetNameMovie(schedule.movie_id);
            lblViewMovie.Text = name_movie;
            lblViewDateMovie.Text = schedule.schedule_date.ToString("dd/MM/yyyy");
            lblViewSchedule.Text = schedule.schedule_start.ToString("hh\\:mm") + " ~ " + schedule.schedule_end.ToString("hh\\:mm");
            lblViewRoom.Text = TBRoomBLL.Instance.GetNameRoom(schedule.room_id);
            lblViewSumOfSeat.Text = receipt.number_of_tickets.ToString();
            lblTotalPrice.Text=receipt.total_price.ToString();
            lblViewPrice.Text = TBScheduleBLL.Instance.GetPrice(schedule.schedule_id).ToString();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            if(txtPhone.Text=="")
            {
                lblResult.Text = "Vui lòng nhập số điện thoại";
                if(lblResult.Visible==false)
                {
                    lblResult.Visible = true;
                }
            }
            else
            {
                bool ck=TBCustomerBLL.Instance.CheckPhone(txtPhone.Text);
                if (ck == false)
                {
                    lblResult.Text = "Không tìm thấy khách hàng!";
                    if(lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
                else
                {
                    TBCustomerDTO cus=TBCustomerBLL.Instance.GetTBCustomerDTO(txtPhone.Text);
                    txtNameCustomer.Text=cus.customer_name.ToString();
                    txtBirthday.Value = cus.customer_birthday;
                    txtAddress.Text=cus.customer_address.ToString();
                    txtPoint.Text=cus.customer_points.ToString();
                }
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            receipt.datetime_booking = DateTime.Now;
            if (TBCustomerBLL.Instance.CheckPhone(txtPhone.Text))
            {
                receipt.customer_id = TBCustomerBLL.Instance.GetID(txtPhone.Text);
            }
            else
            {
                if(txtAddress.Text!="" && txtNameCustomer.Text!="" && txtPhone.Text != "" && txtBirthday.Text!="")
                {
                    TBCustomerDTO cus=new TBCustomerDTO();
                    cus.customer_birthday = txtBirthday.Value;
                    cus.customer_address= txtAddress.Text;
                    cus.customer_name = txtNameCustomer.Text;
                    cus.customer_phone = txtPhone.Text;
                    receipt.customer_id=TBCustomerBLL.Instance.SetCustomer(cus);
                }
            }
            int id = TBReceiptBLL.Instance.SaveReceipt(receipt);
            foreach (TBSeatBookingDTO i in seats)
            {
                i.receipt_id = id;
            }
            TBSeatBookingBLL.Instance.SaveBooking(seats);
            frmPrintRecept frm=new frmPrintRecept(id);
            frm.ShowDialog(this);
            

        }
        public void CloseForm()
        {
            frmBookChair frm = this.Owner as frmBookChair;
            frm.CloseForm();
            this.Close();
        }
    }
}
