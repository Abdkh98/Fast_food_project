namespace SMP
{
    partial class Main

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.btn_Reports = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sales = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Purchases = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Category = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Home = new DevExpress.XtraEditors.SimpleButton();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.pn_titlenav = new System.Windows.Forms.Panel();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.pn_topnav = new System.Windows.Forms.Panel();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.btn_colse = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Users = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Suppliers = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_collapse = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogOut = new DevExpress.XtraEditors.SimpleButton();
            this.pn_navbar.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.pn_titlenav.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_topnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.btn_Users);
            this.pn_navbar.Controls.Add(this.btn_Reports);
            this.pn_navbar.Controls.Add(this.btn_Sales);
            this.pn_navbar.Controls.Add(this.btn_Purchases);
            this.pn_navbar.Controls.Add(this.btn_Suppliers);
            this.pn_navbar.Controls.Add(this.btn_Category);
            this.pn_navbar.Controls.Add(this.btn_Home);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_navbar.Location = new System.Drawing.Point(0, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(188, 516);
            this.pn_navbar.TabIndex = 1;
            // 
            // btn_Reports
            // 
            this.btn_Reports.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Reports.Appearance.Options.UseFont = true;
            this.btn_Reports.Appearance.Options.UseForeColor = true;
            this.btn_Reports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reports.ImageOptions.SvgImage")));
            this.btn_Reports.Location = new System.Drawing.Point(0, 356);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Reports.Size = new System.Drawing.Size(185, 33);
            this.btn_Reports.TabIndex = 7;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Sales.Appearance.Options.UseFont = true;
            this.btn_Sales.Appearance.Options.UseForeColor = true;
            this.btn_Sales.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sales.ImageOptions.SvgImage")));
            this.btn_Sales.Location = new System.Drawing.Point(0, 317);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Sales.Size = new System.Drawing.Size(185, 33);
            this.btn_Sales.TabIndex = 6;
            this.btn_Sales.Text = "Sales";
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // btn_Purchases
            // 
            this.btn_Purchases.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchases.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Purchases.Appearance.Options.UseFont = true;
            this.btn_Purchases.Appearance.Options.UseForeColor = true;
            this.btn_Purchases.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Purchases.ImageOptions.SvgImage")));
            this.btn_Purchases.Location = new System.Drawing.Point(0, 278);
            this.btn_Purchases.Name = "btn_Purchases";
            this.btn_Purchases.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Purchases.Size = new System.Drawing.Size(185, 33);
            this.btn_Purchases.TabIndex = 4;
            this.btn_Purchases.Text = "Purchases";
            this.btn_Purchases.Click += new System.EventHandler(this.btn_Purchases_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Category.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Category.Appearance.Options.UseFont = true;
            this.btn_Category.Appearance.Options.UseForeColor = true;
            this.btn_Category.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Category.ImageOptions.SvgImage")));
            this.btn_Category.Location = new System.Drawing.Point(0, 200);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Category.Size = new System.Drawing.Size(185, 33);
            this.btn_Category.TabIndex = 2;
            this.btn_Category.Text = "Categories";
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click_1);
            // 
            // btn_Home
            // 
            this.btn_Home.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Home.Appearance.Options.UseFont = true;
            this.btn_Home.Appearance.Options.UseForeColor = true;
            this.btn_Home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Home.ImageOptions.SvgImage")));
            this.btn_Home.Location = new System.Drawing.Point(0, 161);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Home.Size = new System.Drawing.Size(185, 33);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.Controls.Add(this.pn_titlenav);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(188, 159);
            this.pn_headernavbar.TabIndex = 0;
            // 
            // pn_titlenav
            // 
            this.pn_titlenav.Controls.Add(this.pictureBox1);
            this.pn_titlenav.Controls.Add(this.lblRoll);
            this.pn_titlenav.Controls.Add(this.lblusername);
            this.pn_titlenav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_titlenav.Location = new System.Drawing.Point(46, 0);
            this.pn_titlenav.Name = "pn_titlenav";
            this.pn_titlenav.Size = new System.Drawing.Size(142, 159);
            this.pn_titlenav.TabIndex = 1;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("A Jannat LT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRoll.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRoll.Location = new System.Drawing.Point(73, 130);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(47, 22);
            this.lblRoll.TabIndex = 7;
            this.lblRoll.Text = "Admin";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblusername.ForeColor = System.Drawing.Color.Silver;
            this.lblusername.Location = new System.Drawing.Point(2, 108);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(129, 29);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "Abdallah Khader";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_collapse);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(46, 159);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pn_cont
            // 
            this.pn_cont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_cont.Location = new System.Drawing.Point(188, 42);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.Size = new System.Drawing.Size(702, 474);
            this.pn_cont.TabIndex = 3;
            // 
            // pn_topnav
            // 
            this.pn_topnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topnav.Controls.Add(this.btn_min);
            this.pn_topnav.Controls.Add(this.btnLogOut);
            this.pn_topnav.Controls.Add(this.btn_max);
            this.pn_topnav.Controls.Add(this.lb_titlepage);
            this.pn_topnav.Controls.Add(this.btn_colse);
            this.pn_topnav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topnav.Location = new System.Drawing.Point(188, 0);
            this.pn_topnav.Name = "pn_topnav";
            this.pn_topnav.Size = new System.Drawing.Size(702, 41);
            this.pn_topnav.TabIndex = 0;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.ForeColor = System.Drawing.Color.Silver;
            this.lb_titlepage.Location = new System.Drawing.Point(248, 4);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(73, 35);
            this.lb_titlepage.TabIndex = 11;
            this.lb_titlepage.Text = "Home ";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_topnav;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(565, -1);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(40, 40);
            this.btn_min.TabIndex = 7;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click_1);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.ImageOptions.Image")));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(611, -1);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(40, 40);
            this.btn_max.TabIndex = 8;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_colse
            // 
            this.btn_colse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_colse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_colse.ImageOptions.Image")));
            this.btn_colse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_colse.Location = new System.Drawing.Point(657, -1);
            this.btn_colse.Name = "btn_colse";
            this.btn_colse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_colse.Size = new System.Drawing.Size(40, 40);
            this.btn_colse.TabIndex = 10;
            this.btn_colse.Click += new System.EventHandler(this.btn_colse_Click);
            // 
            // btn_Users
            // 
            this.btn_Users.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Users.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Users.Appearance.Options.UseFont = true;
            this.btn_Users.Appearance.Options.UseForeColor = true;
            this.btn_Users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Users.ImageOptions.Image")));
            this.btn_Users.Location = new System.Drawing.Point(0, 395);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Users.Size = new System.Drawing.Size(185, 33);
            this.btn_Users.TabIndex = 8;
            this.btn_Users.Text = "Users";
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Suppliers
            // 
            this.btn_Suppliers.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suppliers.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.btn_Suppliers.Appearance.Options.UseFont = true;
            this.btn_Suppliers.Appearance.Options.UseForeColor = true;
            this.btn_Suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suppliers.ImageOptions.Image")));
            this.btn_Suppliers.Location = new System.Drawing.Point(0, 239);
            this.btn_Suppliers.Name = "btn_Suppliers";
            this.btn_Suppliers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Suppliers.Size = new System.Drawing.Size(185, 33);
            this.btn_Suppliers.TabIndex = 3;
            this.btn_Suppliers.Text = "Suppliers";
            this.btn_Suppliers.Click += new System.EventHandler(this.btn_Suppliers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_collapse
            // 
            this.btn_collapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_collapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_collapse.ImageOptions.Image")));
            this.btn_collapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_collapse.Location = new System.Drawing.Point(3, 3);
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_collapse.Size = new System.Drawing.Size(36, 38);
            this.btn_collapse.TabIndex = 7;
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnLogOut.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLogOut.Location = new System.Drawing.Point(519, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnLogOut.Size = new System.Drawing.Size(40, 40);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 516);
            this.Controls.Add(this.pn_topnav);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Main";
            this.Text = "SMP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_navbar.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_titlenav.ResumeLayout(false);
            this.pn_titlenav.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_topnav.ResumeLayout(false);
            this.pn_topnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_headernavbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Home;
        private DevExpress.XtraEditors.SimpleButton btn_collapse;
        private DevExpress.XtraEditors.SimpleButton btn_Users;
        private DevExpress.XtraEditors.SimpleButton btn_Reports;
        private DevExpress.XtraEditors.SimpleButton btn_Sales;
        private DevExpress.XtraEditors.SimpleButton btn_Purchases;
        private DevExpress.XtraEditors.SimpleButton btn_Suppliers;
        private DevExpress.XtraEditors.SimpleButton btn_Category;
        private System.Windows.Forms.Panel pn_titlenav;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Panel pn_topnav;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private System.Windows.Forms.Label lb_titlepage;
        private DevExpress.XtraEditors.SimpleButton btn_colse;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label lblRoll;
        public System.Windows.Forms.Label lblusername;
        private DevExpress.XtraEditors.SimpleButton btnLogOut;
    }
}

