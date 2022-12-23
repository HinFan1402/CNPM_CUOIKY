using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSACH
{
    public partial class frmDaiLy : DevExpress.XtraEditors.XtraForm
    {
        QLYSACHNEWEntities db = new QLYSACHNEWEntities();
        public frmDaiLy()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            tDAILYBindingSource1.DataSource= db.tDAILies.ToList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReport frm = new frmReport();
            frm.CreateDocument();
            frm.ShowPreview();
        }
    }
}