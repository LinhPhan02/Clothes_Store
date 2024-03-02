using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Popups;
using BLL;
using DTO;

namespace GUI.Screens
{
    public partial class SPConBanHang : Form
    {

        public string id { get; set; }


        List<spcbhDTO> productCon = new List<spcbhDTO>();
       
        List<spcbhDTO> spcSearch = new List<spcbhDTO>();

        public SPConBanHang(string id)
        {
            this.id = id;
            InitializeComponent();
            List<spcbhDTO> dataSPC = new List<spcbhDTO>();
            dataSPC = spcBLL.GetData(id);
            foreach (spcbhDTO spc in dataSPC)
            {
                if (!checkExist(spc.Id))
                {
                    productCon.Add(spc);
                }
            }
            
            lbl_qty.Text = productCon.Count.ToString();
            show(productCon);
        }

        bool checkExist(string id)
        {
            bool flag = false;
            foreach(spcbhDTO spc in SanPhamBanHang.cartbh)
            {
                if(spc.Id == id)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public void show(List<spcbhDTO> productCon)
        {
            flowSPC.Controls.Clear();
            Panel[] pnlProduct = new Panel[productCon.Count];
            Label[] idSPC = new Label[productCon.Count];
            Label[] nameSPC = new Label[productCon.Count];
            PictureBox[] img = new PictureBox[productCon.Count];
            Button[] btnAdd = new Button[productCon.Count];
            Font SmallFont = new Font("Arial", 11);

            for (int i = 0; i < productCon.Count; i++)
            {
                pnlProduct[i] = new Panel();
                pnlProduct[i].BorderStyle = BorderStyle.FixedSingle;
                pnlProduct[i].Size = new Size(440, 60);

                idSPC[i] = new Label();
                idSPC[i].Location = new Point(26, 23);
                idSPC[i].Size = new Size(35, 17);
                idSPC[i].Margin = new Padding(2, 0, 2, 0);
                idSPC[i].Font = SmallFont;
                idSPC[i].Text = productCon[i].Id.ToString();
                idSPC[i].TextAlign = ContentAlignment.MiddleCenter;

                nameSPC[i] = new Label();
                nameSPC[i].Location = new Point(100, 19);
                nameSPC[i].Size = new Size(100, 30);
                nameSPC[i].Margin = new Padding(2, 0, 2, 0);
                nameSPC[i].Font = SmallFont;
                nameSPC[i].Text = productCon[i].Namesp.ToString();
                nameSPC[i].TextAlign = ContentAlignment.MiddleCenter;

                img[i] = new PictureBox();
                img[i].Location = new Point(230, 4);
                img[i].Size = new Size(90, 50);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = productCon[i].Imgsp;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(productCon[i].Imgsp);

                btnAdd[i] = new Button();
                btnAdd[i].Text = "Thêm";
                btnAdd[i].Size = new Size(50, 30);
                btnAdd[i].Margin = new Padding(2, 1, 2, 1);
                btnAdd[i].Location = new Point(370, 15);
                btnAdd[i].TextAlign = ContentAlignment.MiddleCenter;
                btnAdd[i].Name = idSPC[i].Text;
                btnAdd[i].Click += ButtonAddClick;

                if (Login._checkUrlMatch("themvaogio:BH"))
                {
                    btnAdd[i].Visible = true;
                }
                else
                {
                    btnAdd[i].Visible = false;
                }


                    pnlProduct[i].Controls.Add(idSPC[i]);
                pnlProduct[i].Controls.Add(nameSPC[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(btnAdd[i]);
                flowSPC.Controls.Add(pnlProduct[i]);
            }

        }

        bool isExistCart(string id)
        {
            bool flag = false;
            foreach (spcbhDTO sp in SanPhamBanHang.cartbh)
            {
                if (sp.Id == id)
                {
                    flag = true;
                }
              
            }
            return flag;

        }

        bool checkExistParent(int parentId)
        {
            foreach(SpQLSPDTO sp in SanPhamBanHang.cart)
            {
                if(sp.Id == parentId)
                {
                    return true;
                }
            }
            return false;
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
                if ((sender as Button).Name != null)
                {
                    foreach (spcbhDTO item in productCon)
                    {
                        if (item.Id.ToString() == (sender as Button).Name)
                        {
                            if (!isExistCart(item.Id))
                            {
                                SanPhamBanHang.cartbh.Add(item);
                                if (!checkExistParent(item.ParentId))
                                {
                                    foreach (SpQLSPDTO sp in SanPhamBanHang.productCtl)
                                    {
                                        if (sp.Id == item.ParentId)
                                        {
                                            SpQLSPDTO spAdd = new SpQLSPDTO();
                                            spAdd = sp;
                                            spAdd.Quantity = 1;
                                            SanPhamBanHang.cart.Add(spAdd);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (SpQLSPDTO sp in SanPhamBanHang.cart)
                                    {
                                        if (sp.Id == item.ParentId)
                                        {
                                            sp.Quantity += 1;
                                            break;
                                        }
                                    }
                                }
                                MessageBox.Show("Thêm thành công");
                            }


                            this.Hide();
                        }

                    }
                }      
        }

        private void SPConBanHang_Click(object sender, EventArgs e)
        {
           
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HandleSearch()
        {
            spcSearch.Clear();
            if (textBox1.Text.Trim() == "")
            {
                show(productCon);
                lbl_qty.Text = productCon.Count.ToString();
                return;
            }
            foreach (spcbhDTO product in productCon)
            {
                if (product.Id.ToString() == textBox1.Text)
                {
                    spcSearch.Add(product);
                }
               
            }
            show(spcSearch);
            lbl_qty.Text = spcSearch.Count.ToString();



        }
        private void button2_Click(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void flowSPC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SPConBanHang_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
