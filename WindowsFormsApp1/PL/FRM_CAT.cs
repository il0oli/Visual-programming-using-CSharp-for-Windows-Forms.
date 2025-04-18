using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms; 
using System.Data.Entity; // استيراد مكتبة Entity Framework للعمل مع قاعدة البيانات
using WindowsFormsApp1.EPL; // استيراد مسار النماذج والكلاسات المخصصة للتطبيق



namespace WindowsFormsApp1.PL // البداية في تعريف مساحة الأسماء الخاصة بهذا النموذج
{
    public partial class FRM_CAT : Form // بداية تعريف النموذج الرئيسي لإدارة الأصناف
    {
        DB_SMPEntities db = new DB_SMPEntities(); // إنشاء كائن للاتصال بقاعدة البيانات
        TB_CAT tb_cat = new TB_CAT(); // إنشاء كائن لتمثيل بيانات الصنف المعالج
        BL.Methods methods = new BL.Methods(); // إنشاء كائن لاستخدام وظائف مكتبة الأعمال

        public int id; // إعلان متغير لتخزين معرف الصنف المحدد

        public FRM_CAT() // بداية تعريف الدالة الرئيسية للنموذج
        {
            InitializeComponent(); // استدعاء دالة تهيئة واجهة المستخدم

            // إعداد وعرض البيانات في الشبكة أو الجدول
            WindowsFormsApp1.DB_SMPEntities dbContext = new WindowsFormsApp1.DB_SMPEntities(); // إنشاء كائن لقاعدة البيانات
            dbContext.TB_CAT.Load(); // تحميل بيانات الأصناف من قاعدة البيانات
            gridControl1.DataSource = dbContext.TB_CAT.Local.ToBindingList(); // عرض البيانات في الجدول
        } // نهاية تعريف الدالة الرئيسية

        private void simpleButton3_Click(object sender, EventArgs e) 
        {
           
        } 

        private void simpleButton4_Click(object sender, EventArgs e) 
        {
           
        } 

        private void btn_add_Click(object sender, EventArgs e) 
        {
            // فتح نموذج إضافة صنف جديد وتعيين قيمة id إلى صفر ونص الزر إلى "اضافة"
            FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        } // نهاية تعريف الدالة

        // بداية تعريف الدالة المرتبطة بزرار تحديث البيانات
        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data(); // استدعاء دالة تحديث البيانات
        } // نهاية تعريف الدالة

        private void btn_delete_Click(object sender, EventArgs e) // بداية تعريف الدالة المرتبطة بزرار حذف صنف
        {
            Toast toast = new Toast(); // إنشاء كائن لعرض رسائل الإعلام
            Dialog dialog = new Dialog(); // إنشاء كائن لعرض مربع حوار

            try // بداية تعريف كتلة للتعامل مع الأخطاء الممكنة
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID")); // الحصول على معرف الصنف المحدد
                var result = MessageBox.Show("عملية حذف", "هل تريد حذف العنصر ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question); // عرض مربع حوار للتأكيد على الحذف
                if (result == DialogResult.Yes) // إذا تم النقر على نعم في مربع الحوار
                {
                    tb_cat = db.TB_CAT.Where(x => x.ID == id).FirstOrDefault(); // البحث عن الصنف المحدد في قاعدة البيانات
                    db.Entry(tb_cat).State = EntityState.Deleted; // تمييز الصنف للحذف
                    db.SaveChanges(); // حفظ التغييرات في قاعدة البيانات
                    update_data(); // تحديث البيانات في الجدول
                    toast.lbl_caption.Text = "تم عملية الحذف بنجاح"; // عرض رسالة نجاح
                    toast.Show(); // عرض الرسالة
                }
                else // إذا تم النقر على لا في مربع الحوار
                {
                    toast.lbl_caption.Text = "تم الغاء عملية الحذف"; // عرض رسالة إلغاء
                    toast.Show(); // عرض الرسالة
                }
            }
            catch
            {
                dialog.txt_caption.Text = "لا يوجد عنصر لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }
        } // نهاية تعريف الدالة

        private void update_data() // بداية تعريف دالة تحديث البيانات في الجدول
        {
            db = new DB_SMPEntities(); // إعادة تهيئة كائن قاعدة البيانات
            gridControl1.DataSource = db.TB_CAT.ToList(); // تحميل البيانات الجديدة في الجدول
        } // نهاية تعريف الدالة

        private void btn_edit_Click(object sender, EventArgs e) // بداية تعريف الدالة المرتبطة بزرار تعديل صنف
        {
            // فتح نموذج تعديل الصنف المحدد وملء البيانات من السجل المحدد
            PL.FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID")); // الحصول على معرف الصنف المحدد
            tb_cat = db.TB_CAT.Where(x => x.ID == id).FirstOrDefault(); // البحث عن الصنف المحدد في قاعدة البيانات
            frm_add.edt_name.Text = tb_cat.CAT_Name.ToString(); // ملء حقل اسم الصنف

            methods.by = tb_cat.CAT_Cover; // تعيين البيانات الخاصة بالصورة
            frm_add.pic_cover.Image = Image.FromStream(methods.Convert_image()); // تعيين الصورة

            frm_add.id = id; // تعيين معرف الصنف المحدد
            frm_add.btn_add.Text = "تعديل"; // تعيين نص الزر إلى "تعديل"
            frm_add.Show(); // فتح نموذج التعديل
        } // نهاية تعريف الدالة

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }


        private void PerformSearch()
        {
            var _search = edt_search.Text;
            // نقوم بـ فلتر جلب البيانات بشكل مباشر  
            gridControl1.DataSource = db.TB_CAT.Where(x => x.CAT_Name.Contains(_search)).ToList();
        }

        private void edt_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edt_search.Text))
            {
                edt_search.Text = "بحث";
                edt_search.ForeColor = Color.Gray;
                gridControl1.DataSource = db.TB_CAT.ToList();
            }
        }

        private void edt_search_Enter(object sender, EventArgs e)
        {
            if (edt_search.Text == "بحث")
            {
                edt_search.Text = "";
                edt_search.ForeColor = Color.Black;
            }
        }

        private void edt_search_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}
