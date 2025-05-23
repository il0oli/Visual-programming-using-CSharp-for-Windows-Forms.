﻿using System; // استيراد مكتبة System
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

namespace WindowsFormsApp1.PL // البداية في تعريف مساحة الأسماء الخاصة بهذا النموذج
{
    public partial class FRM_PUR : Form // بداية تعريف النموذج الرئيسي لإدارة الأصناف
    {
        DB_SMPEntities db = new DB_SMPEntities(); // إنشاء كائن للاتصال بقاعدة البيانات
        TB_PUR tb_pur = new TB_PUR();
        BL.Methods methods = new BL.Methods(); // إنشاء كائن لاستخدام وظائف مكتبة الأعمال

        public int id; // إعلان متغير لتخزين معرف الصنف المحدد

        public FRM_PUR() // بداية تعريف الدالة الرئيسية للنموذج
        {
            InitializeComponent(); // استدعاء دالة تهيئة واجهة المستخدم

            
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            WindowsFormsApp1.DB_SMPEntities dbContext = new WindowsFormsApp1.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_PUR.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_PUR.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        } // نهاية تعريف الدالة الرئيسية

        private void simpleButton3_Click(object sender, EventArgs e) // بداية تعريف الدالة المرتبطة بزرار غير مستخدم
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e) // بداية تعريف الدالة المرتبطة بزرار غير مستخدم
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          
          
            // فتح نموذج إضافة مورد جديد وتعيين قيمة id إلى صفر ونص الزر إلى "اضافة"
            PL.FRM_PUR_ADD frm_add = new PL.FRM_PUR_ADD(); 
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
           
