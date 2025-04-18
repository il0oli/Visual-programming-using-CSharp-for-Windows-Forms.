﻿using DevExpress.XtraGrid; // استيراد مكتبة DevExpress للتعامل مع شبكات البيانات
using System; // استيراد مكتبة System الأساسية
using System.Collections.Generic; // استيراد مكتبة القوائم الجينيريك
using System.ComponentModel; // استيراد مكتبة التصميم والواجهة الرسومية
using System.Data; // استيراد مكتبة البيانات
using System.Data.Entity; // استيراد مكتبة Entity Framework للعمل مع قاعدة البيانات
using System.Drawing; // استيراد مكتبة الرسومات
using System.Linq; // استيراد مكتبة لينك كيو آل
using System.Net.Mail;
using System.Text; // استيراد مكتبة النصوص
using System.Text.RegularExpressions;
using System.Threading.Tasks; // استيراد مكتبة المهام المتعددة
using System.Windows.Forms; // استيراد مكتبة واجهة المستخدم الرسومية
using WindowsFormsApp1.EPL; // استيراد مسار النماذج والكلاسات المخصصة للتطبيق

namespace WindowsFormsApp1.PL // بداية تعريف مساحة الأسماء الخاصة بهذا النموذج
{
    public partial class FRM_SUPP_ADD: Form // بداية تعريف النموذج لإضافة أو تعديل الموردين
    {
        // تهيئة المتغيرات والكائنات اللازمة لهذا النموذج
        DB_SMPEntities db = new DB_SMPEntities(); // كائن قاعدة البيانات
        TB_SUPP tb_supp = new TB_SUPP();
        BL.Methods methods = new BL.Methods(); // كائن لمكتبة الوظائف الخاصة بالتطبيق

        public int id; // معرف المورد المراد تعديله (0 إذا كانت عملية إضافة جديدة)

        public FRM_SUPP_ADD()
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

            // التحقق من ملء حقل اسم المورد
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم المورد مطلوب";
                dialog.Show();
            }// نهاية التحقق
            else if (edt_phone.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "رقم المورد مطلوب";
                dialog.Show();
            }// نهاية التحقق
            else if (edt_email.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "ايميل المورد مطلوب";
                dialog.Show();
            }// نهاية التحقق
            else
            { // التحقق من إجراء إضافة أو تعديل
                if (id == 0)
                {
                    // عملية إضافة جديدة

                    // حفظ صورة الغلاف واسم المورد في قاعدة البيانات
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.Convert_byte();
                    db.TB_SUPP.Add(tb_supp);

                    // التحقق من البريد الإلكتروني
                    if (!IsValidEmail(edt_email.Text))
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "البريد الإلكتروني غير صحيح.";
                        dialog.Show();
                        return;
                    }

                    // التحقق من رقم الهاتف
                    if (!IsValidPhoneNumber(edt_phone.Text))
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "رقم الهاتف غير صحيح.";
                        dialog.Show();
                        return;
                    }

                    // حفظ التغييرات في قاعدة البيانات
                    db.SaveChanges();
                    toast.lbl_caption.Text = "تم اضافة مورد جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    // عملية تعديل

                    // حفظ صورة الغلاف وتحديث معلومات المورد في قاعدة البيانات
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_supp.ID = id;
                    tb_supp.Supp_Name = edt_name.Text;
                    tb_supp.Supp_Phone = edt_phone.Text;
                    tb_supp.Supp_Email = edt_email.Text;
                    tb_supp.Supp_Image = methods.Convert_byte();
                    db.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;

                    // التحقق من البريد الإلكتروني
                    if (!IsValidEmail(edt_email.Text))
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "البريد الإلكتروني غير صحيح.";
                        dialog.Show();
                        return;
                    }

                    // التحقق من رقم الهاتف
                    if (!IsValidPhoneNumber(edt_phone.Text))
                    {
                        dialog.Width = this.Width;
                        dialog.txt_caption.Text = "رقم الهاتف غير صحيح.";
                        dialog.Show();
                        return;
                    }

                    // حفظ التغييرات في قاعدة البيانات
                    db.SaveChanges();
                    toast.lbl_caption.Text = "تم تعديل بيانات المورد";
                    toast.Show();
                    this.Close();
                }
            }
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }

        private void pn_close_Click(object sender, EventArgs e)
        {
            this.Close(); // إغلاق نموذج إضافة/تعديل المورد
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }

        // اختيار صورة للغلاف
        private void pic_cover_Click(object sender, EventArgs e)
        {
            add_Image();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_Image();
        }


        private void add_Image()
        {
            openFileDialog1.Filter = "Images Files|*.jpg;*.png|All Files|*.*"; // تحديد أنواع الملفات المسموح بها للاختيار (jpg و png)
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // إذا تم اختيار ملف وتم الضغط على زر "موافق" في مربع حوار الاختيار
            {
                pic_cover.Image = Image.FromFile(openFileDialog1.FileName); // تحميل الصورة المختارة من الملف وعرضها في عنصر الصورة (pic_cover)
            }
        }

        private void edt_name_TextChanged(object sender, EventArgs e)
        {
            edt_phone.Visible = true;
            edt_email.Visible = true;
        }





        // دالة للتحقق من صحة البريد الإلكتروني
        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // دالة للتحقق من صحة رقم الهاتف
        private bool IsValidPhoneNumber(string phoneNumber)
        {

            // تحقق من أن رقم الهاتف يحتوي على أرقام فقط ويتراوح طوله بين 7 و 15 رقمًا
            var regex = new Regex(@"^[0-9]{7,15}$");
            return regex.IsMatch(phoneNumber);


        }

    }
}
