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
using SMP.BL;
using SMP.EPL;
using SMP.PL;
namespace SMP.PL
{
    public partial class frm_Users : Form
    {
        DB_SMPEntities db=new DB_SMPEntities();
        User tb_users = new User();
        Methods methods = new Methods();
        int id;
        public frm_Users()
        {
            InitializeComponent();

            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Users.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_UsersADD frm_add = new frm_UsersADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "ADD";
            frm_add.Show();
        }
        public void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.Users.ToList();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                frm_UsersADD frm_add = new frm_UsersADD();
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                tb_users = db.Users.Where(x => x.ID == id).FirstOrDefault();
                frm_add.txt_UserName.Text = tb_users.User_Name;
                frm_add.txtPass.Text = tb_users.User_Pass;
                frm_add.cmbxRoll.Text = tb_users.User_Roll;
             methods.by = tb_users.User_image;
               frm_add.pic_cover.Image = Image.FromStream(methods.convert_image());
                frm_add.id = id;
                frm_add.btn_add.Text = "Edit";
                frm_add.Show();
                update_data();
            }
            catch
            {
                dialog.lbl_Caption.Text = "There is no users to Edit";
                dialog.Width = this.Width;
                dialog.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            if (id>0) 
            {
                try
                {
                    var rs = MessageBox.Show("Delete Proccess", "are you from this proccess", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        tb_users = db.Users.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_users).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.lbl_Caption.Text = "The user has been deleted";
                        toast.Width = this.Width;
                        toast.Show();
                        update_data();
                    }

                }
                catch
                {

                    dialog.lbl_Caption.Text = "There is no users to delete";
                    dialog.Width = this.Width;
                    dialog.Show();


                } }
        }
    }
}
