using DevExpress.XtraGrid; // استيراد مكتبة DevExpress للتعامل مع شبكات البيانات
using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Data.Entity; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; // استيراد مكتبة واجهة المستخدم الرسومية
using WindowsFormsApp1.EPL; // استيراد مسار النماذج والكلاسات المخصصة للتطبيق

namespace WindowsFormsApp1.PL // البداية في تعريف مساحة الأسماء الخاصة بهذا النموذج
{
    public partial class FRM_CAT_ADD : Form // بداية تعريف النموذج لإضافة أو تعديل الأصناف
    {
        // تهيئة المتغيرات والكائنات اللازمة لهذا النموذج
        DB_SMPEntities db = new DB_SMPEntities(); // كائن قاعدة البيانات
        TB_CAT tb_cat = new TB_CAT(); // كائن يُمثل الصنف المراد إضافته أو تعديله
        BL.Methods methods = new BL.Methods(); // كائن لمكتبة الوظائف الخاصة بالتطبيق
        FRM_CAT frm_cat = new FRM_CAT(); // نموذج الصفحة الرئيسية للأصناف

        public int id; // معرف الصنف المراد تعديله (0 إذا كانت عملية إضافة جديدة)

        public FRM_CAT_ADD()
        {
            InitializeComponent(); // تهيئة واجهة المستخدم
        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {
           
        }

        // الزر المستخدم للإضافة أو التعديل
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast(); // إنشاء كائن لعرض رسائل الإعلام
            Dialog dialog = new Dialog(); // إنشاء كائن لعرض مربع حوار

            // التحقق من ملء حقل اسم الصنف
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف مطلوب";
                dialog.Show();
            }// نهاية التحقق
            else
            { // التحقق من إجراء إضافة أو تعديل
                if (id == 0)
                {
                    // عملية إضافة جديدة

                    
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);  // حفظ صورة غلاف الصنف واسمه في قاعدة البيانات                   
                    tb_cat.CAT_Name = edt_name.Text;   // تعيين اسم الصنف من مربع النص                      
                    tb_cat.CAT_Cover = methods.Convert_byte();  // تحويل الصورة إلى مصفوفة بايتات وتعيينها في كائن الصنف
                    db.TB_CAT.Add(tb_cat);// إضافة  الصنف الجديد إلى مجموعة الأصناف في قاعدة البيانات


                    // حفظ التغييرات في قاعدة البيانات
                    db.SaveChanges();
                    toast.lbl_caption.Text = "تم اضافة عنصر جديد";


                    // تحديث قائمة الأصناف في الصفحة الرئيسية
                    db = new DB_SMPEntities();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // عملية تعديل

                    
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);  // حفظ صورة غلاف الصنف وتحديث معلوماته في قاعدة البيانات
                    tb_cat.CAT_Name = edt_name.Text;  // تعيين اسم الصنف من مربع النص إلى كائن الصنف
                    tb_cat.ID = id;  // تعيين معرف الصنف المراد تعديله
                    tb_cat.CAT_Cover = methods.Convert_byte();  // تحويل الصورة إلى مصفوفة بايتات وتعيينها في كائن الصنف



                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;  // تحديث حالة الكائن لتعبئة المعلومات المعدلة في قاعدة البيانات
                   
                    
                    
                    db.SaveChanges();  // حفظ التغييرات في قاعدة البيانات
                    toast.lbl_caption.Text = "تم تعديل العنصر ";

                    // تحديث قائمة الأصناف في الصفحة الرئيسية
                    db = new DB_SMPEntities();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    toast.Show();
                    this.Close();
                }
            }
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
           
        }

        private void pn_close_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق نموذج إضافة/تعديل الصنف
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }

        // اختيار صورة لغلاف الصنف
        private void pic_cover_Click(object sender, EventArgs e)
        {
           add_Image();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_Image();
        }


        private  void add_Image()
        {
            openFileDialog1.Filter = "Images Files|*.jpg;*.png|All Files|*.*"; // تحديد أنواع الملفات المسموح بها للاختيار (jpg و png)
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // إذا تم اختيار ملف وتم الضغط على زر "موافق" في مربع حوار الاختيار
            {
                pic_cover.Image = Image.FromFile(openFileDialog1.FileName); // تحميل الصورة المختارة من الملف وعرضها في عنصر الصورة (pic_cover)
            }
        }

      
    }
}
