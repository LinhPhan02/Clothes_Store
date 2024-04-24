using BLL;
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
    public partial class KhuyenMai : UserControl
    {
        private KhuyenMaiBLL KmBLL = new KhuyenMaiBLL();
        private List<KhuyenMaiDTO> DsKM;
        public KhuyenMai()
        {
            InitializeComponent();
            btnAdd_KM.Visible = true;

            if (Login._checkUrlMatch("themkhuyenmai:KM"))
            {
                btnAdd_KM.Visible = true;
            }
            else
            {
                btnAdd_KM.Visible = false;
            }
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            dataGridView_KM.DataSource = KmBLL.Display();
        }

        private void btnSearch_KM_Click(object sender, EventArgs e)
        {
            string searchValue = txtFind_KM.Text;
            string searchNumber = txtFind_KM.Text;
            dataGridView_KM.DataSource = KmBLL.Show(searchValue, searchNumber);
        }

        private void btnReload_KM_Click(object sender, EventArgs e)
        {
            dataGridView_KM.DataSource = KmBLL.Display();
            txtFind_KM.Clear();
        }

        private void btnAdd_KM_Click(object sender, EventArgs e)
        {
            new AddKhuyenMai().Show();
        }
    }
}
