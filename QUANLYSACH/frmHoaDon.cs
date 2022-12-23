using DevExpress.XtraEditors;
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
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        QLYSACHNEWEntities db = new QLYSACHNEWEntities();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            tHOADONBindingSource3.DataSource = db.tHOADONs.ToList();
        }

        private void menuThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}