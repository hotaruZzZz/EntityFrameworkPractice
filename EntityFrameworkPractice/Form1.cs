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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new InsertForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new ListForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new UpdateForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var from = new DeleteForm();
            from.ShowDialog();
        }
    }
}
