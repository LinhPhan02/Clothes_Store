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
    public partial class NhapXuat : UserControl
    {
        public NhapXuat()
        {
            InitializeComponent();
            ucXuat1.BringToFront();
            ucXuat1.resetData();
        }

        public void btn_pxuat_Click(object sender, EventArgs e)
        {
            ucXuat1.BringToFront();
            ucXuat1.resetData();
        }

        private void btn_pnhap_Click(object sender, EventArgs e)
        {
            ucNhap1.BringToFront();
            ucNhap1.resetData();
        }

        private void NhapXuat_Load(object sender, EventArgs e)
        {
            
        }

        private void ucNhap1_Load(object sender, EventArgs e)
        {

        }
    }
}
