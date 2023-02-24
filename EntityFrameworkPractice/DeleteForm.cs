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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkPractice
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemsModel i = new ItemsModel();
            var data = i.ItemTable.Find(int.Parse(textBox1.Text));
            try
            {
                if (data == null) {
                    i.ItemTable.Remove(data);
                    i.SaveChanges();
                    MessageBox.Show(data.Name + " delete success!");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("無此商品，請輸入已存在商品ID");
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }
    }
}
