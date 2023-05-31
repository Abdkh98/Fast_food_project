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
    public partial class frm_SUPP : Form
    {
        Methods methods = new Methods();
        DB_SMPEntities db =new DB_SMPEntities();
        Supplier tb_supp = new Supplier();
        
        int id;
        public frm_SUPP()
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
          
            frm_SUPPADD frm_add = new frm_SUPPADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "Add";
            frm_add.Show();
            update_data();

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
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                var rs = MessageBox.Show("Delete Proccess", "are you from this proccess", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    tb_supp = db.Suppliers.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(tb_supp).State = EntityState.Deleted;
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "The supplier has been deleted";
                    toast.Width = this.Width;
                    toast.Show();
                    update_data();
                }

            }
            catch {

                dialog.lbl_Caption.Text = "There is no supplier to delete";
                dialog.Width = this.Width;
                dialog.Show();
            
            
            }
            

            
        }
            public void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.Suppliers.ToList();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                frm_SUPPADD frm_add = new frm_SUPPADD();
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                tb_supp = db.Suppliers.Where(x => x.ID == id).FirstOrDefault();
                frm_add.txt_Name.Text = tb_supp.Supp_Name.ToString();
                frm_add.txtPhone.Text = tb_supp.Supp_Phone.ToString();
                frm_add.txtEmail.Text = tb_supp.Supp_Email.ToString();

                methods.by = tb_supp.Supp_image;
                frm_add.pic_cover.Image = Image.FromStream(methods.convert_image());
                frm_add.id = id;
                frm_add.btn_add.Text = "Edit";
                frm_add.Show();
                update_data();
            }
            catch
            {
                dialog.lbl_Caption.Text = "There is no supplier to Edit";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search=txt_search.Text;
            gridControl1.DataSource=db.Suppliers.Where(x=>x.Supp_Name.Contains(_search)|| x.Supp_Email.Contains(_search)||x.Supp_Phone.Contains(_search)).ToList();
        }
    }
}
