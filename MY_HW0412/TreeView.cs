using MY_HW0412.Properties;
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
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
            this.customersTableAdapter1.Fill(this.nwDataSet11.Customers);
            this.bindingSource1.DataSource = nwDataSet11.Customers;
            this.dataGridView1.DataSource = bindingSource1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.customersTableAdapter1.Fillcity(nwDataSet11.Customers, e.Node.Text);
            this.bindingSource1.DataSource = nwDataSet11.Customers;
            this.dataGridView1.DataSource = bindingSource1;

            if (dataGridView1.Columns.Count == 0)
            {
                label1.Text = "";
            }
            else
            {
                label1.Text = "共" + dataGridView1.Columns.Count + "個" + e.Node.Text + "的客戶";
            }
        }

        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "select * from Customers"; ;
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string country = dataReader["Country"].ToString();
                        string city = dataReader["City"].ToString();
                        string customer = dataReader["CustomerID"].ToString();
                        TreeNode firstNode;

                        if (treeView1.Nodes[country] == null)
                        {
                            TreeNode trnode = new TreeNode(country);
                            trnode.Name = country;
                            treeView1.Nodes.Add(trnode);
                            firstNode = trnode;
                        }
                        else
                        {
                            firstNode = treeView1.Nodes[country];
                        }


                        if (firstNode.Nodes[city] == null)
                        {
                            TreeNode trnode = new TreeNode(city);
                            trnode.Name = city;
                            firstNode.Nodes.Add(trnode);
                            firstNode = trnode;
                        }
                        else
                        {
                            firstNode = firstNode.Nodes[city];
                        }

                        //if (firstNode.Nodes[customer] == null)
                        //{
                        //    TreeNode trnode = new TreeNode(customer);
                        //    trnode.Name = customer;
                        //    firstNode.Nodes.Add(trnode);
                        //    firstNode = trnode;
                        //}
                        //else
                        //{
                        //    firstNode = firstNode.Nodes[customer];
                        //}
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
