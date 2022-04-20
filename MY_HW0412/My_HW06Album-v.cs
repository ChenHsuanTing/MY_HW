using MY_HW0412;
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

namespace MyHW
{
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();

            //====================================
            using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = $"Select * from WorldAlbumtable";
                command.Connection = conn;
                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBox1.Items.Add(dataReader["country"]);
                }
            }
            //====================================
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;

            //====================================
            this.worldAlbumTableTableAdapter1.Fill(this.worldAlbumDataSet11.WorldAlbumTable);

            for (int i = 0; i <= worldAlbumDataSet11.WorldAlbumTable.Rows.Count - 1; i++)
            {
                LinkLabel x = new LinkLabel();
                x.Text = $"{worldAlbumDataSet11.WorldAlbumTable.Rows[i][0]}";
                x.Left = 50;
                x.Top = 100 * i + 50;
                x.Tag = i;
                x.Click += X_Click;
                this.splitContainer2.Panel1.Controls.Add(x);
            }
            //======================================

        }

        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i <= files.Length - 1; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 120;
                pic.Height = 80;

                this.flowLayoutPanel3.Controls.Add(pic);
            }
            //todo
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    Bitmap b = new Bitmap(flowLayoutPanel1.Width, flowLayoutPanel1.Height);
            //    flowLayoutPanel1.DrawToBitmap(b, flowLayoutPanel1.ClientRectangle);
            //    b.Save(saveFileDialog1.FileName);
            //}
        }



        private void X_Click(object sender, EventArgs e)
        {
            //todo
            //LinkLabel X = sender as LinkLabel;
            //if (X != null)
            //{
            //    flowLayoutPanel1.Controls.Add
            //}
        }

        private void worldAlbumTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.worldAlbumTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldAlbumDataSet11);

        }

        private void insertdb_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.WorldAlbumConnectionString))

                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Insert into WorldAlbumTable(photo) values (@Image)"; ;
                    command.Connection = conn;

                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();

                   
                    command.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;


                    conn.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Insert Image Successfully!!");

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "((*.jpg )| *.jpg|(*.bmp)|*.bmp|Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF)";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }
    }
}
//this.myAlbumTableTableAdapter1.Fill(myLocationDataSet1.MyAlbumTable);
//for (int i = 0; i <= myLocationDataSet1.MyAlbumTable.Rows.Count - 1; i++)
//{
//    LinkLabel x = new LinkLabel();
//    x.Text = $"{myLocationDataSet1.MyAlbumTable.Rows[i][2]}";
//    x.Left = 30;
//    x.Top = 30 * i;
//    x.Tag = i;//ID

//    x.Click += X_Click;
//    this.splitContainer2.Panel1.Controls.Add(x);
