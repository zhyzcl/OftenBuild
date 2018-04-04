using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Web;
using System.Collections;
using System.Text.RegularExpressions;

namespace AppPub
{
    /// <summary>身份证解析类</summary>
    public class IdCardAssay 
    {
        /// <summary>设置或获取随即种子(默认值：-99999999)</summary> 
        private static int _Seed = -99999999;

        /// <summary>设置或获取随即种子，每获取一次，随即种子自动加1(默认值：-99999999)</summary>
        public static int Seed
        {
            get
            {
                if (_Seed > 99999999 || _Seed < -99999999)
                {
                    _Seed = -99999999;
                }
                _Seed++;
                return _Seed;
            }
            set { _Seed = value; }
        }

        /// <summary>设置或获取身份证号码前6位数数据集</summary> 
        private static List<string> _CardPrefixList;

        /// <summary>设置或获取身份证号码前6位数数据集</summary> 
        public static List<string> CardPrefixList
        {
            get
            {
                if (_CardPrefixList==null)
                {
                    List<string> prefix = new List<string>();
                    prefix.Add("110000");
                    prefix.Add("110100");
                    prefix.Add("110101");
                    prefix.Add("110102");
                    prefix.Add("110103");
                    prefix.Add("110104");
                    prefix.Add("130102");
                    prefix.Add("130103");
                    prefix.Add("130104");
                    prefix.Add("130105");
                    prefix.Add("130106");
                    prefix.Add("130107");
                    prefix.Add("130121");
                    prefix.Add("130123");
                    prefix.Add("130124");
                    prefix.Add("130125");
                    prefix.Add("130126");
                    prefix.Add("130127");
                    prefix.Add("130128");
                    prefix.Add("130129");
                    prefix.Add("130130");
                    prefix.Add("130131");
                    prefix.Add("142600");
                    prefix.Add("142601");
                    prefix.Add("142602");
                    prefix.Add("142603");
                    prefix.Add("142621");
                    prefix.Add("142622");
                    prefix.Add("142623");
                    prefix.Add("142625");
                    prefix.Add("210301");
                    prefix.Add("210302");
                    prefix.Add("210303");
                    prefix.Add("210304");
                    prefix.Add("210311");
                    prefix.Add("210321");
                    prefix.Add("210323");
                    prefix.Add("210381");
                    prefix.Add("210400");
                    prefix.Add("210401");
                    prefix.Add("210402");
                    prefix.Add("210403");
                    prefix.Add("210404");
                    prefix.Add("210411");
                    prefix.Add("210421");
                    prefix.Add("210422");
                    prefix.Add("210423");
                    prefix.Add("210500");
                    prefix.Add("210501");
                    prefix.Add("230623");
                    prefix.Add("230624");
                    prefix.Add("230700");
                    prefix.Add("230701");
                    prefix.Add("230702");
                    prefix.Add("230703");
                    prefix.Add("230704");
                    prefix.Add("230705");
                    prefix.Add("230706");
                    prefix.Add("230707");
                    prefix.Add("320700");
                    prefix.Add("320701");
                    prefix.Add("320703");
                    prefix.Add("320704");
                    prefix.Add("320705");
                    prefix.Add("320706");
                    prefix.Add("320721");
                    prefix.Add("320722");
                    prefix.Add("410501");
                    prefix.Add("410502");
                    prefix.Add("410503");
                    prefix.Add("410504");
                    prefix.Add("410511");
                    prefix.Add("410522");
                    prefix.Add("410523");
                    prefix.Add("410526");
                    prefix.Add("410527");
                    prefix.Add("410581");
                    prefix.Add("410600");
                    prefix.Add("410601");
                    prefix.Add("410602");
                    prefix.Add("410603");
                    prefix.Add("410611");
                    prefix.Add("510500");
                    prefix.Add("510501");
                    prefix.Add("510502");
                    prefix.Add("510503");
                    prefix.Add("510504");
                    prefix.Add("510522");
                    prefix.Add("510524");
                    prefix.Add("510525");
                    prefix.Add("510600");
                    prefix.Add("510601");
                    prefix.Add("510603");
                    prefix.Add("510623");
                    prefix.Add("510626");
                    prefix.Add("510681");
                    prefix.Add("510682");
                    prefix.Add("510683");
                    prefix.Add("510700");
                    prefix.Add("510701");
                    prefix.Add("510703");
                    prefix.Add("510704");
                    prefix.Add("510722");
                    prefix.Add("510723");
                    prefix.Add("510724");
                    prefix.Add("510725");
                    prefix.Add("510726");
                    prefix.Add("510727");
                    prefix.Add("652101");
                    prefix.Add("652122");
                    prefix.Add("652123");
                    prefix.Add("652200");
                    prefix.Add("652201");
                    prefix.Add("652222");
                    prefix.Add("652223");
                    prefix.Add("652300");
                    prefix.Add("652301");
                    prefix.Add("659001");
                    _CardPrefixList = prefix;
                }
                return _CardPrefixList;
            }
            set { _CardPrefixList = value; }
        }

        /// <summary>设置或获取电话号码前3位数数据集</summary> 
        private static List<string> _PhonePrefixList;

