
namespace MY_HW0412
{
    partial class My_HW01標準練習
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
            this.btnLotto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtkeyin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHundred = new System.Windows.Forms.Button();
            this.btnHaveC = new System.Windows.Forms.Button();
            this.btnLongName = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnCountOddEven = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnMaxParams = new System.Windows.Forms.Button();
            this.btn3Max = new System.Windows.Forms.Button();
            this.btnOddorEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLotto
            // 
            this.btnLotto.Location = new System.Drawing.Point(826, 163);
            this.btnLotto.Name = "btnLotto";
            this.btnLotto.Size = new System.Drawing.Size(196, 38);
            this.btnLotto.TabIndex = 153;
            this.btnLotto.Text = "int[] 樂透 6個號碼不重複";
            this.btnLotto.UseVisualStyleBackColor = true;
            this.btnLotto.Click += new System.EventHandler(this.btnLotto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(233, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 33);
            this.label7.TabIndex = 152;
            this.label7.Text = "Result:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(224, 298);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 34);
            this.btnClear.TabIndex = 151;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtkeyin
            // 
            this.txtkeyin.Location = new System.Drawing.Point(103, 57);
            this.txtkeyin.Margin = new System.Windows.Forms.Padding(4);
            this.txtkeyin.Name = "txtkeyin";
            this.txtkeyin.Size = new System.Drawing.Size(100, 25);
            this.txtkeyin.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 149;
            this.label6.Text = "Number:";
            // 
            // btnHundred
            // 
            this.btnHundred.Location = new System.Drawing.Point(46, 285);
            this.btnHundred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHundred.Name = "btnHundred";
            this.btnHundred.Size = new System.Drawing.Size(156, 28);
            this.btnHundred.TabIndex = 148;
            this.btnHundred.Text = "100 的 二進位是多少 ?";
            this.btnHundred.UseVisualStyleBackColor = true;
            this.btnHundred.Click += new System.EventHandler(this.btnHundred_Click);
            // 
            // btnHaveC
            // 
            this.btnHaveC.Location = new System.Drawing.Point(507, 157);
            this.btnHaveC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHaveC.Name = "btnHaveC";
            this.btnHaveC.Size = new System.Drawing.Size(279, 49);
            this.btnHaveC.TabIndex = 147;
            this.btnHaveC.Text = "string[] 名字有 “C” or “c” 字樣有幾個 ";
            this.btnHaveC.UseVisualStyleBackColor = true;
            this.btnHaveC.Click += new System.EventHandler(this.btnHaveC_Click);
            // 
            // btnLongName
            // 
            this.btnLongName.Location = new System.Drawing.Point(507, 111);
            this.btnLongName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLongName.Name = "btnLongName";
            this.btnLongName.Size = new System.Drawing.Size(279, 35);
            this.btnLongName.TabIndex = 146;
            this.btnLongName.Text = "string[] 最長名字 ?";
            this.btnLongName.UseVisualStyleBackColor = true;
            this.btnLongName.Click += new System.EventHandler(this.btnLongName_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(350, 234);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(97, 42);
            this.lblResult.TabIndex = 145;
            this.lblResult.Text = "結果";
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(46, 238);
            this.btnNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(156, 28);
            this.btnNine.TabIndex = 144;
            this.btnNine.Text = "九九乘法表";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDo.Location = new System.Drawing.Point(414, 160);
            this.btnDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(75, 22);
            this.btnDo.TabIndex = 143;
            this.btnDo.Text = "do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWhile.Location = new System.Drawing.Point(414, 113);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 22);
            this.btnWhile.TabIndex = 142;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFor.Location = new System.Drawing.Point(414, 65);
            this.btnFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 22);
            this.btnFor.TabIndex = 141;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(220, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 140;
            this.label3.Text = "Step:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(235, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 139;
            this.label2.Text = "to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(224, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 138;
            this.label1.Text = "from:";
            // 
            // txtStep
            // 
            this.txtStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStep.Location = new System.Drawing.Point(279, 153);
            this.txtStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(100, 25);
            this.txtStep.TabIndex = 137;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTo.Location = new System.Drawing.Point(279, 106);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 25);
            this.txtTo.TabIndex = 136;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFrom.Location = new System.Drawing.Point(279, 65);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 25);
            this.txtFrom.TabIndex = 135;
            // 
            // btnCountOddEven
            // 
            this.btnCountOddEven.Location = new System.Drawing.Point(507, 52);
            this.btnCountOddEven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCountOddEven.Name = "btnCountOddEven";
            this.btnCountOddEven.Size = new System.Drawing.Size(279, 35);
            this.btnCountOddEven.TabIndex = 134;
            this.btnCountOddEven.Text = "int[] 統計 奇數 有幾個 , 偶數有幾個";
            this.btnCountOddEven.UseVisualStyleBackColor = true;
            this.btnCountOddEven.Click += new System.EventHandler(this.btnCountOddEven_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(826, 111);
            this.btnMaxMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(196, 35);
            this.btnMaxMin.TabIndex = 133;
            this.btnMaxMin.Text = " MAX()   / Min ( int[] )";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnMaxParams
            // 
            this.btnMaxParams.Location = new System.Drawing.Point(826, 51);
            this.btnMaxParams.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxParams.Name = "btnMaxParams";
            this.btnMaxParams.Size = new System.Drawing.Size(196, 35);
            this.btnMaxParams.TabIndex = 132;
            this.btnMaxParams.Text = "Max (params int[] )";
            this.btnMaxParams.UseVisualStyleBackColor = true;
            this.btnMaxParams.Click += new System.EventHandler(this.btnMaxParams_Click);
            // 
            // btn3Max
            // 
            this.btn3Max.Location = new System.Drawing.Point(50, 148);
            this.btn3Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3Max.Name = "btn3Max";
            this.btn3Max.Size = new System.Drawing.Size(155, 28);
            this.btn3Max.TabIndex = 131;
            this.btn3Max.Text = "3 個數的最大值";
            this.btn3Max.UseVisualStyleBackColor = true;
            this.btn3Max.Click += new System.EventHandler(this.btn3Max_Click);
            // 
            // btnOddorEven
            // 
            this.btnOddorEven.Location = new System.Drawing.Point(50, 104);
            this.btnOddorEven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOddorEven.Name = "btnOddorEven";
            this.btnOddorEven.Size = new System.Drawing.Size(155, 26);
            this.btnOddorEven.TabIndex = 130;
            this.btnOddorEven.Text = "Odd or Even";
            this.btnOddorEven.UseVisualStyleBackColor = true;
            this.btnOddorEven.Click += new System.EventHandler(this.btnOddorEven_Click);
            // 
            // My_HW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 552);
            this.Controls.Add(this.btnLotto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtkeyin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHundred);
            this.Controls.Add(this.btnHaveC);
            this.Controls.Add(this.btnLongName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.btnCountOddEven);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnMaxParams);
            this.Controls.Add(this.btn3Max);
            this.Controls.Add(this.btnOddorEven);
            this.Name = "My_HW";
            this.Text = "My_HW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLotto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtkeyin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHundred;
        private System.Windows.Forms.Button btnHaveC;
        private System.Windows.Forms.Button btnLongName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnCountOddEven;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnMaxParams;
        private System.Windows.Forms.Button btn3Max;
        private System.Windows.Forms.Button btnOddorEven;
    }
}