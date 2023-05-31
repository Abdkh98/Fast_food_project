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
    public partial class frm_SELLADD : Form
    {
        frm_SELL frm_sell = new frm_SELL();
        DB_SMPEntities db = new DB_SMPEntities();
        Purchase tb_pur = new Purchase();
        Sell tb_sell = new Sell();
        Methods methods = new Methods();
        double qtp, qtn, qtr;

        


        public int id;

        public frm_SELLADD()
        {
            InitializeComponent();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void cmbxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.Purchases.Where(x => x.Pur_name == cmbxItemName.Text).FirstOrDefault();
            edt_buy.Text = tb_pur.Pur_Buy.ToString();
            edt_sell.Text = tb_pur.Pur_Sell.ToString();
            edt_qt_.Text = tb_pur.Pur_Qt.ToString();
            edt_price.Text=tb_pur.Pur_Sell.ToString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            qtp = Convert.ToDouble(edt_qt_.Text);
            qtn = Convert.ToDouble(edt_qt.Text);
            qtr = qtp - qtn;


            if (cmbxItemName.Text == "" || txtClinetName.Text == "" || edt_price.Text == "" ||qtn<=0)
            {
                dialog.Width = this.Width;
                dialog.lbl_Caption.Text = "Please Complete the information";
                dialog.Show();
            }
            else
            {

                if (id == 0)
                {
                    if (qtr >= 0)
                    {

                        tb_sell.Sell_nameItem = cmbxItemName.Text;
                        tb_sell.Sell_nameClient = txtClinetName.Text;
                        tb_sell.Sell_Price = Convert.ToDouble(edt_price.Text);
                        tb_sell.Sell_Qt = Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_TPrice = Convert.ToDouble(edt_price.Text) * Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_Date = DateTime.Now;
                        db.Sells.Add(tb_sell);
                        tb_pur.Pur_Qt = qtr;
                        db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toast.lbl_Caption.Text = "buy has been successful";
                        toast.Show();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("the quantity is not available");
                    }
                  

                }
             
            }



            }
        
    
        

        private void frm_PURADD_Activated(object sender, EventArgs e)
        {
           var rs1=db.Purchases.Select(x=>x.Pur_name).ToList();
            cmbxItemName.DataSource = rs1;
            AutoCompleteStringCollection ACSC1=new AutoCompleteStringCollection();
            ACSC1.AddRange(rs1.ToArray());
            cmbxItemName.AutoCompleteCustomSource = ACSC1;
         

        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {

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
       
    }
}
