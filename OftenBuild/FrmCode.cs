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
    public partial class FrmCode : Form
    {
        public FrmCode()
        {
            InitializeComponent();
        }

        public string GetInput() 
        {
            if (cB01.Checked) 
            {
                return rBa.Text.Trim();
            }
            return rBa.Text;
        }

        public void GetOut(string s)
        {
            if (cB02.Checked)
            {
                rBb.Text = s.Trim();
                return;
            }
            rBb.Text = s;
            return;
        }

        private void bt01a_Click(object sender, EventArgs e)
        {
            GetOut(Often.Escape(GetInput()));
        }

        private void bt01b_Click(object sender, EventArgs e)
        {
            GetOut(Often.Unescape(GetInput()));
        }

        private void bt02a_Click(object sender, EventArgs e)
        {
            GetOut(Often.EncodeURI(GetInput()));
        }

        private void bt02b_Click(object sender, EventArgs e)
        {
            GetOut(Often.DecodeURI(GetInput()));
        }

        private void bt03a_Click(object sender, EventArgs e)
        {
            GetOut(Often.EnUnicode(GetInput()));
        }

        private void bt03b_Click(object sender, EventArgs e)
        {
            GetOut(Often.DeUnicode(GetInput()));
        }

        private void bt04a_Click(object sender, EventArgs e)
        {
            GetOut(Often.HtmlEncode(GetInput()));
        }

        private void bt04b_Click(object sender, EventArgs e)
        {
            GetOut(Often.HtmlDecode(GetInput()));
        }

        private void bt04c_Click(object sender, EventArgs e)
        {
            GetOut(Often.GetHtml(GetInput()));
        }

        private void bt04d_Click(object sender, EventArgs e)
        {
            GetOut(Often.GetTxt(GetInput()));
        }

        private void bt05a_Click(object sender, EventArgs e)
        {
            try
            {
                GetOut(Often.IpToDec(GetInput()).ToString());
            }
            catch(Exception ex)
            {
                WinOften.MessShow("发生错误，错误信息：" + ex.Message, 1);
                return;
            }       
        }

        private void bt05b_Click(object sender, EventArgs e)
        {
            string s = GetInput();
            if (!Often.IsInt64(s)) 
            {
                WinOften.MessShow("输入的字符串必须是整数", 1);
                return;
            }
            GetOut(Often.DecToIp(Convert.ToInt64(GetInput())).ToString());
        }

        private void bt06_Click(object sender, EventArgs e)
        {
            GetOut(Often.StringToSBC(GetInput()));
        }

        private void bt07_Click(object sender, EventArgs e)
        {
            GetOut(Often.StringToDBC(GetInput()));
        }

        private void bt08_Click(object sender, EventArgs e)
        {
            GetOut(Often.GetNumNarrow(GetInput()));
        }

        private void bt09_Click(object sender, EventArgs e)
        {
            GetOut(Often.OutText(Often.OutTxt(GetInput())));
        }

        private void bt10a_Click(object sender, EventArgs e)
        {
            GetOut(Often.UrlEns(GetInput()));
        }

        private void bt10b_Click(object sender, EventArgs e)
        {
            GetOut(Often.UrlDes(GetInput()));
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            GetOut(GetInput().ToUpper());
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            GetOut(GetInput().ToLower());
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            GetOut(StrConvert(GetInput(), Microsoft.VisualBasic.VbStrConv.SimplifiedChinese));
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            GetOut(StrConvert(GetInput(), Microsoft.VisualBasic.VbStrConv.TraditionalChinese));
        }

        private static string StrConvert(string str, Microsoft.VisualBasic.VbStrConv conv)
        {
            return Microsoft.VisualBasic.Strings.StrConv(str, conv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder os = new StringBuilder();
            string err = "";
            string bcard = GetInput();
            bool isver = AppPub.BankCard.BankCardCheck(bcard, ref err);
            if (isver)
            {
                os.Append("效验成功！卡号所属银行：" + AppPub.BankCard.GetBankName(bcard));        
            }
            else
            {
                os.Append("效验失败！" + err);
            }
            GetOut(os.ToString());
        }
    }
}
