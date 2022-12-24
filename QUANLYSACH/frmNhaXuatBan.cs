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
    public partial class frmNhaXuatBan : DevExpress.XtraEditors.DirectXForm
    {
        QLYSACHNEWEntities db = new QLYSACHNEWEntities();
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            tNHAXUATBANBindingSource1.DataSource = db.tNHAXUATBANs.ToList();

        }
    }
}