namespace SMP.PL
{
    partial class frm_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_salesReport = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pur = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 450);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_salesReport);
            this.flowLayoutPanel1.Controls.Add(this.btn_pur);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_salesReport
            // 
            this.btn_salesReport.Appearance.Font = new System.Drawing.Font("A Jannat LT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salesReport.Appearance.Options.UseFont = true;
            this.btn_salesReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btn_salesReport.Location = new System.Drawing.Point(20, 20);
            this.btn_salesReport.Margin = new System.Windows.Forms.Padding(20);
            this.btn_salesReport.Name = "btn_salesReport";
            this.btn_salesReport.Padding = new System.Windows.Forms.Padding(15);
            this.btn_salesReport.Size = new System.Drawing.Size(292, 191);
            this.btn_salesReport.TabIndex = 19;
            this.btn_salesReport.Text = "Sales Report";
            this.btn_salesReport.Click += new System.EventHandler(this.btn_salesReport_Click);
            // 
            // btn_pur
            // 
            this.btn_pur.Appearance.Font = new System.Drawing.Font("A Jannat LT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pur.Appearance.Options.UseFont = true;
            this.btn_pur.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btn_pur.Location = new System.Drawing.Point(352, 20);
            this.btn_pur.Margin = new System.Windows.Forms.Padding(20);
            this.btn_pur.Name = "btn_pur";
            this.btn_pur.Padding = new System.Windows.Forms.Padding(15);
            this.btn_pur.Size = new System.Drawing.Size(292, 191);
            this.btn_pur.TabIndex = 20;
            this.btn_pur.Text = "Purchases Report";
            this.btn_pur.Click += new System.EventHandler(this.btn_pur_Click);
            // 
            // frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Report";
            this.Text = "frm_Categary";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_salesReport;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public DevExpress.XtraEditors.SimpleButton btn_pur;
    }
}