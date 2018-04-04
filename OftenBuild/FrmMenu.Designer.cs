namespace OftenBuild
{
    partial class FrmMenu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btfare = new System.Windows.Forms.Button();
            this.btrank = new System.Windows.Forms.Button();
            this.btguid = new System.Windows.Forms.Button();
            this.btcode = new System.Windows.Forms.Button();
            this.btbank = new System.Windows.Forms.Button();
            this.btjson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btfare
            // 
            this.btfare.Location = new System.Drawing.Point(54, 28);
            this.btfare.Name = "btfare";
            this.btfare.Size = new System.Drawing.Size(183, 44);
            this.btfare.TabIndex = 0;
            this.btfare.Text = "国内旅客生成器";
            this.btfare.UseVisualStyleBackColor = true;
            this.btfare.Click += new System.EventHandler(this.btfare_Click);
            // 
            // btrank
            // 
            this.btrank.Location = new System.Drawing.Point(319, 28);
            this.btrank.Name = "btrank";
            this.btrank.Size = new System.Drawing.Size(183, 44);
            this.btrank.TabIndex = 1;
            this.btrank.Text = "字段名排列器";
            this.btrank.UseVisualStyleBackColor = true;
            this.btrank.Click += new System.EventHandler(this.btrank_Click);
            // 
            // btguid
            // 
            this.btguid.Location = new System.Drawing.Point(54, 102);
            this.btguid.Name = "btguid";
            this.btguid.Size = new System.Drawing.Size(183, 44);
            this.btguid.TabIndex = 2;
            this.btguid.Text = "GUID生成器";
            this.btguid.UseVisualStyleBackColor = true;
            this.btguid.Click += new System.EventHandler(this.btguid_Click);
            // 
            // btcode
            // 
            this.btcode.Location = new System.Drawing.Point(319, 102);
            this.btcode.Name = "btcode";
            this.btcode.Size = new System.Drawing.Size(183, 44);
            this.btcode.TabIndex = 3;
            this.btcode.Text = "字符串编码解码";
            this.btcode.UseVisualStyleBackColor = true;
            this.btcode.Click += new System.EventHandler(this.btcode_Click);
            // 
            // btbank
            // 
            this.btbank.Location = new System.Drawing.Point(54, 177);
            this.btbank.Name = "btbank";
            this.btbank.Size = new System.Drawing.Size(183, 44);
            this.btbank.TabIndex = 4;
            this.btbank.Text = "银行卡信息生成器";
            this.btbank.UseVisualStyleBackColor = true;
            this.btbank.Click += new System.EventHandler(this.btbank_Click);
            // 
            // btjson
            // 
            this.btjson.Location = new System.Drawing.Point(319, 177);
            this.btjson.Name = "btjson";
            this.btjson.Size = new System.Drawing.Size(183, 44);
            this.btjson.TabIndex = 5;
            this.btjson.Text = "JSON格式效验";
            this.btjson.UseVisualStyleBackColor = true;
            this.btjson.Click += new System.EventHandler(this.btjson_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 254);
            this.Controls.Add(this.btjson);
            this.Controls.Add(this.btbank);
            this.Controls.Add(this.btcode);
            this.Controls.Add(this.btguid);
            this.Controls.Add(this.btrank);
            this.Controls.Add(this.btfare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(572, 293);
            this.MinimumSize = new System.Drawing.Size(572, 293);
            this.Name = "FrmMenu";
            this.Text = "常用操作分类菜单";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btfare;
        private System.Windows.Forms.Button btrank;
        private System.Windows.Forms.Button btguid;
        private System.Windows.Forms.Button btcode;
        private System.Windows.Forms.Button btbank;
        private System.Windows.Forms.Button btjson;
    }
}

