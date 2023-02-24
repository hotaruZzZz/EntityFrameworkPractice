using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPractice
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemsModel i = new ItemsModel();
            var data = i.ItemTable.ToList().Where(x => x.Id == int.Parse(textBox1.Text.Trim())).First();
            try
            {
                data.Name = textBox2.Text.Trim();
                data.Quantity = int.Parse(textBox3.Text);
                data.Price = decimal.Parse(textBox4.Text);
                data.Type = textBox5.Text.Trim();
                i.ItemTable.AddOrUpdate(data);
                i.SaveChanges();
                MessageBox.Show($"update success!");
                ClearTextBoxes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
