
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
    public partial class ucStaffUser : UserControl
    {
        public ucStaffUser()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            List<TBCustomerDTO> list = TBCustomerBLL.Instance.GetListCustomers();
            dtvUser.DataSource = list;

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                bool ck=TBCustomerBLL.Instance.CheckFormatIsPhone(txtSearch.Text);
                if(ck)
                {
                    TBCustomerDTO cus=TBCustomerBLL.Instance.GetTBCustomerDTO(txtSearch.Text);
                    if (cus != null)
                    {
                        List<TBCustomerDTO> result= new List<TBCustomerDTO>();
                        result.Add(cus);
                        dtvUser.DataSource = result;
                    }
                }
                else
                {
                    List<TBCustomerDTO> result=TBCustomerBLL.Instance.GetListCustomers(txtSearch.Text);
                    if (result != null)
                    {
                        dtvUser.DataSource= result;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtvUser.CurrentRow;
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                frmEditCustomers frm=new frmEditCustomers(id);
                frm.FormClosed += new  FormClosedEventHandler(ReloadDataGridView);
                frm.ShowDialog();
                
            }
        }
        public void ReloadDataGridView(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditCustomers frm=new frmEditCustomers();
            frm.FormClosed += new FormClosedEventHandler(ReloadDataGridView);
            frm.ShowDialog();
        }
    }
}
