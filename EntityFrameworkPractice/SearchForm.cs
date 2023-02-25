using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPractice
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ItemsModel();
            var list = context.ItemTable.ToList();
            var data = list.Where(x => x.Id == int.Parse(textBox1.Text.Trim()));
            try
            {
                if (data.Any())
                {
                    foreach (var d in data) { label3.Text = $"ID: {d.Id}\n商品名稱: {d.Name}\n數量: {d.Quantity}個\n價錢: {d.Price:C}\n類型: {d.Type}"; }

                }
                else
                {
                    label3.Text = "查無此商品";
                }
            }
            catch (Exception ex) { label3.Text+= ex.Message; }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new ItemsModel();
            var list = context.ItemTable.ToList();
            var data = list.Where(x => x.Name == textBox2.Text.ToString());
            try
            {
                if (data.Any())
                {
                    foreach (var d in data) { label3.Text = $"ID: {d.Id}\n商品名稱: {d.Name}\n數量: {d.Quantity}個\n價錢: {d.Price:C}\n類型: {d.Type}"; }

                }
                else
                {
                    label3.Text = "查無此商品";
                }
            }
            catch (Exception ex) { label3.Text += ex.Message; }
        }
    }
}
