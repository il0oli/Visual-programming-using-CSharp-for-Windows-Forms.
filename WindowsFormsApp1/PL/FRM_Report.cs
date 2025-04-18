using System; // استيراد مكتبة System
using System.Collections.Generic; // استيراد مكتبة القوائم الجينيريك
using System.ComponentModel; // استيراد مكتبة التصميم والواجهة الرسومية
using System.Data; // استيراد مكتبة البيانات
using System.Drawing; // استيراد مكتبة الرسومات
using System.Linq; // استيراد مكتبة لينك كيو آل
using System.Text; // استيراد مكتبة النصوص
using System.Threading.Tasks; // استيراد مكتبة المهام المتعددة
using System.Windows.Forms; // استيراد مكتبة واجهة المستخدم الرسومية
using System.Data.Entity; // استيراد مكتبة Entity Framework للعمل مع قاعدة البيانات
using WindowsFormsApp1.EPL; // استيراد مسار النماذج والكلاسات المخصصة للتطبيق
using DevExpress.XtraReports.UI;

namespace WindowsFormsApp1.PL // البداية في تعريف مساحة الأسماء الخاصة بهذا النموذج
{
    public partial class FRM_Report : Form // بداية تعريف النموذج الرئيسي لإدارة الأصناف
    {
        public FRM_Report() // بداية تعريف الدالة الرئيسية للنموذج
        {
            InitializeComponent();
        } // نهاية تعريف الدالة الرئيسية

     

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Re_supp_Click(object sender, EventArgs e)
        {
            PL.CusReport suppReport = new PL.CusReport();
            suppReport.ShowPreview();

        }

        private void Re_cus_Click(object sender, EventArgs e)
        {
            PL.CusReport cusReport = new PL.CusReport();
            cusReport.ShowPreview();

        }

        private void Re_pur_Click(object sender, EventArgs e)
        {
            PL.purReport prReport = new PL.purReport();
            prReport.ShowPreview();
        }

        private void Re_sell_Click(object sender, EventArgs e)
        {

             PL.XtraReport1 report = new PL.XtraReport1();
            report.ShowPreview();
        }
    }
}
