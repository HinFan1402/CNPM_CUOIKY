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
using System.Data.Entity;
using DevExpress.Utils.Extensions;

namespace QUANLYSACH
{

    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        QLYSACHNEWEntities db; 
        public frmSach()
        {
            InitializeComponent();
        }

        private void gridData_Click(object sender, EventArgs e)
        {
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            getData();

        }
        public void getData() {
            db = new QLYSACHNEWEntities();
            tSACHBindingSource2.DataSource = db.tSACHes.ToList();
            cbxNhaXuatBan.DataSource = db.tNHAXUATBANs.ToList();
            cbxNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbxNhaXuatBan.ValueMember = "MaNhaXuatBan";
        }

        private void gridData_DoubleClick(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var TenSach = txtTenSach.Text.Trim();
            var TacGia = txtTacGia.Text.Trim();
            var GiaBan = txtGiaBan.Text.Trim();
            var GiaBanChoDaiLy = txtGiaBanDaiLy.Text.Trim();
            var MaNhaXuatBan = cbxNhaXuatBan.SelectedValue.ToString();

            if (string.IsNullOrEmpty(TenSach))
            {
                XtraMessageBox.Show("Nhập tên sách !", "Information");
                txtTenSach.Focus();
            }
            else if (string.IsNullOrEmpty(TacGia))
            {
                XtraMessageBox.Show("Nhập tên tác giả !", "Information");
                txtTenSach.Focus();
            }
            else if (string.IsNullOrEmpty(GiaBan))
            {
                XtraMessageBox.Show("Nhập giá !", "Information");
                txtTenSach.Focus();
            }
            else if (string.IsNullOrEmpty(GiaBanChoDaiLy))
            {
                XtraMessageBox.Show("Nhập giá !", "Information");
                txtTenSach.Focus();
            }
            else
            {
                tSACHBindingSource2.AddNew();
                var temp = new tSACH();
                temp.TenSach = TenSach;
                temp.TenTacGia = TacGia;
                temp.GiaBia = int.Parse(GiaBan);
                temp.GiaBanChoDaiLy = int.Parse(GiaBanChoDaiLy);
                temp.MaNhaXuatBan = int.Parse(MaNhaXuatBan);
                temp.SoTrang = null;
                db.tSACHes.Add(temp);
                db.SaveChanges();
                getData();
                frmSach_Load(sender, e);
                clear();

            }


        }
        public void clear() {
            txtGiaBan.Clear();
            txtGiaBanDaiLy.Clear();
            txtTacGia.Clear();
            txtTenSach.Clear();
            txt_MaSach.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBanDaiLy_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var TenSach = txtTenSach.Text.Trim();
            var TacGia = txtTacGia.Text.Trim();
            var GiaBan = txtGiaBan.Text.Trim();
            var GiaBanChoDaiLy = txtGiaBanDaiLy.Text.Trim();
            var MaNhaXuatBan = cbxNhaXuatBan.SelectedValue.ToString();
            if (string.IsNullOrEmpty(TenSach))
            {
                XtraMessageBox.Show("Nhập tên sách !", "Information");
                txtTenSach.Focus();
            }
            else if (string.IsNullOrEmpty(TacGia))
            {
                XtraMessageBox.Show("Nhập tên tác giả !", "Information");
                txtTenSach.Focus();
            }
            else if (string.IsNullOrEmpty(GiaBan))
            {
                XtraMessageBox.Show("Nhập giá !", "Information");
                txtTenSach.Focus();
            }
            else if (string.IsNullOrEmpty(GiaBanChoDaiLy))
            {
                XtraMessageBox.Show("Nhập giá !", "Information");
                txtTenSach.Focus();
            }
            else
            {
                int MaSach = Convert.ToInt32(txt_MaSach.Text.Trim());
                tSACH temp = db.tSACHes.FirstOrDefault(c => c.MaSach == MaSach);
                temp.TenSach = txtTenSach.Text.Trim();
                temp.TenTacGia = txtTacGia.Text.Trim().ToString();
                temp.GiaBia = int.Parse(txtGiaBan.Text.Trim());
                temp.GiaBanChoDaiLy = int.Parse(txtGiaBanDaiLy.Text.Trim());
                temp.MaNhaXuatBan = int.Parse(cbxNhaXuatBan.SelectedValue.ToString());
                temp.SoTrang = null;
                db.SaveChanges();
                getData();
                frmSach_Load(sender, e);
                clear();
            }
        }

        private void txtGiaBan_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


                int MaSach;
                MaSach= Convert.ToInt32(txt_MaSach.Text.Trim());
                tSACH temp = db.tSACHes.FirstOrDefault(c => c.MaSach == MaSach);
                temp.TenSach = txtTenSach.Text.Trim();
                temp.TenTacGia = txtTacGia.Text.Trim().ToString();
                temp.GiaBia = int.Parse(txtGiaBan.Text.Trim());
                temp.GiaBanChoDaiLy = int.Parse(txtGiaBanDaiLy.Text.Trim());
                temp.MaNhaXuatBan = int.Parse(cbxNhaXuatBan.SelectedValue.ToString());
                temp.SoTrang = null;
                db.tSACHes.Remove(temp);
                db.SaveChanges();
                getData();
                clear();
            
        }
    }
}