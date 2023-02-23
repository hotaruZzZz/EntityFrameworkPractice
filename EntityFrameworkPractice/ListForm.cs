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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var context = new ItemsModel();
            var list = context.ItemTable.ToList();
            dataGridView1.DataSource = list;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
