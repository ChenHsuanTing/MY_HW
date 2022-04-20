using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_HW0412
{
    public partial class My_HW03Products : Form
    {
        public My_HW03Products()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(this.nwDataSet11.Products);
            //this.dataGridView1.DataSource = this.nwDataSet11.Products;
            this.bindingSource1.DataSource = this.nwDataSet11.Products;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label2.Text = $"{this.bindingSource1.Position + 1}/{this.bindingSource1.Count}";
            this.lblResult.Text = $"結果為 {this.bindingSource1.Count} 筆";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            decimal Min = Convert.ToDecimal(textBox1.Text);
            decimal Max = Convert.ToDecimal(textBox2.Text);

            this.productsTableAdapter1.UnitPriceBetweenFillBy(nwDataSet11.Products, Min, Max);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            this.productsTableAdapter1.ProductSearchFillBy(nwDataSet11.Products, '%'+name+ '%');
        }
    }
}