        /// <summary>设置或获取电话号码前3位数数据集</summary> 
        public static List<string> PhonePrefixList
        {
            get
            {
                if (_PhonePrefixList == null)
                {
                    List<string> prefix = new List<string>();
                    prefix.Add("134");
                    prefix.Add("135");
                    prefix.Add("136");
                    prefix.Add("137");
                    prefix.Add("138");
                    prefix.Add("139");
                    prefix.Add("150");
                    prefix.Add("151");
                    prefix.Add("152");
                    prefix.Add("157");
                    prefix.Add("158");
                    prefix.Add("159");
                    prefix.Add("187");
                    prefix.Add("188");
                    prefix.Add("130");
                    prefix.Add("131");
                    prefix.Add("132");
                    prefix.Add("155");
                    prefix.Add("156");
                    prefix.Add("185");
                    prefix.Add("186");
                    prefix.Add("133");
                    prefix.Add("153");
                    prefix.Add("180");
                    prefix.Add("189");
                    _PhonePrefixList = prefix;
                }
                return _PhonePrefixList;
            }
            set { _PhonePrefixList = value; }
        }

        /// <summary>返回一个18位随机身份证号</summary>
        /// <param name="ymin">年份的最小值</param>
        /// <param name="ymax">年份的最大值</param>
        /// <returns>返回一个18位随机身份证号</returns>
        public static string GenRandomIDCard(int ymin, int ymax)
        {
            return GenRandomIDCard(ymin, ymax, 1, 12, 1, 25);
        }

        /// <summary>返回一个18位随机身份证号</summary>
        /// <param name="ymin">年份的最小值</param>
        /// <param name="ymax">年份的最大值</param>
        /// <param name="m1">月份的后两位数最小值，如1</param>
        /// <param name="m2">月份的后两位数最大值，如12</param>
        /// <param name="d1">月份的后两位数最小值，如1</param>
        /// <param name="d2">月份的后两位数最大值，如30</param>
        /// <returns>返回一个18位随机身份证号</returns>
        public static string GenRandomIDCard(int ymin, int ymax, int m1, int m2, int d1, int d2)
        {
            string _pinCode = string.Format("{0}{1:0000}{2:00}{3:00}{4:000}", CardPrefixList[AppPub.pub.ran.Next(0, CardPrefixList.Count - 1)], AppPub.pub.ran.Next(ymin, ymax), AppPub.pub.ran.Next(m1, m2), AppPub.pub.ran.Next(d1, d2), AppPub.pub.ran.Next(1, 600));
            char[] _chrPinCode = _pinCode.ToCharArray();
            char[] _chrVerify = new char[] { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };//校验码字符值
            //i----表示号码字符从由至左包括校验码在内的位置序号；
            //ai----表示第i位置上的号码字符值；
            //Wi----示第i位置上的加权因子，其数值依据公式intWeight=2（n-1）(mod 11)计算得出。
            int[] _intWeight = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2, 1 };
            int _craboWeight = 0;
            for (int i = 0; i < 17; i++)//从1 到 17 位,18为要生成的验证码
            {
                _craboWeight = _craboWeight + Convert.ToUInt16(_chrPinCode[i].ToString()) * _intWeight[i];
            }
            _craboWeight = _craboWeight % 11;
            _pinCode += _chrVerify[_craboWeight];
            return _pinCode;
        }

        /// <summary>分析并返回身份证号的出生日期和年龄以及性别</summary>
        /// <param name="idCard">身份证号</param>
        /// <param name="birthday">出生日期</param>
        /// <param name="age">年龄</param>
        /// <param name="gender">性别（M：男；F：女）</param>
        /// <returns>分析并返回身份证号的出生日期和年龄以及性别</returns>
        public static bool GetIDCardInfo(string idCard, ref string birthday, ref int age, ref string gender)
        {
            try
            {
                string sex = "";
                if (idCard.Length == 18)
                {
                    birthday = idCard.Substring(6, 4) + "-" + idCard.Substring(10, 2) + "-" + idCard.Substring(12, 2);
                    sex = idCard.Substring(14, 3);
                }
                if (idCard.Length == 15)
                {
                    birthday = "19" + idCard.Substring(6, 2) + "-" + idCard.Substring(8, 2) + "-" + idCard.Substring(10, 2);
                    sex = idCard.Substring(12, 3);
                }
                if (Convert.ToInt32(sex) % 2 == 0)
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                age = GetAge(birthday);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>根据出生日期返回年龄</summary>
        /// <param name="birthday">出生日期</param>
        /// <returns>根据出生日期返回年龄<</returns>
        public static int GetAge(string birthday)
        {
            int m_Y1 = DateTime.Parse(birthday).Year;
            int m_Y2 = DateTime.Now.Year;
            return m_Y2 - m_Y1;
        }

        /// <summary>返回一个11位的随机手机号码</summary>
        /// <returns>返回一个11位的随机手机号码</returns>
        public static string GenRandomPhone()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}", PhonePrefixList[AppPub.pub.ran.Next(0, PhonePrefixList.Count - 1)], AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9), AppPub.pub.ran.Next(0, 9));
        }
    }
}