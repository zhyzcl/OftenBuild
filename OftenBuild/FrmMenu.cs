using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OftenBuild
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btfare_Click(object sender, EventArgs e)
        {
            FrmFareBuild form = new FrmFareBuild();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);
        }

        private void btrank_Click(object sender, EventArgs e)
        {
            FrmRank form = new FrmRank();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);
        }

        private void btguid_Click(object sender, EventArgs e)
        {
            FrmGuidBuild form = new FrmGuidBuild();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);
        }

        private void btcode_Click(object sender, EventArgs e)
        {
            FrmCode form = new FrmCode();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);
        }

        private void btbank_Click(object sender, EventArgs e)
        {
            FrmBankBuild form = new FrmBankBuild();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);
        }

        private void btjson_Click(object sender, EventArgs e)
        {
            FrmJson form = new FrmJson();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);     
        }
    }
}
