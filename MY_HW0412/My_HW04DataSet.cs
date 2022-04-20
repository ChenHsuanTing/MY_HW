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
    public partial class My_HW04DataSet : Form
    {
        public My_HW04DataSet()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet11.Categories);
            this.dataGridView4.DataSource = this.nwDataSet11.Categories;

            this.customersTableAdapter1.Fill(this.nwDataSet11.Customers);
            this.dataGridView5.DataSource = this.nwDataSet11.Customers;

            this.productsTableAdapter1.Fill(this.nwDataSet11.Products);
            this.dataGridView6.DataSource = this.nwDataSet11.Products;
            //=========================================================


            for (int i = 0; i <= this.nwDataSet11.Tables.Count - 1; i++)
            {
                DataTable table = this.nwDataSet11.Tables[i];
                this.listBox2.Items.Add(table.TableName);

                String A = "  ";
                for (int column = 0; column <= table.Columns.Count - 1; column++)
                {
                    A += $"{ table.Columns[column].ColumnName,-60}";
                }
                this.listBox2.Items.Add(A);
                this.listBox2.Items.Add("======================================");

                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    string B = "";
                    for (int T = 0; T <= table.Columns.Count - 1; T++)
                    {
                        B += $"{table.Rows[row][T],-60}";
                    }
                    this.listBox2.Items.Add(B);

                }
                this.listBox2.Items.Add("======================================");
              
                //this.listBox2.Items.Clear();

                //for (int i = 0; i <= this.nwDataSet11.Tables.Count - 1; i++)
                //{
                //    DataTable table = this.nwDataSet11.Tables[i];
                //    this.listBox2.Items.Add(table.TableName);

                //    //table.column //column schema
                //    string s = "  ";
                //    for (int column = 0; column <= table.Columns.Count - 1; column++)
                //    {
                //        s += $"{table.Columns[column].ColumnName + "  ",-60}";
                //    }
                //    this.listBox2.Items.Add(s);
                //    this.listBox2.Items.Add("===========================================================================================================");
                //    //table.row --Data
                //    for (int row = 0; row <= table.Rows.Count - 1; row++)
                //    {
                //        //Datarow dr = table.Rows[row];
                //        string t = "  ";
                //        for (int a = 0; a <= table.Columns.Count - 1; a++)
                //        {
                //            t += $"{table.Rows[row][a],-60}";

                //        }
                //        this.listBox2.Items.Add(t);
                //    }
                //    this.listBox2.Items.Add("===========================================================================================================");
            }


        }
    }

}
