using BLL;
using DTO;
using GUI.Popups;
using GUI.Properties;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.Screens
{
    public partial class SanPhamQLSP : UserControl
    {

        public static List<SpQLSPDTO> productCtl = new List<SpQLSPDTO>();
        List<SpQLSPDTO> productqlspSearch = new List<SpQLSPDTO>();
        Panel[] pnlProduct;
        Label[] id ;
        Label[] name ;
        Label[] type ;
        PictureBox[] img;
        Label[] price;
        Label[] origin;
        Label[] producer;
        Button[] btnEdit ;
        public SanPhamQLSP()
        {
            InitializeComponent();
        }
     
        public void resetData()
        {
            productCtl = SpQLSPBLL.GetData();
            loadDataToProduct(productCtl);
        }


        public void loadDataToProduct(List<SpQLSPDTO> productCtl)
        {
          
            panelForm.Controls.Clear();
            panelForm.Refresh();
            pnlProduct = new Panel[productCtl.Count];
             id = new Label[productCtl.Count];
            name = new Label[productCtl.Count];
             type = new Label[productCtl.Count];
             img = new PictureBox[productCtl.Count];
            price = new Label[productCtl.Count];
            origin = new Label[productCtl.Count];
            producer = new Label[productCtl.Count];
            btnEdit = new Button[productCtl.Count];
            Font SmallFont = new Font("Arial", 11);
           


            for (int i = 0; i < productCtl.Count; i++)
            {
                pnlProduct[i] = new Panel();
                pnlProduct[i].BorderStyle = BorderStyle.FixedSingle;
                pnlProduct[i].Size = new Size(686, 64);

                id[i] = new Label();
                id[i].Location = new Point(15, 22);
                id[i].Size = new Size(25, 17);
                id[i].Margin = new Padding(2, 0, 2, 0);
                id[i].Font = SmallFont;
                id[i].Text = productCtl[i].Id.ToString();
                id[i].TextAlign = ContentAlignment.MiddleCenter;

                name[i] = new Label();
                name[i].Size = new Size(140, 44);
                name[i].ForeColor = Color.Black;
                name[i].Font = SmallFont;
                name[i].Text = productCtl[i].Name.ToString();
                name[i].Margin = new Padding(2, 0, 2, 0);
                name[i].Location = new Point(74, 9);
                name[i].TextAlign = ContentAlignment.MiddleLeft;
                /*
                type[i] = new Label();
                type[i].Size = new Size(100, 40);
                type[i].Font = SmallFont;
                type[i].Margin = new Padding(2, 0, 2, 0);
                type[i].Name = productCtl[i].Type.ToString();
                type[i].Text = productCtl[i].Type.ToString();
                type[i].Location = new Point(160, 22);
                type[i].TextAlign = ContentAlignment.MiddleCenter;
                */
                img[i] = new PictureBox();
                img[i].Location = new Point(260, 10);
                img[i].Size = new Size(70, 45);
                img[i].Margin = new Padding(2, 0, 2, 0);
                img[i].Name = productCtl[i].Image;
                img[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                img[i].Image = new Bitmap(productCtl[i].Image);


                price[i] = new Label();
                price[i].Size = new Size(90, 20);
                price[i].Font = SmallFont;
                price[i].Margin = new Padding(2, 0, 2, 0);
                price[i].Text = productCtl[i].Prices.ToString();
                price[i].Location = new Point(370, 18);
                price[i].TextAlign = ContentAlignment.MiddleCenter;

                origin[i] = new Label();
                origin[i].Size = new Size(60, 40);
                origin[i].Font = SmallFont;
                origin[i].Margin = new Padding(2, 0, 2, 0);
                origin[i].Text = productCtl[i].Origin.ToString();
                origin[i].Location = new Point(480, 9);
                origin[i].TextAlign = ContentAlignment.MiddleCenter;

                btnEdit[i] = new Button();
                btnEdit[i].Text = "Sửa";
                btnEdit[i].Size = new Size(80, 30);
                btnEdit[i].Margin = new Padding(2, 1, 2, 1);
                btnEdit[i].Location = new Point(570, 15);
                btnEdit[i].TextAlign = ContentAlignment.MiddleCenter;
                btnEdit[i].Name = id[i].Text;
                btnEdit[i].Click += HandleUpdate;
                /*
                if (Login._checkUrlMatch("suasanpham:QLSP"))
                {
                    btnEdit[i].Visible = true;
                }
                else
                {
                    btnEdit[i].Visible = false;
                }
                */
                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(producer[i]);
                pnlProduct[i].Controls.Add(btnEdit[i]);
                panelForm.Controls.Add(pnlProduct[i]);

            }
            


        }

        


        void HandleUpdate(object sender, EventArgs e)
        {
            for (int i = 0; i < productCtl.Count; i++)
            {
                if (productCtl[i].Id.ToString() == (sender as Button).Name)
                {
                    UpdateSanPhamQLSP qlsp = new UpdateSanPhamQLSP(productCtl[i].Id.ToString(), productCtl[i].Name, productCtl[i].Type, productCtl[i].Origin, productCtl[i].Prices.ToString(), productCtl[i].Quantity.ToString(), productCtl[i].Image, productCtl[i].producer);
                    qlsp.ShowDialog();
                    if(qlsp.flag == true)
                    {
                        resetData();
                    }
                    break;
                }
            }
        }


        private void SanPhamQLSP_Click(object sender, EventArgs e)
        {
        }

       

        private void HandleSearch()
        {
            productqlspSearch.Clear();
            if (textBox1.Text.Trim() == "" )
            {
                loadDataToProduct(productCtl);
                return;
            }
            foreach (SpQLSPDTO product in productCtl)
            {
                if (product.Id.ToString() == textBox1.Text)
                {
                    productqlspSearch.Add(product);
                }
                else if (product.Name.ToUpper().IndexOf(textBox1.Text.ToUpper()) != -1)
                {
                    productqlspSearch.Add(product);
                }
            }
            loadDataToProduct(productqlspSearch);


        }

        private void nameSP_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HandleSearch();
            }
        }

        private void SanPhamQLSP_Load(object sender, EventArgs e)
        {
            resetData();
        }
    }


}

