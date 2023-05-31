using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL
{
    public partial class frm_Home : Form
    {
        frm_Category frm_cat = new frm_Category();

        public frm_Home()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_CategoryADD frm_add = new frm_CategoryADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
            frm_cat.update_data();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frm_SUPPADD frm_add = new frm_SUPPADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
            frm_cat.update_data();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_SELLADD frm_add = new frm_SELLADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
            frm_cat.update_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_PURADD frm_add = new frm_PURADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
            frm_cat.update_data();

        }
    }
}
