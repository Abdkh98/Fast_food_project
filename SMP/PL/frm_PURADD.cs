using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.BL;
using SMP.EPL;
using SMP.PL;
using System.Data.Entity;

namespace SMP.PL
{
    public partial class frm_PURADD : Form
    {
        frm_PUR frm_pur = new frm_PUR();
        DB_SMPEntities db = new DB_SMPEntities();
        Purchase tb_pur = new Purchase();
        Methods methods = new Methods();
        double buy, sell, qt, tbuy, tsell, trev;


        public int id;

        public frm_PURADD()
        {
            InitializeComponent();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_cal();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_cal();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            if (txtItemName.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lbl_Caption.Text = "Please Complete the information";
                dialog.Show();
            }
            else
            {

                if (id == 0)
                {
                    tb_pur.Pur_name = txtItemName.Text;
                    tb_pur.Pur_Type = txtType.Text;
                    tb_pur.Pur_Cat = cmbxCategory.Text;
                    tb_pur.Pur_Supp = cmbxSuppliers.Text;
                    tb_pur.Pur_Det = txtDetails.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);
                    db.Purchases.Add(tb_pur);
                   
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "buy has been successful";
                    toast.Show();
                    this.Close();

                }
                else
                {
                    tb_pur.Pur_name = txtItemName.Text;
                    tb_pur.Pur_Type = txtType.Text;
                    tb_pur.Pur_Cat = cmbxCategory.Text;
                    tb_pur.Pur_Supp = cmbxSuppliers.Text;
                    tb_pur.Pur_Det = txtDetails.Text;
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);
                    tb_pur.ID = id;
                    db.Entry(tb_pur).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "Edited has been successful";
                    toast.Show();
                    db = new DB_SMPEntities();
                    frm_pur.gridControl1.DataSource = db.Purchases.ToList();
                    this.Close();

                }



            }
        
    
        }

        private void frm_PURADD_Activated(object sender, EventArgs e)
        {
            cmbxCategory.DataSource=db.Categories.Select(x=>x.CAT_Name).ToList();
            cmbxSuppliers.DataSource = db.Suppliers.Select(x => x.Supp_Name).ToList();

        }

        private void lnklblAddCatecory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_CategoryADD frm_add = new frm_CategoryADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
        }

        private void lnklblAddSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_SUPPADD frm_add = new frm_SUPPADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
        }
        private void pro_cal ()
        {
            sell =Convert.ToDouble(edt_sell.Text);
            buy = Convert.ToDouble(edt_buy.Text);
            qt = Convert.ToDouble(edt_qt.Value);
            tsell = sell * qt; 
            tbuy=buy * qt;
            trev = tsell-tbuy;
            edt_tbuy.Text = tbuy.ToString();
            edt_tsell.Text = tsell.ToString();
            edt_trev.Text = trev.ToString();

        }
    }
}
