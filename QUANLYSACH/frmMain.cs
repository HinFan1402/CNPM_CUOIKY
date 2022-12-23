using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHeThong_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSach frm = new frmSach();
            frm.Show();
        }

        private void btnNXB_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaXuatBan frm= new frmNhaXuatBan();
            frm.Show();
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoaDon frm= new frmHoaDon();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDaiLy frm= new frmDaiLy();
            frm.Show();
        }
    }
}