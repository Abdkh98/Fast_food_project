using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.PL;

namespace SMP
{
    public partial class Main : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();  
        frm_Home frm_home = new frm_Home();
        frm_Category frm_category = new frm_Category();
        frm_SUPP frm_supp = new frm_SUPP(); 
        frm_PUR frm_pur=new frm_PUR();
        frm_SELL frm_sell = new frm_SELL();
        frm_Report frm_report = new frm_Report();
        frm_Users frm_users = new frm_Users();
        User tb_users=new User();
        public Main()
        {
            InitializeComponent();
        }

        

     

        

        

        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 188)
            {
                pn_navbar.Width = 40;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 149;
            }
            else
            {
                pn_navbar.Width = 188;
                pn_titlenav.Visible = true;
                pn_headernavbar.Height = 159;
            }

        }

        

        private void btn_Home_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_Home);
        }

       

       

        private void btn_Category_Click_1(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_category.pn_Category);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "Categories";
        }

       

        

        

        private void btn_colse_Click(object sender, EventArgs e)
        {
           var res= MessageBox.Show("Are You Sure To Exit ?", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_min_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_Home);
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_Category);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "Suppliers";
            frm_supp.update_data();


        }

        private void btn_Purchases_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_Category);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "Purchases";
            frm_pur.update_data();
        }

        private void btn_Sales_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_Category);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "Sales";
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.panel1);
     
            lb_titlepage.Text = "Report";
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_users.pn_Category);

            lb_titlepage.Text = "Users";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            tb_users = db.Users.Where(x => x.User_State == "true").FirstOrDefault();
            tb_users.User_State = "false";
            db.Entry(tb_users).State = EntityState.Modified;
            db.SaveChanges();
            this.Enabled = false;
            login.Show();
            this.Hide();
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }
    }
}
