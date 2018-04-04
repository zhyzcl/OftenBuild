namespace OftenBuild
{
    partial class FrmJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJson));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btbuild = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBa4 = new System.Windows.Forms.RadioButton();
            this.rBa3 = new System.Windows.Forms.RadioButton();
            this.rBa2 = new System.Windows.Forms.RadioButton();
            this.rBa1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cBrjson = new System.Windows.Forms.CheckBox();
            this.rBa = new System.Windows.Forms.RichTextBox();
            this.rMenu = new OftenBuild.RightMenu();
            this.rBb = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBb);
            this.groupBox1.Location = new System.Drawing.Point(11, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 434);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBrjson);
            this.groupBox2.Controls.Add(this.btbuild);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rBa);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(942, 266);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入";
            // 
            // btbuild
            // 
            this.btbuild.Location = new System.Drawing.Point(130, 226);
            this.btbuild.Name = "btbuild";
            this.btbuild.Size = new System.Drawing.Size(100, 30);
            this.btbuild.TabIndex = 17;
            this.btbuild.Text = "效验并格式化";
            this.btbuild.UseVisualStyleBackColor = true;
            this.btbuild.Click += new System.EventHandler(this.btbuild_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rBa4);
            this.panel2.Controls.Add(this.rBa3);
            this.panel2.Controls.Add(this.rBa2);
            this.panel2.Controls.Add(this.rBa1);
            this.panel2.Location = new System.Drawing.Point(130, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 35);
            this.panel2.TabIndex = 16;
            // 
            // rBa4
            // 
            this.rBa4.AutoSize = true;
            this.rBa4.Location = new System.Drawing.Point(343, 8);
            this.rBa4.Name = "rBa4";
            this.rBa4.Size = new System.Drawing.Size(161, 16);
            this.rBa4.TabIndex = 3;
            this.rBa4.Text = "encodeURIComponent 解码";
            this.rBa4.UseVisualStyleBackColor = true;
            // 
            // rBa3
            // 
            this.rBa3.AutoSize = true;
            this.rBa3.Location = new System.Drawing.Point(191, 8);
            this.rBa3.Name = "rBa3";
            this.rBa3.Size = new System.Drawing.Size(131, 16);
            this.rBa3.TabIndex = 2;
            this.rBa3.Text = "Url解码(UrlDecode)";
            this.rBa3.UseVisualStyleBackColor = true;
            // 
            // rBa2
            // 
            this.rBa2.AutoSize = true;
            this.rBa2.Checked = true;
            this.rBa2.Location = new System.Drawing.Point(89, 8);
            this.rBa2.Name = "rBa2";
            this.rBa2.Size = new System.Drawing.Size(83, 16);
            this.rBa2.TabIndex = 1;
            this.rBa2.TabStop = true;
            this.rBa2.Text = "escape解码";
            this.rBa2.UseVisualStyleBackColor = true;
            // 
            // rBa1
            // 
            this.rBa1.AutoSize = true;
            this.rBa1.Location = new System.Drawing.Point(13, 8);
            this.rBa1.Name = "rBa1";
            this.rBa1.Size = new System.Drawing.Size(59, 16);
            this.rBa1.TabIndex = 0;
            this.rBa1.Text = "不解码";
            this.rBa1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "解码类型：";
            // 
            // cBrjson
            // 
            this.cBrjson.AutoSize = true;
            this.cBrjson.Checked = true;
            this.cBrjson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBrjson.Location = new System.Drawing.Point(738, 192);
            this.cBrjson.Name = "cBrjson";
            this.cBrjson.Size = new System.Drawing.Size(156, 16);
            this.cBrjson.TabIndex = 18;
            this.cBrjson.Text = "中文字符转换为英文字符";
            this.cBrjson.UseVisualStyleBackColor = true;
            // 
            // rBa
            // 
            this.rBa.ContextMenuStrip = this.rMenu;
            this.rBa.Location = new System.Drawing.Point(7, 17);
            this.rBa.Name = "rBa";
            this.rBa.Size = new System.Drawing.Size(928, 158);
            this.rBa.TabIndex = 14;
            this.rBa.Text = "";
            // 
            // rMenu
            // 
            this.rMenu.Name = "RightMenu";
            this.rMenu.Size = new System.Drawing.Size(153, 180);
            // 
            // rBb
            // 
            this.rBb.ContextMenuStrip = this.rMenu;
            this.rBb.Location = new System.Drawing.Point(9, 20);
            this.rBb.Name = "rBb";
            this.rBb.Size = new System.Drawing.Size(923, 408);
            this.rBb.TabIndex = 14;
            this.rBb.Text = "";
            // 
            // FrmJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 726);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(978, 765);
            this.MinimumSize = new System.Drawing.Size(978, 765);
            this.Name = "FrmJson";
            this.Text = "JSON格式效验";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rBb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rBa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBa4;
        private System.Windows.Forms.RadioButton rBa2;
        private System.Windows.Forms.RadioButton rBa1;
        private System.Windows.Forms.Label label3;
        private RightMenu rMenu;
        private System.Windows.Forms.RadioButton rBa3;
        private System.Windows.Forms.Button btbuild;
        private System.Windows.Forms.CheckBox cBrjson;
    }
}