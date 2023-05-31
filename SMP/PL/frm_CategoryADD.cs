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
    public partial class frm_CategoryADD : Form
    {
        frm_Category frm_cat =new frm_Category();

        DB_SMPEntities db =new DB_SMPEntities();   
        Category tb_category = new Category();
        Methods methods = new Methods();
      
        public int id;

        public frm_CategoryADD()
        {
            InitializeComponent();
        }

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            if (txt_EditName.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lbl_Caption.Text = "the requested name of Category";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_category.CAT_Name = txt_EditName.Text;
                    tb_category.Cat_Cover = methods.convertbyte();
                    db.Categories.Add(tb_category);
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "Added New Category has been successful";
                    toast.Show();
                    db = new DB_SMPEntities();
                    frm_cat.gridControl1.DataSource = db.Categories.ToList();
                    this.Close();
                    frm_cat.update_data();

                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_category.CAT_Name = txt_EditName.Text;
                    tb_category.ID= id;
                    tb_category.Cat_Cover = methods.convertbyte();
                    db.Entry(tb_category).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "Edited has been successful";
                    toast.Show();
                    db = new DB_SMPEntities();
                    this.Close();
                   
                }



            }
        }

        private void btn_colse_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
