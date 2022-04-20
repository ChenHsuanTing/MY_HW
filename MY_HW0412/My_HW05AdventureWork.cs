using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_HW0412
{
    public partial class My_HW05AdventureWork : Form
    {
        public My_HW05AdventureWork()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(this.awDataSet11.ProductPhoto);
            this.bindingSource1.DataSource = this.awDataSet11.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;

            this.bindingNavigator1.BindingSource = this.bindingSource1;


            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection
       ("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand
                    ("Select distinct year(ModifiedDate) as 'ModifiedDate' from Production.ProductPhoto", conn);
                SqlDataReader DataReader = command.ExecuteReader();


                while (DataReader.Read())
                {
                    string s = $"{DataReader["ModifiedDate"]}";
                    this.comboBox1.Items.Add(s);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource1.Position + 1}/{this.bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Min = dateTimePicker1.Value;
            DateTime Max = dateTimePicker2.Value;
            this.productPhotoTableAdapter1.ModifiedDateFillBy(awDataSet11.ProductPhoto, Min, Max);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime Min = dateTimePicker1.Value;
            DateTime Max = dateTimePicker2.Value;
            this.productPhotoTableAdapter1.orderModifiedDateFillBy(awDataSet11.ProductPhoto, Min, Max);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(comboBox1.SelectedItem);
            this.productPhotoTableAdapter1.ModifiedDateLIKEFillBy(awDataSet11.ProductPhoto, a);

        }
        
    }
}
