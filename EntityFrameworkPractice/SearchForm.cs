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
            
            foreach(var d in data) { label3.Text = $"{d.Id} {d.Name} {d.Quantity}個 {d.Price:C} {d.Type}"; }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new ItemsModel();
            var list = context.ItemTable.ToList();
            var data = list.Where(x => x.Name == textBox2.Text.ToString());
            foreach (var d in data) { label3.Text = $"{d.Id} {d.Name} {d.Quantity}個 {d.Price:C} {d.Type}"; }
        }
    }
}
