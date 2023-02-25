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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextBoxes()
        {
            //textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemTable data = new ItemTable()
            {
                //Id = int.Parse(textBox1.Text.Trim()),
                Name = textBox2.Text.Trim(),
                Quantity = int.Parse(textBox3.Text.Trim()),
                Price = decimal.Parse(textBox4.Text.Trim()),
                Type = textBox5.Text.Trim()
            };
            try
            {
                ItemsModel context = new ItemsModel();
                context.ItemTable.Add(data);
                context.SaveChanges();
                MessageBox.Show($"-存檔完成-\nID:{data.Id}\n商品名稱: {data.Name}\n商品價格: {data.Price:C}\n商品數量: {data.Quantity}\n商品類型: {data.Type}");
                ClearTextBoxes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
