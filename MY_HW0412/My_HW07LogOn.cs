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
    public partial class My_HW07LogOn : Form
    {
        public My_HW07LogOn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //logonbutton
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (UsernameTextBox.Text == "" | PasswordTextBox.Text == "")
            {
                MessageBox.Show("請輸入帳號密碼!!!");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Insert into MyMember(Username, Password) values(@username, @password)";
                        command.Connection = conn;
                        command.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                        command.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("註冊成功!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void OK_Click(object sender, EventArgs e)
        {
            
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            if (UsernameTextBox.Text == "" | PasswordTextBox.Text == "") 
            {
                MessageBox.Show("請輸入帳號密碼!!!");
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                    {
                        SqlCommand comm = new SqlCommand();
                        comm.CommandText = $"select Username,password from Mymember where username=@username and password=@password";
                        comm.Connection = conn;
                        comm.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                        comm.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
                        conn.Open();
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("登入成功!!!");
                            FrmAdoHW adoHW = new FrmAdoHW();
                            adoHW.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("登入失敗!!!");
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

    
        private void Cancel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
        }
    }
           
}
