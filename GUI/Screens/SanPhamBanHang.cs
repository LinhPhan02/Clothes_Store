using BLL;
using DTO;
using GUI.Popups;
using GUI.Properties;
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
    public partial class SanPhamBanHang : UserControl
    {

        public static List<SpQLSPDTO> productCtl = new List<SpQLSPDTO>();
        public static List<SpQLSPDTO> cart = new List<SpQLSPDTO>();

        List<SpQLSPDTO> spbhSearch = new List<SpQLSPDTO>();
         public static List<spcbhDTO> cartbh = new List<spcbhDTO>();
        Panel[] pnlProduct;
        Label[] id;
        Label[] name;
        Label[] type;
        PictureBox[] img;
        Label[] price;
        Label[] origin;
        Label[] producer;
        Button[] button;

        public SanPhamBanHang()
        {
            InitializeComponent();
            //loadDataToDataSPBH(productCtl);
        }

        public void resetData()
        {
            productCtl = SpQLSPBLL.GetDataAction();

            loadDataToDataSPBH(productCtl);
        }
        public void loadDataToDataSPBH(List<SpQLSPDTO> productCtl)  //Trước khi sửa là private
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
            button = new Button[productCtl.Count];
            Font SmallFont = new Font("Arial", 11);
           // ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));


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

                button[i] = new Button();
                button[i].Text = "Chọn";
                button[i].Size = new Size(80, 30);
                button[i].Margin = new Padding(2, 1, 2, 1);
                button[i].Location = new Point(570, 15);
                button[i].TextAlign = ContentAlignment.MiddleCenter;
                button[i].Name = id[i].Text;
                button[i].Click += HandleShowChild;

                /*
                if (Login._checkUrlMatch("chonsanphammua:BH"))
                {
                    button[i].Visible = true;
                }
                else
                {
                    button[i].Visible = false;
                }
                */
                pnlProduct[i].Controls.Add(id[i]);
                pnlProduct[i].Controls.Add(name[i]);
                pnlProduct[i].Controls.Add(type[i]);
                pnlProduct[i].Controls.Add(img[i]);
                pnlProduct[i].Controls.Add(price[i]);
                pnlProduct[i].Controls.Add(origin[i]);
                pnlProduct[i].Controls.Add(producer[i]);
                pnlProduct[i].Controls.Add(button[i]);

                panelForm.Controls.Add(pnlProduct[i]);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void floSPBH_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HandleSearch()
        {
            spbhSearch.Clear();
            if (textBox1.Text.Trim() == "")
            {
                loadDataToDataSPBH(productCtl);
                return;
            }
            foreach (SpQLSPDTO product in productCtl)
            {
                if (product.Id.ToString() == textBox1.Text)
                {
                    spbhSearch.Add(product);
                }
                else if (product.Name.ToUpper().IndexOf(textBox1.Text.ToUpper()) != -1)
                {
                    spbhSearch.Add(product);
                }
            }
            loadDataToDataSPBH(spbhSearch);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

 

        void HandleShowChild(object sender, EventArgs e)
        {
                SPConBanHang spc = new SPConBanHang((sender as Button).Name);
                spc.ShowDialog(); 
        }

        private void SanPhamBanHang_Load(object sender, EventArgs e)
        {
            resetData();
        }
    }
}
