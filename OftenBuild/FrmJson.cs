using System;
using System.IO;
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
    public partial class FrmJson : Form
    {
        public FrmJson()
        {
            InitializeComponent();
        }

        private void btbuild_Click(object sender, EventArgs e)
        {
            rBb.Text = "";
            string s = rBa.Text.Trim();
            if (s == "")
            {
                return;
            }
            string errs = "";
            if (cBrjson.Checked)
            {
                s = GetReplaceJson(s);
            }
            string jsons = FormatJsonString(s, ref errs);
            if (errs != "")
            {
                rBb.Text = errs;
            }
            else
            {
                try
                {
                    if (rBa2.Checked)
                    {
                        jsons = Often.Unescape(jsons);
                    }
                    else if (rBa3.Checked)
                    {
                        jsons = Often.UrlDes(jsons);
                    }
                    else if (rBa4.Checked)
                    {
                        jsons = Often.DecodeURI(jsons);
                    }
                }
                catch (Exception ex)
                {
                    rBb.Text = ex.Message;
                }
                rBb.Text = jsons;
            }
        }

        public static string GetReplaceJson(string str)
        {
            str = str.Replace("“", "\"");
            str = str.Replace("”", "\"");
            str = str.Replace("：", ":");
            str = str.Replace("'", "\"");
            str = str.Replace("‘", "\"");
            str = str.Replace("’", "\"");
            str = str.Replace("，", ",");
            return str;
        }

        /// <summary>返回格式化后json字符串</summary>
        /// <param name="str">json字符串</param>
        /// <returns>返回格式化后json字符串</returns>
        public static string FormatJsonString(string str, ref string errs)
        {
            try
            {
                Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
                TextReader tr = new StringReader(str);
                Newtonsoft.Json.JsonTextReader jtr = new Newtonsoft.Json.JsonTextReader(tr);
                object obj = serializer.Deserialize(jtr);
                if (obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    Newtonsoft.Json.JsonTextWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(textWriter)
                    {
                        Formatting = Newtonsoft.Json.Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    return textWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                errs = "格式化json失败，错误信息：" + ex.Message;
            }
            return str;
        }
    }
}
