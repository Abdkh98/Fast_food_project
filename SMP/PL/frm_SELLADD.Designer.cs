namespace SMP.PL
{
    partial class frm_SELLADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SELLADD));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClinetName = new System.Windows.Forms.TextBox();
            this.lnklblAddCatecory = new System.Windows.Forms.LinkLabel();
            this.cmbxItemName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.edt_price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edt_qt_ = new System.Windows.Forms.Label();
            this.edt_sell = new System.Windows.Forms.Label();
            this.edt_buy = new System.Windows.Forms.Label();
            this.lblTotalEarnings = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClinetName);
            this.groupBox1.Controls.Add(this.lnklblAddCatecory);
            this.groupBox1.Controls.Add(this.cmbxItemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(584, 146);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background Information";
            // 
            // txtClinetName
            // 
            this.txtClinetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClinetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinetName.Location = new System.Drawing.Point(295, 89);
            this.txtClinetName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClinetName.Name = "txtClinetName";
            this.txtClinetName.Size = new System.Drawing.Size(263, 22);
            this.txtClinetName.TabIndex = 11;
            // 
            // lnklblAddCatecory
            // 
            this.lnklblAddCatecory.AutoSize = true;
            this.lnklblAddCatecory.Location = new System.Drawing.Point(245, 37);
            this.lnklblAddCatecory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblAddCatecory.Name = "lnklblAddCatecory";
            this.lnklblAddCatecory.Size = new System.Drawing.Size(42, 29);
            this.lnklblAddCatecory.TabIndex = 10;
            this.lnklblAddCatecory.TabStop = true;
            this.lnklblAddCatecory.Text = "Add";
            this.lnklblAddCatecory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAddCatecory_LinkClicked);
            // 
            // cmbxItemName
            // 
            this.cmbxItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxItemName.FormattingEnabled = true;
            this.cmbxItemName.Location = new System.Drawing.Point(295, 44);
            this.cmbxItemName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxItemName.Name = "cmbxItemName";
            this.cmbxItemName.Size = new System.Drawing.Size(263, 24);
            this.cmbxItemName.TabIndex = 7;
            this.cmbxItemName.SelectedIndexChanged += new System.EventHandler(this.cmbxItemName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edt_qt);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.edt_price);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 178);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(584, 145);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buying And Selling";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(25, 82);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Quantity";
            // 
            // edt_price
            // 
            this.edt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_price.Location = new System.Drawing.Point(295, 38);
            this.edt_price.Margin = new System.Windows.Forms.Padding(4);
            this.edt_price.Name = "edt_price";
            this.edt_price.Size = new System.Drawing.Size(263, 22);
            this.edt_price.TabIndex = 10;
            this.edt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(25, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Selling Price(Single)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edt_qt_);
            this.groupBox3.Controls.Add(this.edt_sell);
            this.groupBox3.Controls.Add(this.edt_buy);
            this.groupBox3.Controls.Add(this.lblTotalEarnings);
            this.groupBox3.Controls.Add(this.lblSales);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(644, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(332, 306);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // edt_qt_
            // 
            this.edt_qt_.AutoSize = true;
            this.edt_qt_.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt_.ForeColor = System.Drawing.Color.Blue;
            this.edt_qt_.Location = new System.Drawing.Point(148, 244);
            this.edt_qt_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edt_qt_.Name = "edt_qt_";
            this.edt_qt_.Size = new System.Drawing.Size(27, 35);
            this.edt_qt_.TabIndex = 5;
            this.edt_qt_.Text = "0";
            // 
            // edt_sell
            // 
            this.edt_sell.AutoSize = true;
            this.edt_sell.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sell.ForeColor = System.Drawing.Color.Blue;
            this.edt_sell.Location = new System.Drawing.Point(148, 155);
            this.edt_sell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(27, 35);
            this.edt_sell.TabIndex = 4;
            this.edt_sell.Text = "0";
            // 
            // edt_buy
            // 
            this.edt_buy.AutoSize = true;
            this.edt_buy.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buy.ForeColor = System.Drawing.Color.Blue;
            this.edt_buy.Location = new System.Drawing.Point(148, 66);
            this.edt_buy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Size = new System.Drawing.Size(27, 35);
            this.edt_buy.TabIndex = 3;
            this.edt_buy.Text = "0";
            // 
            // lblTotalEarnings
            // 
            this.lblTotalEarnings.AutoSize = true;
            this.lblTotalEarnings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalEarnings.Location = new System.Drawing.Point(129, 209);
            this.lblTotalEarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEarnings.Name = "lblTotalEarnings";
            this.lblTotalEarnings.Size = new System.Drawing.Size(74, 29);
            this.lblTotalEarnings.TabIndex = 2;
            this.lblTotalEarnings.Text = "Quantity";
            this.lblTotalEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSales.Location = new System.Drawing.Point(127, 117);
            this.lblSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(79, 29);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "Sell Price";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(127, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Buy Price";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(430, 331);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 74);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.Location = new System.Drawing.Point(295, 79);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt.Properties.Appearance.Options.UseFont = true;
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Size = new System.Drawing.Size(263, 22);
            this.edt_qt.TabIndex = 14;
            // 
            // frm_SELLADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SELLADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frm_PURADD_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label edt_qt_;
        public System.Windows.Forms.Label edt_sell;
        public System.Windows.Forms.Label lblTotalEarnings;
        public System.Windows.Forms.Label lblSales;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox edt_price;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.LinkLabel lnklblAddCatecory;
        public System.Windows.Forms.ComboBox cmbxItemName;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label edt_buy;
        public System.Windows.Forms.TextBox txtClinetName;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
    }
}