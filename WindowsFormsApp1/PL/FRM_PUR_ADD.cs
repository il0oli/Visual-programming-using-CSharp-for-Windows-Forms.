using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraGrid; // استيراد مكتبة DevExpress للتعامل مع شبكات البيانات
using System; // استيراد مكتبة System الأساسية
using System.Collections.Generic; // استيراد مكتبة القوائم الجينيريك
using System.ComponentModel; // استيراد مكتبة التصميم والواجهة الرسومية
using System.Data; // استيراد مكتبة البيانات
using System.Data.Entity; // استيراد مكتبة Entity Framework للعمل مع قاعدة البيانات
using System.Drawing; // استيراد مكتبة الرسومات
using System.Linq; // استيراد مكتبة لينك كيو آل
using System.Text; // استيراد مكتبة النصوص
using System.Threading.Tasks; // استيراد مكتبة المهام المتعددة
using System.Web.UI;
using System.Windows.Forms; // استيراد مكتبة واجهة المستخدم الرسومية
using WindowsFormsApp1.BL;
using WindowsFormsApp1.EPL; // استيراد مسار النماذج والكلاسات المخصصة للتطبيق

namespace WindowsFormsApp1.PL // بداية تعريف مساحة الأسماء الخاصة بهذا النموذج
{
    public partial class FRM_PUR_ADD : Form // بداية تعريف النموذج لإضافة أو تعديل الموردين
    {
        // تهيئة المتغيرات والكائنات اللازمة لهذا النموذج
        DB_SMPEntities db = new DB_SMPEntities(); // كائن قاعدة البيانات
      TB_PUR tb_pur = new TB_PUR(); 
        BL.Methods methods = new BL.Methods(); // كائن لمكتبة الوظائف الخاصة بالتطبيق
        double buy, sell, qt, tbuy, tsell, trev;

        public string c1, c2;
        public int id; // معرف المورد المراد تعديله (0 إذا كانت عملية إضافة جديدة)

        private YourRepository repository;


        private Color borderColor = Color.SteelBlue;
        private int borderWidth = 5;
        public FRM_PUR_ADD ()
        {
            InitializeComponent(); // تهيئة واجهة المستخدم
            repository = new YourRepository();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // رسم الحاشية الخارجية للنافذة باللون المحدد
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }

        // الزر المستخدم للإضافة أو التعديل
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast(); // إنشاء كائن لعرض رسائل الإعلام
            Dialog dialog = new Dialog(); // إنشاء كائن لعرض مربع حوار

            // التحقق من ملء حقل اسم المورد
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم المورد مطلوب";
                dialog.Show();
            }// نهاية التحقق
           
            else
            { // التحقق من إجراء إضافة أو تعديل
                if (id == 0)
                {
                    // عملية إضافة جديدة

                   tb_pur.Pur_Name = edt_name.Text;
                   tb_pur.Pur_Type = edt_type.Text; 
                   tb_pur.Pur_Cat = edt_cat.Text;
                   tb_pur.Pur_Supp = edt_supp.Text;
                   tb_pur.Pur_Det = edt_det.Text;

                    tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                    tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                    tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                    tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                    tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                    tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);



                 
                    db.TB_PUR.Add(tb_pur);

                    // حفظ التغييرات في قاعدة البيانات
                    db.SaveChanges();
                    toast.lbl_caption.Text = "تم اجراء عملية شراء";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // عملية تعديل

                    try
                    {

                        tb_pur.ID = id;

                        
                        tb_pur.Pur_Name = edt_name.Text;
                        tb_pur.Pur_Type = edt_type.Text;
                        tb_pur.Pur_Cat = edt_cat.Text;
                        tb_pur.Pur_Supp = edt_supp.Text;
                        tb_pur.Pur_Det = edt_det.Text;

                        tb_pur.Pur_Buy = Convert.ToDouble(edt_buy.Text);
                        tb_pur.Pur_Sell = Convert.ToDouble(edt_sell.Text);
                       
                        tb_pur.Pur_Qt = Convert.ToDouble(edt_qt.Text);
                        tb_pur.Pur_Tbuy = Convert.ToDouble(edt_tbuy.Text);
                        tb_pur.Pur_Tsell = Convert.ToDouble(edt_tsell.Text);
                        tb_pur.Pur_TRev = Convert.ToDouble(edt_trev.Text);

                        db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;   

                        // حفظ التغييرات في قاعدة البيانات
                        db.SaveChanges();
                        toast.lbl_caption.Text = "تم تعديل عملية شراء ";
                        toast.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {

                        toast.lbl_caption.Text = "حصل خطأ "+ex;
                        edt_det.Text = ex.Message;
                        toast.Show();
                    }
                }
            }
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
            //var purObject = db.TB_PUR.FirstOrDefault(p => p.ID == id);

            //if (purObject != null)
            //{
            //    // عرض القيمة في ComboBox
            //    edt_supp.Text = purObject.Pur_Supp; // استبدل edt_name بالاسم الصحيح لحقل الاسم في واجهة المستخدم
            //}

            //var purObject1 = db.TB_PUR.FirstOrDefault(p => p.ID == id);

            //if (purObject != null)
            //{
            //    // عرض القيمة في ComboBox
            //    edt_cat.Text = purObject1.Pur_Cat; // استبدل edt_name بالاسم الصحيح لحقل الاسم في واجهة المستخدم
            //}

           
        }

        private void pn_close_Click(object sender, EventArgs e)
        {
          
            this.Close(); // إغلاق نموذج إضافة/تعديل المورد
           
        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
           
            pru_cul();
        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pru_cul();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pru_cul();
        }

        

      

     

        private void edt_sell_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(edt_sell, "ادخل سعر البيع");
        }

        private void edt_sell_Leave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(edt_sell, "");
        }

        private void edt_buy_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(edt_buy, "ادخل سعر الشراء");
        }

        private void edt_buy_Leave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(edt_buy, "");
        }

        private void edt_det_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(edt_det, "تفاصيل عملية البيع والشراء ");
        }

        private void edt_det_Leave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(edt_det, "");
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }


        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            edt_cat.DataSource = db.TB_CAT.Select(x => x.CAT_Name).ToList();
            edt_supp.DataSource = db.TB_SUPP.Select(x => x.Supp_Name).ToList(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_SUPP_ADD frm_add = new FRM_SUPP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void pru_cul()
        {

            try
            {
                try
                {
                    sell = Convert.ToDouble(edt_sell.Text);
                    buy = Convert.ToDouble(edt_buy.Text);
                    qt = Convert.ToDouble(edt_qt.Value);

                    tsell = sell * qt;
                    tbuy = buy * qt;
                    trev = tsell - tbuy;

                    edt_tsell.Text = tsell.ToString();
                    edt_tbuy.Text = tbuy.ToString();
                    edt_trev.Text = trev.ToString();
                }
                catch
                {
                    

                }
            }
            catch (FormatException ex)
            {

                Dialog dialog = new Dialog();
                dialog.txt_caption.Text = "قم بادخال قيمة "+ex;
                dialog.Show();
            }
        }



    }
}
