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
    public partial class My_HW07Customers : Form
    {
        public My_HW07Customers()
        {
            InitializeComponent();
            this.listView1.View = View.Details; 
            //顯示所有details
            CreatListView();
            LoadCountryToCombobox();

        }

        private void CreatListView()
        {


            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select * from Customers", conn);
                    SqlDataReader DataReader = command.ExecuteReader();

                    DataTable table = DataReader.GetSchemaTable();
                    this.dataGridView1.DataSource = table;

                    for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {
                        //string columnName = table.Rows[i][0].ToString();
                        //listView1.Columns.Add(columnName);
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCountryToCombobox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand cm = new SqlCommand
                    ("Select distinct country from customers", conn);
                    SqlDataReader dr = cm.ExecuteReader();

                    this.comboBox1.Items.Add("All Country");

                    while (dr.Read())
                    {
                        this.comboBox1.Items.Add(dr["Country"]);
                    }
                    
                    this.comboBox1.SelectedIndex = 0;
                    //讓選單出現第一個
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All Country")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();
                        SqlCommand cm = new SqlCommand();
                        //("Select * from Customers WHERE Country = 'USA'", conn);
                        cm.CommandText = $"Select * from Customers";
                        cm.Connection = conn;


                        SqlDataReader dr = cm.ExecuteReader();

                        this.listView1.Items.Clear();

                        Random rd = new Random();
                        //隨機顯示國旗

                        //讓內部每行的資料秀出來
                        while (dr.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dr[0].ToString());

                            lvi.ImageIndex = rd.Next(0, this.ImageList1.Images.Count);

                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                lvi.BackColor = Color.Yellow;
                            }


                            for (int i = 1; i <= dr.FieldCount - 1; i++)
                            {
                                //true可打可不打
                                if (dr.IsDBNull(i) == true)
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dr[i].ToString());
                                }

                            }
                        }

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        conn.Open();
                        SqlCommand cm = new SqlCommand();
                        //("Select * from Customers WHERE Country = 'USA'", conn);
                        cm.CommandText = ($"select * from Customers where Country = '{comboBox1.Text}'");
                        cm.Connection = conn;


                        SqlDataReader dr = cm.ExecuteReader();

                        this.listView1.Items.Clear();

                        Random rd = new Random();
                        //隨機顯示國旗

                        //讓內部每行的資料秀出來
                        while (dr.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dr[0].ToString());

                            lvi.ImageIndex = rd.Next(0, this.ImageList1.Images.Count);

                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                lvi.BackColor = Color.Yellow;
                            }


                            for (int i = 1; i <= dr.FieldCount - 1; i++)
                            {
                                //true可打可不打
                                if (dr.IsDBNull(i) == true)
                                {
                                    lvi.SubItems.Add("空值");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dr[i].ToString());
                                }

                            }
                        }

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
    }
    //TODO HW

    //1. All Country


    //================================
    //2. ContextMenuStrip2
    //選擇性作業
    //Groups
    //USA (100) 
    //UK (20)

    //this.listview1.visible = false;
    //ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

    //if (this.listView1.Groups["USA"] == null)
    //{                       {
    //    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
    //    group.Tag = 0;
    //    lvi.Group = group; 
    //}
    //else
    //{
    //    ListViewGroup group = this.listView1.Groups["USA"]; 
    //    lvi.Group = group;
    //}

    //this.listView1.Groups["USA"].Tag = 
    //this.listView1.Groups["USA"].Header = 


}
