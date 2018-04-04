using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;
using App.Win;

namespace OftenBuild
{
    public partial class FrmGuidBuild : Form
    {
        public FrmGuidBuild()
        {
            InitializeComponent();
        }

        private void btbuild_Click(object sender, EventArgs e)
        {
            BuildGuid();
        }

        public void BuildGuid()
        {
            if(!Often.IsInt32(tBnum.Text))
            {
                WinOften.MessShow("生成数量必须是整数！", 1);
                return;
            }
            int bCount = Convert.ToInt32(tBnum.Text);
            if (bCount <= 0) 
            {
                WinOften.MessShow("生成数量必须大于0！", 1);
                return;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bCount; i++)
            {
                if (rBtypea.Checked) 
                {
                    sb.Append(System.Guid.NewGuid().ToString());
                }
                else if (rBtypeb.Checked)
                {
                    sb.Append(System.Guid.NewGuid().ToString("N"));
                }
                else if (rBtypec.Checked)
                {
                    sb.Append(System.Guid.NewGuid().ToString("D"));
                }
                else if (rBtyped.Checked)
                {
                    sb.Append(System.Guid.NewGuid().ToString("B"));
                }
                else if (rBtypee.Checked)
                {
                    sb.Append(System.Guid.NewGuid().ToString("P"));
                }
                sb.Append("\r\n");
            }
            if (rBcaseb.Checked)
            {
                sb = new StringBuilder(sb.ToString().ToUpper());
            }
            else if (rBcasec.Checked)
            {
                sb = new StringBuilder(sb.ToString().ToLower());
            }
            rB.Text = sb.ToString();
        }
    }
}
