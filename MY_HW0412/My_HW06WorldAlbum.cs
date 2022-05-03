using MY_HW0412.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            LoadCountryToCombobox();

            this.cityAlbumTableAdapter1.Fill(this.worldAlbumDataSet12.CityAlbum);


            this.worldAlbumTableAdapter1.Fill(this.worldAlbumDataSet12.WorldAlbum);
            this.picturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;    


            for (int i = 0; i <= worldAlbumDataSet12.CityAlbum.Rows.Count - 1; i++)
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{worldAlbumDataSet12.CityAlbum.Rows[i][1]}";
                x.Left = 50;
                x.Top = 100 * i + 50;
                x.Tag = i;
                x.Click += X_Click;
                this.splitContainer2.Panel1.Controls.Add(x);
            }
            //====================================
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;
        }

        private void LoadCountryToCombobox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select * from CityAlbum";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        comboBox1.Items.Add(dataReader["CategoryName"]);
                    }
                    this.comboBox1.Text = "請選擇國家...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            if (comboBox1.Text == "請選擇國家...")
            {
                MessageBox.Show("請選擇國家!");
                return;
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))

                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"Insert into WorldAlbum(CategoryID,picture) values (@CID,@pic)"; ;
                        command.Connection = conn;
                        conn.Open();


                        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                        for (int i = 0; i <= files.Length - 1; i++)
                        {
                            command.Parameters.Clear();
                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromFile(files[i]);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Width = 360;
                            pic.Height = 240;
                            pic.Padding = new Padding(4, 4, 4, 4);
                            this.flowLayoutPanel3.Controls.Add(pic);

                            byte[] bytes;
                            MemoryStream ms = new MemoryStream();
                            pic.Image.Save(ms, ImageFormat.Jpeg);
                            bytes = ms.GetBuffer();

                            command.Parameters.Add("@CID", SqlDbType.Int).Value = this.comboBox1.SelectedIndex + 1;
                            command.Parameters.Add("@pic", SqlDbType.Image).Value = bytes;
                            command.ExecuteNonQuery();
                            //MessageBox.Show(command.CommandText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LinkLabel x = sender as LinkLabel;
            if (x != null)
            {
                string CountryN = x.Text;
                ShowImage(CountryN);
            }
        }

        private void ShowImage(string countryN)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select Picture from CityAlbum join WorldAlbum on CityAlbum.CategoryID = WorldAlbum.CategoryID where CategoryName='{countryN}'";
                    command.Connection = conn;

                    conn.Open();


                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            PictureBox pic = new PictureBox();
                            byte[] bytes = (byte[])dataReader["Picture"];
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                            this.flowLayoutPanel1.Controls.Add(pic);
                            pic.Image = Image.FromStream(ms);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Width = 360;
                            pic.Height = 240;
                            pic.BorderStyle = BorderStyle.FixedSingle;
                            pic.Padding = new Padding(4, 4, 4, 4);
                            pic.Click += Pic_Click; ;
                            pic.MouseLeave += Pic_MouseLeave;
                            pic.MouseEnter += Pic_MouseEnter;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Red;
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Stretch;
            f.Width = 900;
            f.Height = 600;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "請選擇國家...")
            {
                MessageBox.Show("請選擇國家!");
                return;
            }
            else
            {
                if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo direIn = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                    FileInfo[] fi = direIn.GetFiles("*.jpg",SearchOption.AllDirectories); //設定要找的圖片副檔名 
                    foreach (FileInfo file in fi)
                    {
                        PictureBox pic = new PictureBox();
                        FileStream fs = File.OpenRead(folderBrowserDialog1.SelectedPath + @"\" + file);
                        pic.Image = Image.FromFile(fs.Name);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 360;
                        pic.Height = 240;
                        pic.Padding = new Padding(4, 4, 4, 4);
                        this.flowLayoutPanel3.Controls.Add(pic);
                        try
                        {
                            using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))

                            {
                                SqlCommand command = new SqlCommand();
                                command.CommandText = $"Insert into WorldAlbum(CategoryID,picture) values (@CID,@pic)"; ;
                                command.Connection = conn;

                                conn.Open();
                                //command.Parameters.Clear();
                                byte[] bytes;
                                MemoryStream ms = new MemoryStream();
                                pic.Image.Save(ms, ImageFormat.Jpeg);
                                bytes = ms.GetBuffer();

                                command.Parameters.Add("@CID", SqlDbType.Int).Value = this.comboBox1.SelectedIndex + 1;
                                command.Parameters.Add("@pic", SqlDbType.Image).Value = bytes;
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))
                {
                    flowLayoutPanel1.Controls.Clear();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Select * from WorldAlbum where CategoryID='{comboBox1.SelectedIndex + 1}'";
                    command.Connection = conn;
                    conn.Open();

                    SqlDataReader dataReader1 = command.ExecuteReader();
                    while (dataReader1.Read())
                    {
                        byte[] bytes = (byte[])dataReader1["Picture"];
                        MemoryStream ms = new MemoryStream(bytes);
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 360;
                        pic.Height = 240;
                        pic.BorderStyle = BorderStyle.FixedSingle;
                        pic.Padding = new Padding(4, 4, 4, 4);

                        flowLayoutPanel3.Controls.Add(pic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cityAlbumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityAlbumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldAlbumDataSet12);

        }

        private void browse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "((*.jpg )| *.jpg|(*.bmp)|*.bmp|Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF)";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
