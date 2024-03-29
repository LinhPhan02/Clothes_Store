﻿using BLL;
using DTO;
using GUI.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Screens
{
    public partial class UCNhap : UserControl
    {
        public List<NhapDTO> phieuNhap = new List<NhapDTO>();
        public UCNhap()
        {
            InitializeComponent();
            initDataGridView();
            if (Login._checkUrlMatch("exportnhap:NX"))
            {
                btn_export.Visible = true;
            }
            else
            {
                btn_export.Visible = false;
            }
        }

        public void resetData()
        {
            phieuNhap = NhapBLL.GetDataAction();
            loadData(phieuNhap);
        }
        public void initDataGridView()
        {
            dataGridView_Nhap.ColumnCount = 5;
            dataGridView_Nhap.Columns[0].Name = "Id";
            dataGridView_Nhap.Columns[1].Name = "Ngày Tạo Hóa Đơn";
            dataGridView_Nhap.Columns[2].Name = "Tên Nhân Viên";
            dataGridView_Nhap.Columns[3].Name = "Tổng Tiền";
            dataGridView_Nhap.Columns[4].Name = "Tên NCC";
            phieuNhap = NhapBLL.GetDataAction();
            loadData(phieuNhap);
        }
        public void loadData(List<NhapDTO> list)
        {
            dataGridView_Nhap.Refresh();
            dataGridView_Nhap.Rows.Clear();
            foreach (NhapDTO pn in list)
            {
                string[] row = new string[] { pn.id.ToString(),pn.createAt.ToString("dd-MM-yyyy") ,pn.staff_name.ToString(), pn.total.ToString(), pn.producer_name.ToString() };
                dataGridView_Nhap.Rows.Add(row);
            }
        }
        public void loadData()
        {
            dataGridView_Nhap.Refresh();
            dataGridView_Nhap.Rows.Clear();
            foreach (NhapDTO pn in phieuNhap)
            {
                string[] row = new string[] { pn.id.ToString(), pn.createAt.ToString("dd-MM-yyyy"), pn.staff_name.ToString(), pn.total.ToString(), pn.producer_name.ToString() };
                dataGridView_Nhap.Rows.Add(row);
            }
        }
        private void dataGridView_Nhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_Nhap.Rows[e.RowIndex];
            int maHD = Convert.ToInt16(row.Cells["Id"].Value);
            string tenNV = Convert.ToString(row.Cells["Tên Nhân Viên"].Value);
            string tenNCC = Convert.ToString(row.Cells["Tên NCC"].Value);
            ShowChiTietPN showPN = new ShowChiTietPN(maHD, tenNV, tenNCC);
            showPN.ShowDialog();
        }

        private void dataGridView_Nhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<NhapDTO> list_search = new List<NhapDTO>();
            list_search.Clear();
            DateTime startTime = dtp_start.Value;
            DateTime endTime = dtp_end.Value;
            foreach(NhapDTO item in phieuNhap)
            {
                if(startTime <= item.createAt && item.createAt <= endTime)
                {
                    list_search.Add(item);
                }
            }
            loadData(list_search);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            dataGridView_Nhap.SelectAll();
            DataObject copydata = dataGridView_Nhap.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void UCNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
