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
    public partial class FrmBankBuild : Form
    {
        public DataTable BankTable = new DataTable();

        public List<int> slist = new List<int>();

        public FrmBankBuild()
        {
            InitializeComponent();
            BankTable = GetBankBinTable();
            for (int i = 0; i < AppPub.BankCard.BankBin.Length; i++)
            {
                DataRow dr = BankTable.NewRow();
                dr["bankbin"] = AppPub.BankCard.BankBin[i];
                dr["bankname"] = AppPub.BankCard.BankName[i];
                BankTable.Rows.Add(dr);
            }
            cBnum.Items.Add(16);
            cBnum.Items.Add(17);
            cBnum.Items.Add(18);
            cBnum.Items.Add(19);
            cBnum.SelectedIndex = 3;
        }

        public static DataTable GetBankBinTable()
        {
            Table t = new Table("BankBin");
            t.Add("bbid", "autolong", 1);
            t.Add("bankbin", "long", 0);//银行bin号
            t.Add("bankname", "string", 0);//银行名称       
            return DataTables.GetDataTable(t);
        }

        private void btbuild_Click(object sender, EventArgs e)
        {
            Build();
        }

        public void Build()
        {
            BandSearch();
            string s = tBbanks.Text.Trim();
            if (s != "" && slist.Count <= 0)
            {
                WinOften.MessShow("未筛选到银行信息！", 1);
                return;
            }
            if (!Often.IsInt32(tBnum.Text))
            {
                WinOften.MessShow("生成数量必须是整数！", 1);
                return;
            }
            int FareCount = Convert.ToInt32(tBnum.Text);
            if (FareCount <= 0)
            {
                WinOften.MessShow("生成数量必须大于0！", 1);
                return;
            }
            int ws = Convert.ToInt32(cBnum.SelectedItem);
            StringBuilder adsb = new StringBuilder();
            string bankcard = "";
            string fareType = "";
            string fname = "";
            string idcardType = "";
            string idcard = "";
            string birthday = "";
            string gender = "";
            int age = 0;
            string phone = "";
            string spellName = "";
            for (int i = 0; i < FareCount; i++)
            {
                if (slist.Count > 0)
                {
                    int index = slist[AppPub.pub.ran.Next(0, slist.Count)] -1;
                    string fnum = AppPub.BankCard.BankBin[index].ToString();
                    bankcard = AppPub.BankCard.CreditRandomBankCard(fnum, ws);
                }
                else
                {
                    bankcard = AppPub.BankCard.CreditRandomBankCard(ws);
                }     
                fareType = "AD";
                AppPub.RandomName.RandomBuildFareInfo(fareType, ref fname, ref idcardType, ref idcard, ref birthday, ref gender, ref age, ref phone, ref spellName);
                adsb.Append("  ");
                adsb.Append(fname);
                adsb.Append("  ");
                adsb.Append(bankcard);
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
            rB.Text = adsb.ToString();
        }

        private void btbanks_Click(object sender, EventArgs e)
        {
            BandSearch();
        }

        public void BandSearch()
        {
            List<string> blist = new List<string>();
            slist.Clear();
            StringBuilder sb = new StringBuilder();
            string s = tBbanks.Text.Trim();
            if (s != "")
            {
                DataRow[] dr = BankTable.Select("bankname like '%" + s + "%'");
                for (int i = 0; i < dr.Length; i++)
                {
                    int bbid = Convert.ToInt32(dr[i]["bbid"]);
                    string bankbin = dr[i]["bankbin"].ToString().Trim();
                    string bankname = dr[i]["bankname"].ToString().Trim();
                    slist.Add(bbid);
                    if (blist.IndexOf(bankname) == -1)
                    {
                        blist.Add(bankname);
                        sb.Append(bankbin + "  " + bankname + "\n");
                    }
                }
            }
            else
            {
                for (int i = 0; i < AppPub.BankCard.BankName.Length; i++)
                {
                    string bankbin = AppPub.BankCard.BankBin[i].ToString().Trim();
                    string bankname = AppPub.BankCard.BankName[i].ToString().Trim();
                    if (blist.IndexOf(bankname) == -1)
                    {
                        sb.Append(bankbin + "  " + bankname + "\n");
                    }
                }
            }
            rTBlist.Text = sb.ToString();
        }
    }
}
