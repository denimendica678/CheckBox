using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkDorucak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDorucak.Checked)
            {
                txtIspis.Text = chkDorucak.Text = chkDorucak.SelectedItem.ToString(); ;
            }

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (btnPosalji.Enabled)
            {
                txtIspis.Text = "Vaš odabir je: ";
            }
        }

        private void chkRucak_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRucak.Checked)
            {
                txtIspis.Text = "Vaš odabir je: Ručak";
            }
        }

        private void chkVečera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVečera.Checked)
            {
                txtIspis.Text = "Vaš odabir je: Večera";
            }
        }

        private void txtIspis_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
