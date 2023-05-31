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
    public partial class frm_Login : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        User tb_users = new User();
        Main main = new Main();
        frm_Casher frm_casher = new frm_Casher();




        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            /*
admin 
username: aa
password: 123

casher
username: abd
password; 123
*/
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            if (txt_UserName.Text == "" || txtPass.Text == "")
            {
                dialog.Width = this.Width;
                dialog.lbl_Caption.Text = "Please Complete the information";
                dialog.Show();
            }
            else
            {

                tb_users = db.Users.Where(x => x.User_Name == txt_UserName.Text && x.User_Pass == txtPass.Text).FirstOrDefault();
                if (tb_users != null)
                {
                    if (tb_users.User_Roll == "Admin")

                    {
                        tb_users.User_State = "true";
                        db.Entry(tb_users).State = EntityState.Modified;
                        main.lblusername.Text = tb_users.User_Name;
                        main.lblRoll.Text = tb_users.User_Roll;
                        main.Enabled = true;
                        db.SaveChanges();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        tb_users.User_State = "true";
                        db.Entry(tb_users).State = EntityState.Modified;
                        main.lblusername.Text = tb_users.User_Name;
                        main.lblRoll.Text = tb_users.User_Roll;
                        main.Enabled = true;
                        db.SaveChanges();
                        frm_casher.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Faild Login");
                }





            }



        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            main.Enabled = false;
        }

        private void btn_colse_Click(object sender, EventArgs e)
        {


            Environment.Exit(0);

        }
    }
}
