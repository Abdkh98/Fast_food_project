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
    public partial class frm_SELL : Form
    {
        Methods methods = new Methods();
        DB_SMPEntities db = new DB_SMPEntities();
        Purchase tb_pur = new Purchase();
        Sell tb_sell = new Sell();

        int id;

        public frm_SELL()
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

            frm_SELLADD frm_add = new frm_SELLADD();
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
                    tb_sell = db.Sells.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_sell).State = EntityState.Deleted;
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
            gridControl1.DataSource = db.Sells.ToList();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();

            try
            {
                frm_SELLADD frm_add = new frm_SELLADD();
                id = Convert.ToInt32(gridView1.GetFocusedRowCellDisplayText("ID"));
                tb_sell = db.Sells.Where(x => x.ID == id).FirstOrDefault();
                frm_add.cmbxItemName.Text = tb_sell.Sell_nameItem.ToString();
                frm_add.txtClinetName.Text = tb_sell.Sell_nameClient.ToString();
                frm_add.edt_price.Text = tb_sell.Sell_Price.ToString();
                frm_add.edt_qt.Text = tb_sell.Sell_Qt.ToString();

                frm_add.id = id;
                frm_add.btn_add.Text = "Edit";
                frm_add.Show();
                update_data();
            }
            catch
            {

                dialog.lbl_Caption.Text = "There is no data to Edit";
                dialog.Width = this.Width;
                dialog.Show();

            }

        }

       


    }

}