            frm_add.Show();

            
           

        } // نهاية تعريف الدالة

        // بداية تعريف الدالة المرتبطة بزرار تحديث البيانات
        private void btn_update_Click(object sender, EventArgs e)
        {
            edt_search.Text = "بحث";
            edt_search.ForeColor = Color.Gray;
            update_data(); // استدعاء دالة تحديث البيانات
        } // نهاية تعريف الدالة

        private void btn_delete_Click(object sender, EventArgs e) // بداية تعريف الدالة المرتبطة بزرار حذف مورد
        {
            Toast toast = new Toast(); // إنشاء كائن لعرض رسائل الإعلام
            Dialog dialog = new Dialog(); // إنشاء كائن لعرض مربع حوار
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")); // الحصول على معرف المورد المحدد

            if (id > 0)
            {

                try // بداية تعريف كتلة للتعامل مع الأخطاء الممكنة
                {

                    var result = MessageBox.Show("عملية حذف", "هل تريد حذف عملية الشراء ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question); // عرض مربع حوار للتأكيد على الحذف
                    if (result == DialogResult.Yes) // إذا تم النقر على نعم في مربع الحوار
                    {
                        tb_pur = db.TB_PUR.Where(x => x.ID == id).FirstOrDefault(); // البحث عن المورد المحدد في قاعدة البيانات
                        db.Entry(tb_pur).State = EntityState.Deleted; // تمييز المورد للحذف
                        db.SaveChanges(); // حفظ التغييرات في قاعدة البيانات
                        
                        toast.lbl_caption.Text = "تمت عملية الحذف بنجاح"; // عرض رسالة نجاح
                        toast.Show(); // عرض الرسالة
                        update_data(); // تحديث البيانات في الجدول
                    }
                    else // إذا تم النقر على لا في مربع الحوار
                    {
                        toast.lbl_caption.Text = "تم إلغاء عملية الحذف"; // عرض رسالة إلغاء
                        toast.Show(); // عرض الرسالة
                    }
                }
                catch
                {
                    dialog.txt_caption.Text = "لا توجد عملية شراء للحذف ";
                    dialog.Width = this.Width;
                    dialog.Show();
                }
            }
            else
            {
                dialog.txt_caption.Text = "لا توجد عملية شراء للحذف ";
                dialog.Width = this.Width;
                dialog.Show();
            }
           

        } // نهاية تعريف الدالة

        private void update_data() // بداية تعريف دالة تحديث البيانات في الجدول
        {
            db = new DB_SMPEntities(); // إعادة تهيئة كائن قاعدة البيانات
            gridControl1.DataSource = db.TB_PUR.ToList(); // تحميل البيانات الجديدة في الجدول
            
        } // نهاية تعريف الدالة

        private void btn_edit_Click(object sender, EventArgs e) // بداية تعريف الدالة المرتبطة بزرار تعديل مورد
        {
            try
            {

                // فتح نموذج تعديل المورد المحدد وملء البيانات من السجل المحدد
                PL.FRM_PUR_ADD frm_add = new PL.FRM_PUR_ADD();
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")); // الحصول على معرف المورد المحدد
                tb_pur = db.TB_PUR.Where(x => x.ID == id).FirstOrDefault();

               
                frm_add.edt_name.Text = tb_pur.Pur_Name;
                frm_add.edt_type.Text = tb_pur.Pur_Type;
                frm_add.edt_cat.Text = tb_pur.Pur_Cat;
                frm_add.edt_supp.Text = tb_pur.Pur_Supp;
                frm_add.edt_det.Text = tb_pur.Pur_Det;

               
                frm_add.edt_buy.Text = tb_pur.Pur_Buy.ToString();
                frm_add.edt_sell.Text = tb_pur.Pur_Sell.ToString();
                frm_add.edt_qt.Text = tb_pur.Pur_Qt.ToString();
                frm_add.edt_tsell.Text = tb_pur.Pur_Tsell.ToString();
                frm_add.edt_tbuy.Text = tb_pur.Pur_Tbuy.ToString();

                frm_add.edt_trev.Text = tb_pur.Pur_TRev.ToString();
               
                frm_add.id = id; // تعيين معرف المورد المحدد
                frm_add.c1 = tb_pur.Pur_Cat;
                frm_add.c2 = tb_pur.Pur_Supp;   
                frm_add.btn_add.Text = "تعديل"; // تعيين نص الزر إلى "تعديل"
                 
                frm_add.Show(); // فتح نموذج التعديل
            }
            catch 
            {
                Dialog dialog = new Dialog();
                dialog.txt_caption.Text = "قم بادخال قيمة ";
                dialog.Show();

            }
        } // نهاية تعريف الدالة

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edt_search.Text;
            // نقوم بفلتر جلب البيانات بشكل مباشر  
            gridControl1.DataSource = db.TB_PUR.Where(x => x.Pur_Name.Contains(_search)).ToList();
        }

        private void edt_search_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

      

       

        private void edt_search_Enter(object sender, EventArgs e)
        {
            if(edt_search.Text == "بحث")
            {
                edt_search.Text = "";
                edt_search.ForeColor = Color.Black;
            }
        }

        private void edt_search_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edt_search.Text))
            {
                edt_search.Text = "بحث";
                edt_search.ForeColor = Color.Gray;
                gridControl1.DataSource = db.TB_PUR.ToList();
            }
        }

        private void PerformSearch()
        {
            var _search = edt_search.Text;
            // نقوم بفلتر جلب البيانات بشكل مباشر  
            gridControl1.DataSource = db.TB_PUR
                .Where(x => x.Pur_Name.Contains(_search) || x.Pur_Supp.Contains(_search)|| x.Pur_Supp.Contains(_search)
                || x.Pur_Cat.Contains(_search)|| x.Pur_Buy.ToString().Contains(_search) || x.Pur_Sell.ToString().Contains(_search)
                || x.Pur_Tbuy.ToString().Contains(_search)|| x.Pur_Tsell.ToString().Contains(_search)
                || x.Pur_TRev.ToString().Contains(_search) || x.Pur_Type.Contains(_search))
                .ToList();
        }
    }
}
