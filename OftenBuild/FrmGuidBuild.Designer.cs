namespace OftenBuild
{
    partial class FrmGuidBuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuidBuild));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtypee = new System.Windows.Forms.RadioButton();
            this.rBtyped = new System.Windows.Forms.RadioButton();
            this.rBtypec = new System.Windows.Forms.RadioButton();
            this.rBtypeb = new System.Windows.Forms.RadioButton();
            this.rBtypea = new System.Windows.Forms.RadioButton();
            this.btbuild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBnum = new System.Windows.Forms.TextBox();
            this.rB = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBcasec = new System.Windows.Forms.RadioButton();
            this.rBcaseb = new System.Windows.Forms.RadioButton();
            this.rBcasea = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rMenu = new OftenBuild.RightMenu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "生成类型：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rBtypee);
            this.panel1.Controls.Add(this.rBtyped);
            this.panel1.Controls.Add(this.rBtypec);
            this.panel1.Controls.Add(this.rBtypeb);
            this.panel1.Controls.Add(this.rBtypea);
            this.panel1.Location = new System.Drawing.Point(124, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 35);
            this.panel1.TabIndex = 4;
            // 
            // rBtypee
            // 
            this.rBtypee.AutoSize = true;
            this.rBtypee.Location = new System.Drawing.Point(307, 9);
            this.rBtypee.Name = "rBtypee";
            this.rBtypee.Size = new System.Drawing.Size(47, 16);
            this.rBtypee.TabIndex = 4;
            this.rBtypee.Text = "括号";
            this.rBtypee.UseVisualStyleBackColor = true;
            // 
            // rBtyped
            // 
            this.rBtyped.AutoSize = true;
            this.rBtyped.Location = new System.Drawing.Point(229, 9);
            this.rBtyped.Name = "rBtyped";
            this.rBtyped.Size = new System.Drawing.Size(59, 16);
            this.rBtyped.TabIndex = 3;
            this.rBtyped.Text = "大括号";
            this.rBtyped.UseVisualStyleBackColor = true;
            // 
            // rBtypec
            // 
            this.rBtypec.AutoSize = true;
            this.rBtypec.Location = new System.Drawing.Point(146, 9);
            this.rBtypec.Name = "rBtypec";
            this.rBtypec.Size = new System.Drawing.Size(59, 16);
            this.rBtypec.TabIndex = 2;
            this.rBtypec.Text = "分隔符";
            this.rBtypec.UseVisualStyleBackColor = true;
            // 
            // rBtypeb
            // 
            this.rBtypeb.AutoSize = true;
            this.rBtypeb.Location = new System.Drawing.Point(67, 9);
            this.rBtypeb.Name = "rBtypeb";
            this.rBtypeb.Size = new System.Drawing.Size(59, 16);
            this.rBtypeb.TabIndex = 1;
            this.rBtypeb.Text = "全数字";
            this.rBtypeb.UseVisualStyleBackColor = true;
            // 
            // rBtypea
            // 
            this.rBtypea.AutoSize = true;
            this.rBtypea.Checked = true;
            this.rBtypea.Location = new System.Drawing.Point(17, 9);
            this.rBtypea.Name = "rBtypea";
            this.rBtypea.Size = new System.Drawing.Size(35, 16);
            this.rBtypea.TabIndex = 0;
            this.rBtypea.TabStop = true;
            this.rBtypea.Text = "无";
            this.rBtypea.UseVisualStyleBackColor = true;
            // 
            // btbuild
            // 
            this.btbuild.Location = new System.Drawing.Point(124, 147);
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
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "生成数量：";
            // 
            // tBnum
            // 
            this.tBnum.Location = new System.Drawing.Point(124, 111);
            this.tBnum.MaxLength = 8;
            this.tBnum.Name = "tBnum";
            this.tBnum.Size = new System.Drawing.Size(103, 21);
            this.tBnum.TabIndex = 7;
            this.tBnum.Text = "100";
            // 
            // rB
            // 
            this.rB.ContextMenuStrip = this.rMenu;
            this.rB.Location = new System.Drawing.Point(12, 194);
            this.rB.Name = "rB";
            this.rB.Size = new System.Drawing.Size(597, 226);
            this.rB.TabIndex = 8;
            this.rB.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rBcasec);
            this.panel2.Controls.Add(this.rBcaseb);
            this.panel2.Controls.Add(this.rBcasea);
            this.panel2.Location = new System.Drawing.Point(124, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 35);
            this.panel2.TabIndex = 10;
            // 
            // rBcasec
            // 
            this.rBcasec.AutoSize = true;
            this.rBcasec.Location = new System.Drawing.Point(146, 8);
            this.rBcasec.Name = "rBcasec";
            this.rBcasec.Size = new System.Drawing.Size(47, 16);
            this.rBcasec.TabIndex = 3;
            this.rBcasec.Text = "小写";
            this.rBcasec.UseVisualStyleBackColor = true;
            // 
            // rBcaseb
            // 
            this.rBcaseb.AutoSize = true;
            this.rBcaseb.Location = new System.Drawing.Point(67, 8);
            this.rBcaseb.Name = "rBcaseb";
            this.rBcaseb.Size = new System.Drawing.Size(47, 16);
            this.rBcaseb.TabIndex = 2;
            this.rBcaseb.Text = "大写";
            this.rBcaseb.UseVisualStyleBackColor = true;
            // 
            // rBcasea
            // 
            this.rBcasea.AutoSize = true;
            this.rBcasea.Checked = true;
            this.rBcasea.Location = new System.Drawing.Point(17, 8);
            this.rBcasea.Name = "rBcasea";
            this.rBcasea.Size = new System.Drawing.Size(35, 16);
            this.rBcasea.TabIndex = 1;
            this.rBcasea.TabStop = true;
            this.rBcasea.Text = "无";
            this.rBcasea.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "大小写：";
            // 
            // rMenu
            // 
            this.rMenu.Name = "RightMenu";
            this.rMenu.Size = new System.Drawing.Size(137, 158);
            // 
            // FrmGuidBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rB);
            this.Controls.Add(this.tBnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbuild);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(637, 474);
            this.MinimumSize = new System.Drawing.Size(637, 474);
            this.Name = "FrmGuidBuild";
            this.Text = "Guid生成器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btbuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBnum;
        private System.Windows.Forms.RichTextBox rB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtypee;
        private System.Windows.Forms.RadioButton rBtyped;
        private System.Windows.Forms.RadioButton rBtypec;
        private System.Windows.Forms.RadioButton rBtypeb;
        private System.Windows.Forms.RadioButton rBtypea;
        private System.Windows.Forms.RadioButton rBcasec;
        private System.Windows.Forms.RadioButton rBcaseb;
        private System.Windows.Forms.RadioButton rBcasea;
        private RightMenu rMenu;
    }
}