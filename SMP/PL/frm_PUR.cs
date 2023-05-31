using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SMP.EPL;
using SMP.BL;

namespace SMP.PL
{
    public partial class frm_PUR : Form
    {
        Methods methods = new Methods();
        DB_SMPEntities db = new DB_SMPEntities();
        Supplier tb_supp = new Supplier();
        Purchase tb_pur = new Purchase();
        int id;

        public frm_PUR()
        {
            InitializeComponent();

            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Purchases.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.Purchases.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            frm_PURADD frm_add = new frm_PURADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("Delete Proccess", "are you from this proccess", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    tb_pur = db.Purchases.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_pur).State = EntityState.Deleted;
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "The item has been deleted";
                    toast.Width = this.Width;
                    toast.Show();
                    update_data();
                }

            }
            catch
            {

                dialog.lbl_Caption.Text = "There is no item to delete";
                dialog.Width = this.Width;
                dialog.Show();

            }

        }
        public void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.Purchases.ToList();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_PURADD frm_add = new frm_PURADD();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            tb_pur = db.Purchases.Where(x => x.ID == id).FirstOrDefault();
            frm_add.txtItemName.Text = tb_pur.Pur_name;
            frm_add.txtType.Text = tb_pur.Pur_Type;
            frm_add.cmbxCategory.Text = tb_pur.Pur_Cat;


            frm_add.cmbxSuppliers.Text = tb_pur.Pur_Supp;
            frm_add.txtDetails.Text = tb_pur.Pur_Det;

            frm_add.edt_buy.Text = tb_pur.Pur_Buy.ToString();
            frm_add.edt_sell.Text = tb_pur.Pur_Sell.ToString();
            frm_add.edt_qt.Text = tb_pur.Pur_Qt.ToString();
            frm_add.edt_tbuy.Text = tb_pur.Pur_Tbuy.ToString();
            frm_add.edt_tsell.Text = tb_pur.Pur_Tsell.ToString();
            frm_add.edt_trev.Text = tb_pur.Pur_TRev.ToString();
            frm_add.id = id;
            frm_add.btn_add.Text = "Edit";
            frm_add.Show();
        }
    }

}
