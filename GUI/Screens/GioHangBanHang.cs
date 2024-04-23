using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Popups;


namespace GUI.Screens
{
    public partial class GioHangBanHang : UserControl
    {
        Panel[] pnlProduct;
        Label[] idSPC;
        Label[] name;
        PictureBox[] img;
        Label[] price;
        Label[] origin;
        Button[] btnEdit;
        public spcbhDTO cartbh;
        public GioHangBanHang()
        {

            InitializeComponent();
            loadDataToProductNCC(SanPhamBanHang.cartbh);
        }
        public void loadDataToProductNCC(List<spcbhDTO> carts)
        {
            flow_spbh.Controls.Clear();
            flow_spbh.Refresh();
            pnlProduct = new Panel[carts.Count];
            idSPC = new Label[carts.Count];
            name = new Label[carts.Count];
            img = new PictureBox[carts.Count];
            price = new Label[carts.Count];
            origin = new Label[carts.Count];
            btnEdit = new Button[carts.Count];
            Font SmallFont = new Font("Arial", 11);

            for (int i = 0; i < carts.Count; i++)
            {
                pnlProduct[i] = new Panel();
                pnlProduct[i].BorderStyle = BorderStyle.FixedSingle;
                pnlProduct[i].Size = new Size(686, 64);

                idSPC[i] = new Label();
                idSPC[i].Location = new Point(15, 17);
                idSPC[i].Size = new Size(40, 25);
                idSPC[i].Margin = new Padding(2, 0, 2, 0);
                idSPC[i].Font = SmallFont;
                idSPC[i].Text = carts[i].Id.ToString();
                idSPC[i].TextAlign = ContentAlignment.MiddleCenter;

                name[i] = new Label();
                name[i].Size = new Size(140, 44);
                name[i].ForeColor = Color.Black;
                name[i].Font = SmallFont;
                name[i].Text = carts[i].Namesp.ToString();
                name[i].Margin = new Padding(2, 0, 2, 0);
                name[i].Location = new Point(74, 7);
                name[i].TextAlign = ContentAlignment.MiddleLeft;

                img[i] = new PictureBox();
                img[i].Location = new Point(260, 10);
                img[i].Size = new Size(70, 45);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = carts[i].Imgsp;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(carts[i].Imgsp);


                price[i] = new Label();
                price[i].Size = new Size(70, 44);
                price[i].ForeColor = Color.Black;
                price[i].Font = SmallFont;
                price[i].Text = carts[i].Prices.ToString();
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Location = new Point(370, 7);
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(50, 44);
                origin[i].ForeColor = Color.Black;
                origin[i].Font = SmallFont;
                origin[i].Text = carts[i].Origin.ToString();
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Location = new Point(480, 9);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                btnEdit[i] = new Button();
                btnEdit[i].Text = "Xóa";
                btnEdit[i].Size = new Size(80, 40);
                btnEdit[i].Margin = new Padding(2, 1, 2, 1);
                btnEdit[i].Location = new Point(570, 10);
                btnEdit[i].TextAlign = ContentAlignment.MiddleCenter;
                btnEdit[i].Name = idSPC[i].Text;
                btnEdit[i].Click += DeleteClick;



                pnlProduct[i].Controls.Add(idSPC[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(btnEdit[i]);

                flow_spbh.Controls.Add(pnlProduct[i]);

            }
            label8.Text = Total(SanPhamBanHang.cartbh).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Login._checkUrlMatch("thanhtoangiohang:BH"))
            {
                if (SanPhamBanHang.cartbh.Count > 0)
                {
                    string PhoneNumber = "";
                    var DialogResult = MessageBox.Show("Khách hàng đã có tài khoản chưa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes) //Creates the yes function
                    {
                        BanHangHasTK hastk = new BanHangHasTK();
                        hastk.ShowDialog();
                        if (hastk.kh != null)
                        {
                            PhoneNumber = hastk.kh.Phone;
                            if (hastk.flag == true)
                            {

                                HandlePayment(PhoneNumber);
                            }
                        }


                    }
                    else if (DialogResult == DialogResult.No)
                    {
                        BanHangConfirm confirm = new BanHangConfirm();
                        confirm.ShowDialog();
                        if (confirm.kh != null)
                        {
                            if (confirm.flag == true)
                            {
                                HandlePayment(confirm.kh.Phone);
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền để thanh toán!!!", "Thông báo");
            }

        }


        void HandlePayment(string phone)
        {
            PhieuXuatDTO xuatInput = new PhieuXuatDTO();
            xuatInput.staffId = Login.user.Username;
            xuatInput.CustomerPhone = phone;
            xuatInput.Total = Total(SanPhamBanHang.cartbh);

            PhieuXuatDTO xuat;
            xuat = BanHangBLL.AddBill(xuatInput);
            BanHangBLL.UpdateTotalCustomer(xuat);


            BanHangBLL.AddDetailBill(xuat.Id, SanPhamBanHang.cartbh);

            List<int> productIds = new List<int>();

            foreach(spcbhDTO spc in SanPhamBanHang.cartbh)
            {
                bool flag = false;
                foreach(int item in productIds)
                {
                    if(item == spc.ParentId)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    productIds.Add(spc.ParentId);
                }
            }


            //BanHangBLL.AddDetailMaintain(xuat.CustomerPhone, SanPhamBanHang.cartbh, productIds);

            MessageBox.Show("Thanh toán thành công");

            HoaDonBanHang hoadon = new HoaDonBanHang(xuat);
                hoadon.ShowDialog();
            SanPhamBanHang.cartbh.Clear();
            SanPhamBanHang.cart.Clear();
            loadDataToProductNCC(SanPhamBanHang.cartbh);

        }
        private List<KhuyenMaiDTO> km;
        private KhuyenMaiBLL qlkm = new KhuyenMaiBLL();
        int Total(List<spcbhDTO> cart) //add khuyến mãi để tính total
        {
            km = qlkm.readDB();
            int sum = 0;
            for (int i = 0; i < cart.Count; i++)
            {
                sum += int.Parse(cart[i].Prices);
                foreach (KhuyenMaiDTO k in km)
                {
                    if (maKH == k.discount_id)
                    {
                        sum = sum - (sum * k.discount_amount / 100);
                    }
                }
            }
            return sum;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GioHangBanHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GioHangBanHang_Paint(object sender, PaintEventArgs e)
        {
          
        }

        public void resetData()
        {
            loadDataToProductNCC(SanPhamBanHang.cartbh);
           
        }

        void DeleteClick(object sender, EventArgs e)
        {
            var DialogResult = MessageBox.Show("Are you sure you want to delete", "Are you sure?", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes) //Creates the yes function
            {
                foreach (spcbhDTO item in SanPhamBanHang.cartbh)
                {
                    if (item.Id.ToString() == (sender as Button).Name)
                    {
                        SanPhamBanHang.cartbh.Remove(item);
                        foreach(SpQLSPDTO sp in SanPhamBanHang.cart)
                        {
                            if(sp.Id == item.ParentId)
                            {
                                if(sp.Quantity > 1)
                                {
                                    sp.Quantity -= 1;
                                }
                                else
                                {
                                    SanPhamBanHang.cart.Remove(sp);
                                   
                                }
                                break;
                            }
                        }
                        loadDataToProductNCC(SanPhamBanHang.cartbh);
                        break;
                    }
                }
            }
        }
        private void GioHangBanHang_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        string maKH;
        private void btn_confirmKM_Click(object sender, EventArgs e)
        {
            maKH = txt_nhapKM.Text;
            label8.Text = Total(SanPhamBanHang.cartbh).ToString();
        }
    }
}
