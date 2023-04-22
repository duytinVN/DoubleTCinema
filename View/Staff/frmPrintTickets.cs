using BLL1;
using DTO1;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleTCinema.View.Staff
{
    public partial class frmPrintTickets : Form
    {
        int id;
        public frmPrintTickets(int receipt_id)
        {
            InitializeComponent();
            this.id = receipt_id;
            SetCBBItems();
        }

        private void frmPrintTickets_Load(object sender, EventArgs e)
        {
            List<TBTicketsDTO> List = TBTicketsBLL.Instance.GetListTickets(id);
            LoadTick(List[0]);

            this.rvTickets.RefreshReport();
        }
        public void SetCBBItems()
        {
            List<TBTicketsDTO> list = TBTicketsBLL.Instance.GetListTickets(id);
            
            cbbItems.DataSource = list;
        }
        public void LoadTick(TBTicketsDTO t)
        {
            rvTickets.LocalReport.ReportPath = "D:\\PBL3\\DoubleTCinema\\View\\Staff\\ReportTicket.rdlc";
            ReportParameterCollection para = new ReportParameterCollection();
            para.Add(new ReportParameter("Ticket_id", t.ticket_id.ToString()));
            para.Add(new ReportParameter("movie_name", t.movie_name.ToString()));
            para.Add(new ReportParameter("schedule_date", t.schedule_date.ToString()));
            para.Add(new ReportParameter("schedule_showtime", t.schedule_time.ToString()));
            para.Add(new ReportParameter("room_name", t.room_name.ToString()));
            para.Add(new ReportParameter("seat_name", t.seat_name.ToString()));
            para.Add(new ReportParameter("receipt_id", t.receipt_id.ToString()));
            para.Add(new ReportParameter("price", t.price.ToString()));
            rvTickets.LocalReport.SetParameters(para);
            this.rvTickets.RefreshReport();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            rvTickets.LocalReport.ReportPath = "D:\\PBL3\\DoubleTCinema\\View\\Staff\\ReportTicket.rdlc";
            
            TBTicketsDTO t =cbbItems.SelectedItem as TBTicketsDTO;
            if (t != null)
            {
                LoadTick(t);
            }
            this.rvTickets.RefreshReport();
        }
    }
}
