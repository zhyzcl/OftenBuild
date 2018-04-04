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
    public partial class FrmRank : Form
    {
        public FrmRank()
        {
            InitializeComponent();
        }

        private void btbuild_Click(object sender, EventArgs e)
        {
            string s = rBa.Text;
            List<string> li = new List<string>();
            if (rBa1.Checked)
            {
                string[] arr = s.Split(',');
                li = new List<string>(arr);
            }
            else if (rBa2.Checked)
            {
                string[] arr = s.Split('\n');
                li = new List<string>(arr);
            }
            else if (rBa3.Checked)
            {
                string[] arr = s.Split('\r');
                li = new List<string>(arr);
            }
            else if (rBa4.Checked)
            {
                string[] arr = s.Split('\t');
                li = new List<string>(arr);
            }
            else if (rBa5.Checked)
            {
                string[] arr = s.Split('\v');
                li = new List<string>(arr);
            }
            else if (rBa6.Checked)
            {
                string[] arr = s.Split('\f');
                li = new List<string>(arr);
            }
            else if (rBa7.Checked)
            {
                string[] arr = Often.Split(s, rBta.Text);
                li = new List<string>(arr);
            }
            int js = 0;
            double zj = 0;
            bool isss = false;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < li.Count; i++)
            {
                string str = li[i].Trim();
                if (str != "")
                {
                    if (sb.Length > 0)
                    {
                        string fgf = "";
                        if (rBb1.Checked)
                        {
                            fgf = ",";
                        }
                        else if (rBb2.Checked)
                        {
                            fgf = "\n";
                        }
                        else if (rBb3.Checked)
                        {
                            fgf = "\r";
                        }
                        else if (rBb4.Checked)
                        {
                            fgf = "\t";
                        }
                        else if (rBb5.Checked)
                        {
                            fgf = "\v";
                        }
                        else if (rBb6.Checked)
                        {
                            fgf = "\f";
                        }
                        else if (rBb7.Checked)
                        {
                            fgf = rBtb.Text;
                        }
                        sb.Append(fgf);
                    }
                    if (rBb7.Checked && rBtb.Text.Trim() == "+" && Often.IsNum(str))
                    {
                        zj = zj + Convert.ToDouble(str);
                        isss = true;
                        js += 1;
                    }
                    else if (rBb7.Checked && rBtb.Text.Trim() == "-" && Often.IsNum(str))
                    {
                        zj = zj - Convert.ToDouble(str);
                        isss = true;
                        js += 1;
                    }
                    else if (rBb7.Checked && rBtb.Text.Trim() == "*" && Often.IsNum(str))
                    {
                        zj = zj * Convert.ToDouble(str);
                        isss = true;
                        js += 1;
                    }
                    else if (rBb7.Checked && rBtb.Text.Trim() == "/" && Often.IsNum(str))
                    {
                        zj = zj / Convert.ToDouble(str);
                        isss = true;
                        js += 1;
                    }
                    sb.Append(rBtb1.Text);
                    sb.Append(str);
                    sb.Append(rBtb2.Text);
                }
            }
            if (isss)
            {
                sb.Append("\n\n累计次数：" + js.ToString() + "，总计：" + zj.ToString());
            }
            rBb.Text = sb.ToString();
        }
    }
}
