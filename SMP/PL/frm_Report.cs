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
using SMP.EPL;
using SMP.BL;
using DevExpress.XtraReports.UI;

namespace SMP.PL
{
    public partial class frm_Report : Form
    {
        
        public frm_Report()
        {
            InitializeComponent();
          

        }

        private void btn_salesReport_Click(object sender, EventArgs e)
        {
            SalesReport report = new SalesReport();
            report.ShowPreview();

        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
          PurchasesReport report = new PurchasesReport();
            report.ShowPreview();
        }
    }
}
