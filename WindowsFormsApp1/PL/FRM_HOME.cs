using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace WindowsFormsApp1.PL
{
    public partial class FRM_HOME : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        public FRM_HOME()
        {
            InitializeComponent();

            List<TB_CAT> listCat = db.TB_CAT.ToList();
            lb_cat.Text = listCat.Count.ToString();


            List<TB_CUS> listCus = db.TB_CUS.ToList();
            lb_cus.Text = listCus.Count.ToString(); 


            List<TB_PUR> listpur = db.TB_PUR.ToList();  
            lb_pur.Text = listpur.Count.ToString();


            List<TB_SELL> listsell = db.TB_SELL.ToList();
            lb_sell.Text = listsell.Count.ToString();   


            List<TB_SUPP> listsupp = db.TB_SUPP.ToList();
            lb_supp.Text = listsupp.Count.ToString();   


           

        }

        public void UpdateRecordCount()
        {
            // كود تحديث العدادات هنا (يمكن نسخ الكود الذي قمت بكتابته سابقًا)
            DB_SMPEntities db = new DB_SMPEntities();
            lb_cat.Text = db.TB_CAT.Count().ToString();
            lb_cus.Text = db.TB_CUS.Count().ToString();
            lb_pur.Text = db.TB_PUR.Count().ToString();
            lb_sell.Text = db.TB_SELL.Count().ToString();
            lb_supp.Text = db.TB_SUPP.Count().ToString();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";

            DialogResult result = frm_add.ShowDialog();
            if (result == DialogResult.OK)
            {
                // القيام بتحديث عدد السجلات بعد إضافة أو تحديث الفئة
                UpdateRecordCount();
            }
        }

        private void btn_supp_Click(object sender, EventArgs e)
        {
            FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
            PL.FRM_PUR_ADD frm_add = new PL.FRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";

            frm_add.Show();
        }

        private void btn_cus_Click(object sender, EventArgs e)
        {
            FRM_CUS_ADD frm_add = new FRM_CUS_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            FRM_CUS_ADD frm_add = new FRM_CUS_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }
    }
}
