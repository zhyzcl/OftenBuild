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
    public partial class FrmFareBuild : Form
    {
        public FrmFareBuild()
        {
            InitializeComponent();
        }

        private void btbuild_Click(object sender, EventArgs e)
        {
            BuildFare();
        }

        public void BuildFare()
        {
            string ADMan = "0";
            if(cBad.Checked)
            {
                ADMan = "1";
            }
            string CHMan = "0";
            if (cBch.Checked)
            {
                CHMan = "1";
            }
            string INMan = "0";
            if (cBin.Checked)
            {
                INMan = "1";
            }
            if (!cBad.Checked && !cBch.Checked && !cBin.Checked)
            {
                WinOften.MessShow("至少选择一个旅客类型！", 1);
                return;
            }
            if(!Often.IsInt32(tBnum.Text))
            {
                WinOften.MessShow("生成数量必须是整数！", 1);
                return;
            }
            int FareCount = Convert.ToInt32(tBnum.Text);
            if (FareCount<=0) 
            {
                WinOften.MessShow("生成数量必须大于0！", 1);
                return;
            }
            StringBuilder adsb = new StringBuilder();
            StringBuilder chsb = new StringBuilder();
            StringBuilder insb = new StringBuilder();
            string fareType = "";
            string fname = "";
            string idcardType = "";
            string idcard = "";
            string birthday = "";
            string gender = "";
            int age = 0;
            string phone = "";
            string spellName = "";
            if (ADMan == "1")
            {
                for (int i = 0; i < FareCount; i++)
                {
                    fareType = "AD";
                    AppPub.RandomName.RandomBuildFareInfo(fareType, ref fname, ref idcardType, ref idcard, ref birthday, ref gender, ref age, ref phone, ref spellName);
                    adsb.Append("  ");
                    adsb.Append(fname);
                    adsb.Append("  ");
                    adsb.Append(idcard);
                    adsb.Append("  ");
                    adsb.Append(birthday);
                    adsb.Append("  ");
                    adsb.Append(age.ToString());
                    adsb.Append("  ");
                    adsb.Append(gender);
                    adsb.Append("  ");
                    adsb.Append(phone);
                    adsb.Append("  ");
                    adsb.Append(spellName);
                    adsb.Append("\r\n");
                }
            }
            if (CHMan == "1")
            {
                for (int i = 0; i < FareCount; i++)
                {
                    fareType = "CH";
                    AppPub.RandomName.RandomBuildFareInfo(fareType, ref fname, ref idcardType, ref idcard, ref birthday, ref gender, ref age, ref phone, ref spellName);
                    chsb.Append("  ");
                    chsb.Append(fname);
                    chsb.Append("  ");
                    chsb.Append(idcard);
                    chsb.Append("  ");
                    chsb.Append(birthday);
                    chsb.Append("  ");
                    chsb.Append(age.ToString());
                    chsb.Append("  ");
                    chsb.Append(gender);
                    chsb.Append("  ");
                    chsb.Append(phone);
                    chsb.Append("  ");
                    chsb.Append(spellName);
                    chsb.Append("\r\n");
                }
            }
            if (INMan == "1")
            {
                for (int i = 0; i < FareCount; i++)
                {
                    fareType = "IN";
                    AppPub.RandomName.RandomBuildFareInfo(fareType, ref fname, ref idcardType, ref idcard, ref birthday, ref gender, ref age, ref phone, ref spellName);
                    insb.Append("  ");
                    insb.Append(fname);
                    insb.Append("  ");
                    insb.Append(idcard);
                    insb.Append("  ");
                    insb.Append(birthday);
                    insb.Append("  ");
                    insb.Append(age.ToString());
                    insb.Append("  ");
                    insb.Append(gender);
                    insb.Append("  ");
                    insb.Append(phone);
                    insb.Append("  ");
                    insb.Append(spellName);
                    insb.Append("\r\n");
                }
            }
            rB.Text = "成人旅客信息：\r\n" + adsb.ToString() + "\r\n\r\n" + "儿童旅客信息：\r\n" + chsb.ToString() + "\r\n\r\n" + "婴儿旅客信息：\r\n" + insb.ToString() + "\r\n\r\n";
        }
    }
}
