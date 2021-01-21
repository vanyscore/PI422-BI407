using AspCitylink.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCitylinkGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var web = new WebClient();
            web.Encoding = Encoding.UTF8;
            string urlNote = @"https://www.citilink.ru/catalog/mobile/notebooks/?available=1&status=55395790&p=";
            string urlSmart = @"https://www.citilink.ru/catalog/mobile/smartfony/?available=1&status=55395790&p=";
            string urlTablets = @"https://www.citilink.ru/catalog/mobile/tablet_pc/?available=1&status=55395790&p=";
            string urlTV = @"https://www.citilink.ru/catalog/audio_and_digits/tv/?available=1&status=55395790&p=";
            string urlVC = @"https://www.citilink.ru/catalog/computers_and_notebooks/parts/videocards/?available=1&status=55395790&p=";


            var db = new ModelCitylinkContainer();

            var category = db.Categories.FirstOrDefault(x=>x.Name=="VideoCard");
            if (category == null)
            {
                category = new Category() { Name = "VideoCard" };
                db.Categories.Add(category);
                db.SaveChanges();
            }

            for (int i = 1; i < 12; i++)
            {
                GetProductFromPage(db, category, web, urlVC, i);
            }
        }

        public void GetProductFromPage(
            ModelCitylinkContainer db, 
            Category category,
            WebClient web, 
            string url, 
            int pageNumber)
        {
            MessageBox.Show("Page Number " + pageNumber);
            url += pageNumber;
            string document = web.DownloadString(url);

            string stMarkStart = "<div class=\"image subcategory-product-item__image\">";
            string stPriceStart = "<ins class=\"subcategory-product-item__price-num\">";
            string stPriceEnd = "</ins>";
            string stImage = @"https://items.s1.citilink.ru/";
            string stTitle = "title=\"";


            int index = 0;
            while (true)
            {
                int i1 = document.IndexOf(stMarkStart, index);
                if (i1 < 0)
                {
                    MessageBox.Show("товар не найден!");
                    return;
                }
                //----------------------------------------------
                int ind1Title = document.IndexOf(stTitle, i1);
                ind1Title += stTitle.Length;
                int ind2Title = document.IndexOf("\"", ind1Title);
                string title = document.Substring(ind1Title, ind2Title - ind1Title);
                textBox1.Text += title + "\r\n";
                //----------------------------------------------------
                int ind1Image = document.IndexOf(stImage, ind2Title);
                int ind2Image = document.IndexOf("\"", ind1Image + 1);
                string image = document.Substring(ind1Image, ind2Image - ind1Image);
                textBox1.Text += image + "\r\n";
                //------------------------------------------------------
                int ind1Price = document.IndexOf(stPriceStart, ind2Title);
                ind1Price += stPriceStart.Length;
                int ind2Price = document.IndexOf(stPriceEnd, ind1Price);
                string price = document.Substring(ind1Price, ind2Price - ind1Price);
                price = price.Replace(" ", "");
                textBox1.Text += price + "\r\n";

                index = ind2Price;
                


                string filename = "Images\\" + category.Name + Guid.NewGuid().ToString()+".jpg";

                web.DownloadFile(image, filename);


                // товар помещаем в базу
                var prod = new Product()
                {
                    Title = title,
                    ImageUrl = filename,
                    Price = int.Parse(price),
                    CategoryOfProduct = category
                };
               
                db.Products.Add(prod);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
