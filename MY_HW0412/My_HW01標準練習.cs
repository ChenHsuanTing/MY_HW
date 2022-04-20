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
    public partial class My_HW01標準練習 : Form
    {
        public My_HW01標準練習()
        {
            InitializeComponent();
        }

        private void btnOddorEven_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtkeyin.Text, out int num);
            if (isNum == false)
                MessageBox.Show("請輸入正確數值!");
            else if (num % 2 == 0)
                lblResult.Text = "Even";
            else
                lblResult.Text = "Odd";
        }

        private void btn3Max_Click(object sender, EventArgs e)
        {
            int[] Array = { 100, 66, 77 };
            lblResult.Text = "最大值為" + Array.Max();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int f = int.Parse(this.txtFrom.Text),
                t = int.Parse(this.txtTo.Text),
                s = int.Parse(this.txtStep.Text);
            int sum = 0;
            if (!string.IsNullOrEmpty(this.txtFrom.Text) && !string.IsNullOrEmpty(this.txtTo.Text) && !string.IsNullOrEmpty(this.txtStep.Text))
            {
                for (; f <= t; f += s)
                {
                    sum += f;
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
            lblResult.Text = sum.ToString();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int f = int.Parse(this.txtFrom.Text),
               t = int.Parse(this.txtTo.Text),
               s = int.Parse(this.txtStep.Text);
            int sum = 0;
            if (!string.IsNullOrEmpty(this.txtFrom.Text) && !string.IsNullOrEmpty(this.txtTo.Text) && !string.IsNullOrEmpty(this.txtStep.Text))
            {
                while (f <= t)
                {
                    sum += f;
                    f += s;
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
            lblResult.Text = sum.ToString();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int f = int.Parse(this.txtFrom.Text),
                t = int.Parse(this.txtTo.Text),
                s = int.Parse(this.txtStep.Text);
            int sum = 0;
            if (!string.IsNullOrEmpty(this.txtFrom.Text) && !string.IsNullOrEmpty(this.txtTo.Text) && !string.IsNullOrEmpty(this.txtStep.Text))
            {
                do
                {
                    sum += f;
                    f += s;
                }
                while (f <= t);
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
            lblResult.Text = sum.ToString();
        }

        private void btnCountOddEven_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 56, 34, 99, 58, 64 };
            int odd = 0;
            int even = 0;
            foreach (int i in nums)
            {
                if (i % 2 == 0) { even++; }
                else { odd++; }
            }
            lblResult.Text = "奇數有" + odd.ToString() + "個\n偶數有" + even.ToString() + "個";
        }

        private void btnLongName_Click(object sender, EventArgs e)
        {

            int a = 0;
            string result = "";
            string[] names = { "aaa", "dfsf", "dsfdaegd", "fjsdk", "qqw" };

            for (int i = 0; i < names.Length; i++)
            {
                if (a < names[i].Length)
                {
                    a = names[i].Length;
                    result = names[i];
                }
            }
            lblResult.Text = result;
        }

        private void btnHaveC_Click(object sender, EventArgs e)
        {
            int COUNT = 0;
            String[] names = { "aaa", "bbb", "ccc", "Mary", "Tom", "Cat", "Back" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Contains("c") || names[i].Contains("C"))
                { COUNT++; }
            }
            lblResult.Text = COUNT.ToString();
        }

        private void btnMaxParams_Click(object sender, EventArgs e)
     
            {
                Params(10, 30, 50, 70, 90);
            }
            void Params(params int[] nums)
            {
                lblResult.Text = $"最大值為{ nums.Max()}";
            }
        

        private void btnMaxMin_Click(object sender, EventArgs e)
        {

            int[] scores = { -4, 3, 46, 33, 22, 100, 150, 33, 55 };
            int max = scores.Max();
            int min = scores.Min();
            lblResult.Text = "Min值為:  " + min + "\nMax值為:  " + max; ;
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            int[] randomArray = new int[6];
            Random rd = new Random();
            for (int i = 0; i < 6; i++)
            {
                randomArray[i] = rd.Next(1, 49);
                for (int j = 0; j < i; j++)
                {
                    while (randomArray[i] == randomArray[j])
                    {
                        j = 0;
                        randomArray[i] = rd.Next(1, 49);
                    }
                }
            }
            lblResult.Text = "樂透號碼\n" + randomArray[0].ToString() + "," + randomArray[1].ToString()
                                     + "," + randomArray[2].ToString() + "," + randomArray[3].ToString()
                                     + "," + randomArray[4].ToString() + "," + randomArray[5].ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    lblResult.Text += j + " x " + i + " = " + j * i + "  ";

                }
                lblResult.Text += "\n";
            }
        }

        private void btnHundred_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(100, 2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }
    }
    
}
