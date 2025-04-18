using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.EPL;

namespace WindowsFormsApp1.PL
{
    public partial class FRM_Login : Form
    {
        // إنشاء كائنات ومتغيرات النموذج
        DB_SMPEntities db = new DB_SMPEntities(); // كائن لقاعدة البيانات
        TB_USERS tb_user = new TB_USERS(); // كائن لجدول المستخدمين
        Main main = new Main(); // كائن للنموذج الرئيسي
        BL.ClassRoll classroll;// الكائن الذي سنستخدمه لتحديد الصلاحيات


        // البناء الأولي للنموذج
        public FRM_Login()
        {
            InitializeComponent(); // تهيئة واجهة المستخدم
            
            classroll = new BL.ClassRoll(main);  // إنشاء كائن من الكلاس ClassRoll وتمرير النموذج الرئيسي main
        }

        private void lb_titlepage_Click(object sender, EventArgs e)
        {
            // لا يوجد أكواد في هذه الدالة حاليًا
        }

        // النقر على زر الدخول
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast(); // إنشاء كائن لعرض رسائل الإعلام
            Dialog dialog = new Dialog(); // إنشاء كائن لعرض مربع الحوار

            // التحقق من ملء حقل اسم المستخدم
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم المستخدم مطلوب";
                dialog.Show();
            }
            else
            {
                // التحقق من صحة اسم المستخدم وكلمة المرور في قاعدة البيانات
                tb_user = db.TB_USERS.Where(x => x.Users_Name == edt_name.Text && x.Users_Pass == edt_pass.Text).FirstOrDefault();
                if (tb_user != null)
                {
                    tb_user.User_State = "True";
                    db.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                     classroll.SetPermissions(tb_user.Users_Roll);
                    // تعيين البيانات الخاصة بالمستخدم الحالي في النموذج الرئيسي
                    main.lb_username.Text = tb_user.Users_Name;
                    main.lb_roll.Text = tb_user.Users_Roll;
                    main.Enabled = true;

                    // إلغاء تفعيل زر المستخدمين إذا لم يكن المستخدم مديرًا
                   

                    db.SaveChanges(); // حفظ التغييرات في قاعدة البيانات
                    main.Show(); // عرض النموذج الرئيسي
                    this.Hide(); // إغلاق نموذج تسجيل الدخول
                }
                else
                {
                    MessageBox.Show("فشل في تسجيل الدخول"); // رسالة خطأ إذا كان اسم المستخدم أو كلمة المرور غير صحيحة
                }
            }
        }

        // النقر على زر الإغلاق
        private void pn_close_Click(object sender, EventArgs e)
        {
            Application.Exit(); // إغلاق التطبيق بأكمله
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
            // لا يوجد أكواد في هذه الدالة حاليًا
        }

        private void pic_cover_Click(object sender, EventArgs e)
        {
            // لا يوجد أكواد في هذه الدالة حاليًا
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // لا يوجد أكواد في هذه الدالة حاليًا
        }

        private void FRM_Login_Load(object sender, EventArgs e)
        {
            // لا يوجد أكواد في هذه الدالة حاليًا
        }

        private void ch_pass_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            CheckPassword();
        }

        private void CheckPassword()
        {
           
            if (ch_pass.Checked)
            {
                edt_pass.UseSystemPasswordChar = false;
                link_show.Text = "اخفاء كملة السر";
            }
            else
            {
                edt_pass.UseSystemPasswordChar = true;
                link_show.Text = "اظهار كملة السر";
            }
        }

        private void link_show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            if(ch_pass.Checked == true) 
            {
                ch_pass.Checked = false;
            }
            else
            {
                ch_pass.Checked = true;
            }
        }
    }
}
