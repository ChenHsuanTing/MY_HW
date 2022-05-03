using MyHW;
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
    public partial class FrmAdoHW : Form
    {
        public FrmAdoHW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            My_HW01標準練習 my_HW01 = new My_HW01標準練習();
            my_HW01.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW01);
            my_HW01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            My_HW02CategoryProduct my_HW02 = new My_HW02CategoryProduct();
            my_HW02.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW02);
            my_HW02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            My_HW03Products my_HW03 = new My_HW03Products();
            my_HW03.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW03);
            my_HW03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            My_HW04DataSet my_HW04 = new My_HW04DataSet();
            my_HW04.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW04);
            my_HW04.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            My_HW05AdventureWork my_HW05 = new My_HW05AdventureWork();
            my_HW05.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW05);
            my_HW05.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V2 my_HW06 = new FrmMyAlbum_V2();
            my_HW06.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW06);
            my_HW06.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            My_HW07Customers my_HW07 = new My_HW07Customers();
            my_HW07.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW07);
            my_HW07.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmTreeView my_HW08 = new FrmTreeView();
            my_HW08.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(my_HW08);
            my_HW08.Show();
        }
    }
}
