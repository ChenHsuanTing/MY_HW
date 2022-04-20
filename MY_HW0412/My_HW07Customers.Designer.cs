
namespace MY_HW0412
{
    partial class My_HW07Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_HW07Customers));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(371, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country:";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ImageList2;
            this.listView1.Location = new System.Drawing.Point(-4, 160);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(861, 329);
            this.listView1.SmallImageList = this.ImageList1;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList2.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList2.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList2.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList2.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList2.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList2.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList2.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList2.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList2.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList2.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList2.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList2.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList2.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList2.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList2.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList2.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList2.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList2.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList1.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList1.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList1.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList1.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList1.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList1.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList1.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList1.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList1.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList1.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList1.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList1.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList1.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList1.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList1.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList1.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList1.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList1.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 76);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.largeIconToolStripMenuItem.Text = "LargeIcon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.smallIconToolStripMenuItem.Text = "SmallIcon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(213, 141);
            this.dataGridView1.TabIndex = 8;
            // 
            // My_HW07Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "My_HW07Customers";
            this.Text = "My_HW07Customers";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ImageList ImageList2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}