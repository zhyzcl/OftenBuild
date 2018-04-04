namespace OftenBuild
{
    partial class FrmCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCode));
            this.bt01a = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB02 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cB01 = new System.Windows.Forms.CheckBox();
            this.bt01b = new System.Windows.Forms.Button();
            this.bt02a = new System.Windows.Forms.Button();
            this.bt02b = new System.Windows.Forms.Button();
            this.bt03a = new System.Windows.Forms.Button();
            this.bt03b = new System.Windows.Forms.Button();
            this.bt04a = new System.Windows.Forms.Button();
            this.bt04b = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt04d = new System.Windows.Forms.Button();
            this.bt04c = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bt10a = new System.Windows.Forms.Button();
            this.bt10b = new System.Windows.Forms.Button();
            this.bt06 = new System.Windows.Forms.Button();
            this.bt07 = new System.Windows.Forms.Button();
            this.bt08 = new System.Windows.Forms.Button();
            this.bt05b = new System.Windows.Forms.Button();
            this.bt05a = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt09 = new System.Windows.Forms.Button();
            this.bt11 = new System.Windows.Forms.Button();
            this.bt10 = new System.Windows.Forms.Button();
            this.bt13 = new System.Windows.Forms.Button();
            this.bt12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rBa = new System.Windows.Forms.RichTextBox();
            this.rMenu = new OftenBuild.RightMenu();
            this.rBb = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt01a
            // 
            this.bt01a.Location = new System.Drawing.Point(4, 4);
            this.bt01a.Name = "bt01a";
            this.bt01a.Size = new System.Drawing.Size(197, 30);
            this.bt01a.TabIndex = 11;
            this.bt01a.Text = "ASCII -> escape";
            this.bt01a.UseVisualStyleBackColor = true;
            this.bt01a.Click += new System.EventHandler(this.bt01a_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB02);
            this.groupBox1.Controls.Add(this.rBb);
            this.groupBox1.Location = new System.Drawing.Point(8, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 197);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出";
            // 
            // cB02
            // 
            this.cB02.AutoSize = true;
            this.cB02.Checked = true;
            this.cB02.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB02.Location = new System.Drawing.Point(12, 20);
            this.cB02.Name = "cB02";
            this.cB02.Size = new System.Drawing.Size(96, 16);
            this.cB02.TabIndex = 16;
            this.cB02.Text = "删除左右空白";
            this.cB02.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cB01);
            this.groupBox2.Controls.Add(this.rBa);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 197);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入";
            // 
            // cB01
            // 
            this.cB01.AutoSize = true;
            this.cB01.Checked = true;
            this.cB01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB01.Location = new System.Drawing.Point(9, 175);
            this.cB01.Name = "cB01";
            this.cB01.Size = new System.Drawing.Size(96, 16);
            this.cB01.TabIndex = 15;
            this.cB01.Text = "删除左右空白";
            this.cB01.UseVisualStyleBackColor = true;
            // 
            // bt01b
            // 
            this.bt01b.Location = new System.Drawing.Point(203, 4);
            this.bt01b.Name = "bt01b";
            this.bt01b.Size = new System.Drawing.Size(197, 30);
            this.bt01b.TabIndex = 18;
            this.bt01b.Text = "escape -> ASCII";
            this.bt01b.UseVisualStyleBackColor = true;
            this.bt01b.Click += new System.EventHandler(this.bt01b_Click);
            // 
            // bt02a
            // 
            this.bt02a.Location = new System.Drawing.Point(4, 4);
            this.bt02a.Name = "bt02a";
            this.bt02a.Size = new System.Drawing.Size(197, 30);
            this.bt02a.TabIndex = 19;
            this.bt02a.Text = "ASCII -> encodeURIComponent";
            this.bt02a.UseVisualStyleBackColor = true;
            this.bt02a.Click += new System.EventHandler(this.bt02a_Click);
            // 
            // bt02b
            // 
            this.bt02b.Location = new System.Drawing.Point(203, 4);
            this.bt02b.Name = "bt02b";
            this.bt02b.Size = new System.Drawing.Size(197, 30);
            this.bt02b.TabIndex = 20;
            this.bt02b.Text = "encodeURIComponent -> ASCII";
            this.bt02b.UseVisualStyleBackColor = true;
            this.bt02b.Click += new System.EventHandler(this.bt02b_Click);
            // 
            // bt03a
            // 
            this.bt03a.Location = new System.Drawing.Point(4, 4);
            this.bt03a.Name = "bt03a";
            this.bt03a.Size = new System.Drawing.Size(197, 30);
            this.bt03a.TabIndex = 21;
            this.bt03a.Text = "ASCII -> 16进制Unicode";
            this.bt03a.UseVisualStyleBackColor = true;
            this.bt03a.Click += new System.EventHandler(this.bt03a_Click);
            // 
            // bt03b
            // 
            this.bt03b.Location = new System.Drawing.Point(204, 4);
            this.bt03b.Name = "bt03b";
            this.bt03b.Size = new System.Drawing.Size(197, 30);
            this.bt03b.TabIndex = 22;
            this.bt03b.Text = "16进制Unicode -> ASCII";
            this.bt03b.UseVisualStyleBackColor = true;
            this.bt03b.Click += new System.EventHandler(this.bt03b_Click);
            // 
            // bt04a
            // 
            this.bt04a.Location = new System.Drawing.Point(5, 5);
            this.bt04a.Name = "bt04a";
            this.bt04a.Size = new System.Drawing.Size(197, 30);
            this.bt04a.TabIndex = 23;
            this.bt04a.Text = "Html编码(HtmlEncode)";
            this.bt04a.UseVisualStyleBackColor = true;
            this.bt04a.Click += new System.EventHandler(this.bt04a_Click);
            // 
            // bt04b
            // 
            this.bt04b.Location = new System.Drawing.Point(205, 5);
            this.bt04b.Name = "bt04b";
            this.bt04b.Size = new System.Drawing.Size(197, 30);
            this.bt04b.TabIndex = 24;
            this.bt04b.Text = "Html解码(HtmlDecode)";
            this.bt04b.UseVisualStyleBackColor = true;
            this.bt04b.Click += new System.EventHandler(this.bt04b_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bt01a);
            this.panel1.Controls.Add(this.bt01b);
            this.panel1.Location = new System.Drawing.Point(8, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 40);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bt02a);
            this.panel2.Controls.Add(this.bt02b);
            this.panel2.Location = new System.Drawing.Point(420, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 40);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bt03b);
            this.panel3.Controls.Add(this.bt03a);
            this.panel3.Location = new System.Drawing.Point(8, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 40);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.bt04d);
            this.panel4.Controls.Add(this.bt04c);
            this.panel4.Controls.Add(this.bt04a);
            this.panel4.Controls.Add(this.bt04b);
            this.panel4.Location = new System.Drawing.Point(420, 254);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 86);
            this.panel4.TabIndex = 28;
            // 
            // bt04d
            // 
            this.bt04d.Location = new System.Drawing.Point(205, 51);
            this.bt04d.Name = "bt04d";
            this.bt04d.Size = new System.Drawing.Size(197, 30);
            this.bt04d.TabIndex = 24;
            this.bt04d.Text = "255字符集外Html编码";
            this.bt04d.UseVisualStyleBackColor = true;
            this.bt04d.Click += new System.EventHandler(this.bt04d_Click);
            // 
            // bt04c
            // 
            this.bt04c.Location = new System.Drawing.Point(5, 51);
            this.bt04c.Name = "bt04c";
            this.bt04c.Size = new System.Drawing.Size(197, 30);
            this.bt04c.TabIndex = 23;
            this.bt04c.Text = "字符串完全Html编码";
            this.bt04c.UseVisualStyleBackColor = true;
            this.bt04c.Click += new System.EventHandler(this.bt04c_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.bt10a);
            this.panel5.Controls.Add(this.bt10b);
            this.panel5.Location = new System.Drawing.Point(8, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(406, 40);
            this.panel5.TabIndex = 29;
            // 
            // bt10a
            // 
            this.bt10a.Location = new System.Drawing.Point(5, 5);
            this.bt10a.Name = "bt10a";
            this.bt10a.Size = new System.Drawing.Size(197, 30);
            this.bt10a.TabIndex = 23;
            this.bt10a.Text = "Url编码(UrlEncode)";
            this.bt10a.UseVisualStyleBackColor = true;
            this.bt10a.Click += new System.EventHandler(this.bt10a_Click);
            // 
            // bt10b
            // 
            this.bt10b.Location = new System.Drawing.Point(205, 5);
            this.bt10b.Name = "bt10b";
            this.bt10b.Size = new System.Drawing.Size(197, 30);
            this.bt10b.TabIndex = 24;
            this.bt10b.Text = "Url解码(UrlDecode)";
            this.bt10b.UseVisualStyleBackColor = true;
            this.bt10b.Click += new System.EventHandler(this.bt10b_Click);
            // 
            // bt06
            // 
            this.bt06.Location = new System.Drawing.Point(8, 393);
            this.bt06.Name = "bt06";
            this.bt06.Size = new System.Drawing.Size(197, 30);
            this.bt06.TabIndex = 30;
            this.bt06.Text = "字符串 -> 全角";
            this.bt06.UseVisualStyleBackColor = true;
            this.bt06.Click += new System.EventHandler(this.bt06_Click);
            // 
            // bt07
            // 
            this.bt07.Location = new System.Drawing.Point(215, 393);
            this.bt07.Name = "bt07";
            this.bt07.Size = new System.Drawing.Size(197, 30);
            this.bt07.TabIndex = 31;
            this.bt07.Text = "字符串 -> 半角";
            this.bt07.UseVisualStyleBackColor = true;
            this.bt07.Click += new System.EventHandler(this.bt07_Click);
            // 
            // bt08
            // 
            this.bt08.Location = new System.Drawing.Point(422, 393);
            this.bt08.Name = "bt08";
            this.bt08.Size = new System.Drawing.Size(197, 30);
            this.bt08.TabIndex = 32;
            this.bt08.Text = "全角数字 -> 半角数字";
            this.bt08.UseVisualStyleBackColor = true;
            this.bt08.Click += new System.EventHandler(this.bt08_Click);
            // 
            // bt05b
            // 
            this.bt05b.Location = new System.Drawing.Point(206, 5);
            this.bt05b.Name = "bt05b";
            this.bt05b.Size = new System.Drawing.Size(197, 30);
            this.bt05b.TabIndex = 33;
            this.bt05b.Text = "十进制整数 -> ip地址";
            this.bt05b.UseVisualStyleBackColor = true;
            this.bt05b.Click += new System.EventHandler(this.bt05b_Click);
            // 
            // bt05a
            // 
            this.bt05a.Location = new System.Drawing.Point(4, 6);
            this.bt05a.Name = "bt05a";
            this.bt05a.Size = new System.Drawing.Size(197, 30);
            this.bt05a.TabIndex = 34;
            this.bt05a.Text = "ip地址 -> 十进制整数";
            this.bt05a.UseVisualStyleBackColor = true;
            this.bt05a.Click += new System.EventHandler(this.bt05a_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.bt05a);
            this.panel6.Controls.Add(this.bt05b);
            this.panel6.Location = new System.Drawing.Point(8, 346);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(406, 40);
            this.panel6.TabIndex = 35;
            // 
            // bt09
            // 
            this.bt09.Location = new System.Drawing.Point(629, 393);
            this.bt09.Name = "bt09";
            this.bt09.Size = new System.Drawing.Size(197, 30);
            this.bt09.TabIndex = 36;
            this.bt09.Text = "Html -> 纯文本";
            this.bt09.UseVisualStyleBackColor = true;
            this.bt09.Click += new System.EventHandler(this.bt09_Click);
            // 
            // bt11
            // 
            this.bt11.Location = new System.Drawing.Point(215, 429);
            this.bt11.Name = "bt11";
            this.bt11.Size = new System.Drawing.Size(197, 30);
            this.bt11.TabIndex = 38;
            this.bt11.Text = "字符串 -> 小写";
            this.bt11.UseVisualStyleBackColor = true;
            this.bt11.Click += new System.EventHandler(this.bt11_Click);
            // 
            // bt10
            // 
            this.bt10.Location = new System.Drawing.Point(8, 429);
            this.bt10.Name = "bt10";
            this.bt10.Size = new System.Drawing.Size(197, 30);
            this.bt10.TabIndex = 37;
            this.bt10.Text = "字符串 -> 大写";
            this.bt10.UseVisualStyleBackColor = true;
            this.bt10.Click += new System.EventHandler(this.bt10_Click);
            // 
            // bt13
            // 
            this.bt13.Location = new System.Drawing.Point(629, 429);
            this.bt13.Name = "bt13";
            this.bt13.Size = new System.Drawing.Size(197, 30);
            this.bt13.TabIndex = 40;
            this.bt13.Text = "字符串 -> 繁体中文";
            this.bt13.UseVisualStyleBackColor = true;
            this.bt13.Click += new System.EventHandler(this.bt13_Click);
            // 
            // bt12
            // 
            this.bt12.Location = new System.Drawing.Point(422, 429);
            this.bt12.Name = "bt12";
            this.bt12.Size = new System.Drawing.Size(197, 30);
            this.bt12.TabIndex = 39;
            this.bt12.Text = "字符串 -> 简体中文";
            this.bt12.UseVisualStyleBackColor = true;
            this.bt12.Click += new System.EventHandler(this.bt12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 41;
            this.button1.Text = "银行卡号效验";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rBa
            // 
            this.rBa.ContextMenuStrip = this.rMenu;
            this.rBa.Location = new System.Drawing.Point(8, 20);
            this.rBa.Name = "rBa";
            this.rBa.Size = new System.Drawing.Size(804, 149);
            this.rBa.TabIndex = 14;
            this.rBa.Text = "";
            // 
            // rMenu
            // 
            this.rMenu.Name = "RightMenu";
            this.rMenu.Size = new System.Drawing.Size(137, 158);
            // 
            // rBb
            // 
            this.rBb.ContextMenuStrip = this.rMenu;
            this.rBb.Location = new System.Drawing.Point(9, 41);
            this.rBb.Name = "rBb";
            this.rBb.Size = new System.Drawing.Size(804, 149);
            this.rBb.TabIndex = 14;
            this.rBb.Text = "";
            // 
            // FrmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt13);
            this.Controls.Add(this.bt12);
            this.Controls.Add(this.bt11);
            this.Controls.Add(this.bt10);
            this.Controls.Add(this.bt09);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.bt08);
            this.Controls.Add(this.bt07);
            this.Controls.Add(this.bt06);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(849, 706);
            this.MinimumSize = new System.Drawing.Size(849, 706);
            this.Name = "FrmCode";
            this.Text = "字符串编码解码";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rBb;
        private System.Windows.Forms.Button bt01a;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rBa;
        private RightMenu rMenu;
        private System.Windows.Forms.Button bt01b;
        private System.Windows.Forms.Button bt02a;
        private System.Windows.Forms.Button bt02b;
        private System.Windows.Forms.Button bt03a;
        private System.Windows.Forms.Button bt03b;
        private System.Windows.Forms.Button bt04a;
        private System.Windows.Forms.Button bt04b;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt10a;
        private System.Windows.Forms.Button bt10b;
        private System.Windows.Forms.Button bt04d;
        private System.Windows.Forms.Button bt04c;
        private System.Windows.Forms.Button bt06;
        private System.Windows.Forms.Button bt07;
        private System.Windows.Forms.Button bt08;
        private System.Windows.Forms.Button bt05b;
        private System.Windows.Forms.Button bt05a;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bt09;
        private System.Windows.Forms.CheckBox cB01;
        private System.Windows.Forms.CheckBox cB02;
        private System.Windows.Forms.Button bt11;
        private System.Windows.Forms.Button bt10;
        private System.Windows.Forms.Button bt13;
        private System.Windows.Forms.Button bt12;
        private System.Windows.Forms.Button button1;
    }
}