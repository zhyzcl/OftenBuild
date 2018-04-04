namespace OftenBuild
{
    partial class FrmFareBuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFareBuild));
            this.label1 = new System.Windows.Forms.Label();
            this.cBad = new System.Windows.Forms.CheckBox();
            this.cBch = new System.Windows.Forms.CheckBox();
            this.cBin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbuild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBnum = new System.Windows.Forms.TextBox();
            this.rB = new System.Windows.Forms.RichTextBox();
            this.rMenu = new OftenBuild.RightMenu();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旅客类型：";
            // 
            // cBad
            // 
            this.cBad.AutoSize = true;
            this.cBad.Checked = true;
            this.cBad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBad.Location = new System.Drawing.Point(23, 8);
            this.cBad.Name = "cBad";
            this.cBad.Size = new System.Drawing.Size(48, 16);
            this.cBad.TabIndex = 1;
            this.cBad.Text = "成人";
            this.cBad.UseVisualStyleBackColor = true;
            // 
            // cBch
            // 
            this.cBch.AutoSize = true;
            this.cBch.Location = new System.Drawing.Point(105, 8);
            this.cBch.Name = "cBch";
            this.cBch.Size = new System.Drawing.Size(48, 16);
            this.cBch.TabIndex = 2;
            this.cBch.Text = "儿童";
            this.cBch.UseVisualStyleBackColor = true;
            // 
            // cBin
            // 
            this.cBin.AutoSize = true;
            this.cBin.Location = new System.Drawing.Point(187, 8);
            this.cBin.Name = "cBin";
            this.cBin.Size = new System.Drawing.Size(48, 16);
            this.cBin.TabIndex = 3;
            this.cBin.Text = "婴儿";
            this.cBin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cBad);
            this.panel1.Controls.Add(this.cBin);
            this.panel1.Controls.Add(this.cBch);
            this.panel1.Location = new System.Drawing.Point(124, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 35);
            this.panel1.TabIndex = 4;
            // 
            // btbuild
            // 
            this.btbuild.Location = new System.Drawing.Point(124, 123);
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
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "生成数量：";
            // 
            // tBnum
            // 
            this.tBnum.Location = new System.Drawing.Point(124, 81);
            this.tBnum.MaxLength = 8;
            this.tBnum.Name = "tBnum";
            this.tBnum.Size = new System.Drawing.Size(103, 21);
            this.tBnum.TabIndex = 7;
            this.tBnum.Text = "100";
            // 
            // rB
            // 
            this.rB.ContextMenuStrip = this.rMenu;
            this.rB.Location = new System.Drawing.Point(12, 173);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(597, 247);
            this.rB.TabIndex = 8;
            this.rB.Text = "";
            // 
            // rMenu
            // 
            this.rMenu.Name = "RightMenu";
            this.rMenu.Size = new System.Drawing.Size(137, 158);
            // 
            // FrmFareBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 436);
            this.Controls.Add(this.rB);
            this.Controls.Add(this.tBnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbuild);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(637, 474);
            this.MinimumSize = new System.Drawing.Size(637, 474);
            this.Name = "FrmFareBuild";
            this.Text = "国内旅客生成器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBad;
        private System.Windows.Forms.CheckBox cBch;
        private System.Windows.Forms.CheckBox cBin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btbuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBnum;
        private System.Windows.Forms.RichTextBox rB;
        private RightMenu rMenu;
    }
}