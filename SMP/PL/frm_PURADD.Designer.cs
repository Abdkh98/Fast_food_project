namespace SMP.PL
{
    partial class frm_PURADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PURADD));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lnklblAddSupplier = new System.Windows.Forms.LinkLabel();
            this.lnklblAddCatecory = new System.Windows.Forms.LinkLabel();
            this.cmbxSuppliers = new System.Windows.Forms.ComboBox();
            this.cmbxCategory = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.edt_buy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edt_trev = new System.Windows.Forms.Label();
            this.edt_tsell = new System.Windows.Forms.Label();
            this.edt_tbuy = new System.Windows.Forms.Label();
            this.lblTotalEarnings = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Controls.Add(this.lnklblAddSupplier);
            this.groupBox1.Controls.Add(this.lnklblAddCatecory);
            this.groupBox1.Controls.Add(this.cmbxSuppliers);
            this.groupBox1.Controls.Add(this.cmbxCategory);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(584, 306);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background Information";
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetails.Font = new System.Drawing.Font("A Jannat LT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(137, 220);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(425, 58);
            this.txtDetails.TabIndex = 12;
            // 
            // lnklblAddSupplier
            // 
            this.lnklblAddSupplier.AutoSize = true;
            this.lnklblAddSupplier.Location = new System.Drawing.Point(239, 178);
            this.lnklblAddSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblAddSupplier.Name = "lnklblAddSupplier";
            this.lnklblAddSupplier.Size = new System.Drawing.Size(42, 29);
            this.lnklblAddSupplier.TabIndex = 11;
            this.lnklblAddSupplier.TabStop = true;
            this.lnklblAddSupplier.Text = "Add";
            this.lnklblAddSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAddSupplier_LinkClicked);
            // 
            // lnklblAddCatecory
            // 
            this.lnklblAddCatecory.AutoSize = true;
            this.lnklblAddCatecory.Location = new System.Drawing.Point(239, 122);
            this.lnklblAddCatecory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblAddCatecory.Name = "lnklblAddCatecory";
            this.lnklblAddCatecory.Size = new System.Drawing.Size(42, 29);
            this.lnklblAddCatecory.TabIndex = 10;
            this.lnklblAddCatecory.TabStop = true;
            this.lnklblAddCatecory.Text = "Add";
            this.lnklblAddCatecory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAddCatecory_LinkClicked);
            // 
            // cmbxSuppliers
            // 
            this.cmbxSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSuppliers.FormattingEnabled = true;
            this.cmbxSuppliers.Location = new System.Drawing.Point(299, 178);
            this.cmbxSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxSuppliers.Name = "cmbxSuppliers";
            this.cmbxSuppliers.Size = new System.Drawing.Size(263, 24);
            this.cmbxSuppliers.TabIndex = 8;
            // 
            // cmbxCategory
            // 
            this.cmbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCategory.FormattingEnabled = true;
            this.cmbxCategory.Location = new System.Drawing.Point(299, 129);
            this.cmbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxCategory.Name = "cmbxCategory";
            this.cmbxCategory.Size = new System.Drawing.Size(263, 24);
            this.cmbxCategory.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(299, 81);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(263, 22);
            this.txtType.TabIndex = 6;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(299, 33);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(263, 22);
            this.txtItemName.TabIndex = 5;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(25, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(25, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type ";
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
            this.groupBox2.Controls.Add(this.edt_sell);
            this.groupBox2.Controls.Add(this.edt_buy);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 329);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(584, 199);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buying And Selling";
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.Location = new System.Drawing.Point(295, 124);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt.Properties.Appearance.Options.UseFont = true;
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Size = new System.Drawing.Size(263, 22);
            this.edt_qt.TabIndex = 13;
            this.edt_qt.EditValueChanged += new System.EventHandler(this.edt_qt_EditValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(25, 120);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Quantity";
            // 
            // edt_sell
            // 
            this.edt_sell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sell.Location = new System.Drawing.Point(295, 76);
            this.edt_sell.Margin = new System.Windows.Forms.Padding(4);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(263, 22);
            this.edt_sell.TabIndex = 10;
            this.edt_sell.Text = "0";
            this.edt_sell.TextChanged += new System.EventHandler(this.edt_buy_TextChanged);
            // 
            // edt_buy
            // 
            this.edt_buy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buy.Location = new System.Drawing.Point(295, 34);
            this.edt_buy.Margin = new System.Windows.Forms.Padding(4);
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Size = new System.Drawing.Size(263, 22);
            this.edt_buy.TabIndex = 9;
            this.edt_buy.Text = "0";
            this.edt_buy.TextChanged += new System.EventHandler(this.edt_sell_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(25, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Selling Price(Single)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(25, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "Purching price(Single)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edt_trev);
            this.groupBox3.Controls.Add(this.edt_tsell);
            this.groupBox3.Controls.Add(this.edt_tbuy);
            this.groupBox3.Controls.Add(this.lblTotalEarnings);
            this.groupBox3.Controls.Add(this.lblSales);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("A Jannat LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(647, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(332, 306);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // edt_trev
            // 
            this.edt_trev.AutoSize = true;
            this.edt_trev.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_trev.ForeColor = System.Drawing.Color.Blue;
            this.edt_trev.Location = new System.Drawing.Point(148, 244);
            this.edt_trev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edt_trev.Name = "edt_trev";
            this.edt_trev.Size = new System.Drawing.Size(27, 35);
            this.edt_trev.TabIndex = 5;
            this.edt_trev.Text = "0";
            // 
            // edt_tsell
            // 
            this.edt_tsell.AutoSize = true;
            this.edt_tsell.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tsell.ForeColor = System.Drawing.Color.Blue;
            this.edt_tsell.Location = new System.Drawing.Point(148, 155);
            this.edt_tsell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edt_tsell.Name = "edt_tsell";
            this.edt_tsell.Size = new System.Drawing.Size(27, 35);
            this.edt_tsell.TabIndex = 4;
            this.edt_tsell.Text = "0";
            // 
            // edt_tbuy
            // 
            this.edt_tbuy.AutoSize = true;
            this.edt_tbuy.Font = new System.Drawing.Font("A Jannat LT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tbuy.ForeColor = System.Drawing.Color.Blue;
            this.edt_tbuy.Location = new System.Drawing.Point(148, 66);
            this.edt_tbuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.edt_tbuy.Name = "edt_tbuy";
            this.edt_tbuy.Size = new System.Drawing.Size(27, 35);
            this.edt_tbuy.TabIndex = 3;
            this.edt_tbuy.Text = "0";
            // 
            // lblTotalEarnings
            // 
            this.lblTotalEarnings.AutoSize = true;
            this.lblTotalEarnings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalEarnings.Location = new System.Drawing.Point(92, 209);
            this.lblTotalEarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEarnings.Name = "lblTotalEarnings";
            this.lblTotalEarnings.Size = new System.Drawing.Size(110, 29);
            this.lblTotalEarnings.TabIndex = 2;
            this.lblTotalEarnings.Text = "Total Earnings";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSales.Location = new System.Drawing.Point(77, 117);
            this.lblSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(132, 29);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "Sales(Total Price)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(56, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Purchases(Total Price)";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("A Jannat LT", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(16, 535);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 74);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add ";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // frm_PURADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 616);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PURADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frm_PURADD_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label edt_trev;
        public System.Windows.Forms.Label edt_tsell;
        public System.Windows.Forms.Label edt_tbuy;
        public System.Windows.Forms.Label lblTotalEarnings;
        public System.Windows.Forms.Label lblSales;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox edt_sell;
        public System.Windows.Forms.TextBox edt_buy;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtDetails;
        public System.Windows.Forms.LinkLabel lnklblAddSupplier;
        public System.Windows.Forms.LinkLabel lnklblAddCatecory;
        public System.Windows.Forms.ComboBox cmbxSuppliers;
        public System.Windows.Forms.ComboBox cmbxCategory;
        public System.Windows.Forms.TextBox txtType;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
    }
}