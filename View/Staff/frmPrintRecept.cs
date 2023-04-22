using BLL1;
using DTO1;
using Microsoft.Reporting.WinForms;
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
    public partial class frmPrintRecept : Form
    {
        int id;
        public frmPrintRecept(int receipt_id=1025)
        {
            InitializeComponent();
            List<TBTicketsDTO> booking = TBTicketsBLL.Instance.GetListTickets(receipt_id);
            this.id = receipt_id;
        }

        private void frmPrintRecept_Load(object sender, EventArgs e)
        {
            
            List<TBTicketsDTO> booking = TBTicketsBLL.Instance.GetListTickets(id);
            
            rvData.LocalReport.ReportPath = @"D:\\PBL3\\DoubleTCinema\\View\\Staff\\ReportReceipt.rdlc";
            var source = new ReportDataSource("dtsTickets", booking);
            TBReceiptDTO receipt = TBReceiptBLL.Instance.GetReceiptDTO(id);
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("rpparaIdReceipt",receipt.receipt_id.ToString()));
            parameters.Add(new ReportParameter("rpparaIdCustomer", receipt.customer_id.ToString()));
            parameters.Add(new ReportParameter("rpparaNumberOfTicket", receipt.number_of_tickets.ToString()));
            parameters.Add(new ReportParameter("rpparaIdStaff", receipt.staff_id.ToString()));
            parameters.Add(new ReportParameter("rpparaTotalPrice", receipt.total_price.ToString()));
            parameters.Add(new ReportParameter("rpparaDateTime", receipt.datetime_booking.ToString("dd/MM/yyyy")));
            rvData.LocalReport.DataSources.Clear();
            rvData.LocalReport.SetParameters(parameters);
            
            rvData.LocalReport.DataSources.Add(source);
            
            this.rvData.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmPrintTickets tic=new frmPrintTickets(id); 
            tic.ShowDialog();
        }

        private void frmPrintRecept_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPayment frm=this.Owner as frmPayment;
            frm.CloseForm();
            this.Close();
        }
    }
}
