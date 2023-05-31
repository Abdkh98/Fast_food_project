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
    public partial class frm_UsersADD : Form
    {
        DB_SMPEntities db =new DB_SMPEntities();
        User tb_users = new User();
        Methods methods=new Methods();
        frm_Users frm_users = new frm_Users();
        public int id;

        public frm_UsersADD()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            if (txt_UserName.Text == ""||txtPass.Text==""||cmbxRoll.Text=="")
            {
                dialog.Width = this.Width;
                dialog.lbl_Caption.Text = "Please Complete the information";
                dialog.Show();
            }
            else
            {

                if (id == 0)
                {
                   pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_users.User_Name = txt_UserName.Text;
                    tb_users.User_Pass = txtPass.Text;
                    tb_users.User_Roll = cmbxRoll.Text;
                   tb_users.User_image = methods.convertbyte();
                    tb_users.User_State = "false";
                    db.Users.Add(tb_users);
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "User added has been successful";
                    toast.Show();
                    this.Close();

                }
                else
                {
                  pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_users.ID = id;
                    tb_users.User_Name = txt_UserName.Text;
                    tb_users.User_Pass = txtPass.Text;
                    tb_users.User_Roll = cmbxRoll.Text;
                   tb_users.User_image = methods.convertbyte();

                    tb_users.User_State = "false";
                    db.Entry(tb_users).State = EntityState.Modified;
                    db.SaveChanges();
                    toast.lbl_Caption.Text = "Edited has been successful";
                    toast.Show();
                    this.Close();

                }



            }


        
    }
    }
}
