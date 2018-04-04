namespace OftenBuild
{
    partial class FrmBankBuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankBuild));
            this.label1 = new System.Windows.Forms.Label();
            this.btbuild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBbanks = new System.Windows.Forms.TextBox();
            this.btbanks = new System.Windows.Forms.Button();
            this.cBnum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rTBlist = new System.Windows.Forms.RichTextBox();
            this.rMenu = new OftenBuild.RightMenu();
            this.rB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "银行筛选：";
            // 
            // btbuild
            // 
            this.btbuild.Location = new System.Drawing.Point(124, 216);
            this.btbuild.Name = "btbuild";
            this.btbuild.Size = new System.Drawing.Size(100, 30);
            this.btbuild.TabIndex = 5;
            this.btbuild.Text = "立即生成";
            this.btbuild.UseVisualStyleBackColor = true;
            this.btbuild.Click += new System.EventHandler(this.btbuild_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "生成数量：";
            // 
            // tBnum
            // 
            this.tBnum.Location = new System.Drawing.Point(124, 176);
            this.tBnum.MaxLength = 8;
            this.tBnum.Name = "tBnum";
            this.tBnum.Size = new System.Drawing.Size(103, 21);
            this.tBnum.TabIndex = 7;
            this.tBnum.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "已筛选银行：";
            // 
            // tBbanks
            // 
            this.tBbanks.Location = new System.Drawing.Point(124, 25);
            this.tBbanks.MaxLength = 2000;
            this.tBbanks.Name = "tBbanks";
            this.tBbanks.Size = new System.Drawing.Size(389, 21);
            this.tBbanks.TabIndex = 8;
            // 
            // btbanks
            // 
            this.btbanks.Location = new System.Drawing.Point(526, 25);
            this.btbanks.Name = "btbanks";
            this.btbanks.Size = new System.Drawing.Size(73, 21);
            this.btbanks.TabIndex = 13;
            this.btbanks.Text = "立即筛选";
            this.btbanks.UseVisualStyleBackColor = true;
            this.btbanks.Click += new System.EventHandler(this.btbanks_Click);
            // 
            // cBnum
            // 
            this.cBnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBnum.FormattingEnabled = true;
            this.cBnum.Location = new System.Drawing.Point(354, 176);
            this.cBnum.Name = "cBnum";
            this.cBnum.Size = new System.Drawing.Size(121, 20);
            this.cBnum.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "卡号位数：";
            // 
            // rTBlist
            // 
            this.rTBlist.ContextMenuStrip = this.rMenu;
            this.rTBlist.Location = new System.Drawing.Point(124, 59);
            this.rTBlist.Name = "rTBlist";
            this.rTBlist.Size = new System.Drawing.Size(485, 104);
            this.rTBlist.TabIndex = 11;
            this.rTBlist.Text = "";
            // 
            // rMenu
            // 
            this.rMenu.Name = "RightMenu";
            this.rMenu.Size = new System.Drawing.Size(137, 158);
            // 
            // rB
            // 
            this.rB.ContextMenuStrip = this.rMenu;
            this.rB.Location = new System.Drawing.Point(12, 266);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(597, 232);
            this.rB.TabIndex = 8;
            this.rB.Text = "";
            // 
            // FrmBankBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBnum);
            this.Controls.Add(this.btbanks);
            this.Controls.Add(this.tBbanks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rTBlist);
            this.Controls.Add(this.rB);
            this.Controls.Add(this.tBnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbuild);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(637, 550);
            this.MinimumSize = new System.Drawing.Size(637, 550);
            this.Name = "FrmBankBuild";
            this.Text = "银行卡信息生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBnum;
        private System.Windows.Forms.RichTextBox rB;
        private RightMenu rMenu;
        private System.Windows.Forms.RichTextBox rTBlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBbanks;
        private System.Windows.Forms.Button btbanks;
        private System.Windows.Forms.ComboBox cBnum;
        private System.Windows.Forms.Label label4;
    }
}