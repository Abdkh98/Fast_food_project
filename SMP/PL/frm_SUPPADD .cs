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
    public partial class frm_SUPPADD  : Form
    {
        frm_SUPP frm_supp =new frm_SUPP();

        DB_SMPEntities db =new DB_SMPEntities();   
        Supplier tb_supp = new Supplier();
        Methods methods = new Methods();
   
        public int id;

        public frm_SUPPADD()
        {
            InitializeComponent();
        }

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            if (txt_Name.Text == ""&&txtPhone.Text==""&&txtEmail.Text=="")
            {
                dialog.Width = this.Width;
                dialog.lbl_Caption.Text = "please complete information";
                dialog.Show();
            }
            else
            {
                if (id == 0)
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.Supp_Name = txt_Name.Text;
                    tb_supp.Supp_Phone = txtPhone.Text;
                    tb_supp.Supp_Email = txtEmail.Text; 
                    tb_supp.Supp_image = methods.convertbyte();
                    db.Suppliers.Add(tb_supp);
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "Added New Supplier has been successful";
                    toast.Show();
                    this.Close();

                }
                else
                {
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = txt_Name.Text;
                    tb_supp.Supp_Phone = txtPhone.Text;
                    tb_supp.Supp_Email = txtEmail.Text;
                    tb_supp.Supp_image = methods.convertbyte();
                    db.Entry(tb_supp).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "Edited has been successful";
                    toast.Show();
                    db = new DB_SMPEntities();
                    this.Close();
                   
                }



            }
        }

        
    }
}
