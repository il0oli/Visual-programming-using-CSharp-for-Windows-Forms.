using WindowsFormsApp1.PL; // استيراد النموذج الرئيسي

namespace WindowsFormsApp1.BL
{
    public class ClassRoll
    {
        private Main main; // إنشاء كائن من النموذج الرئيسي

        // البناء الأولي للكلاس
        public ClassRoll(Main mainForm)
        {
            main = mainForm; // تعيين النموذج الرئيسي عند إنشاء كائن الكلاس
        }

        // الدالة لتحديد الصلاحيات بناءً على الدور المحدد
        public void SetPermissions(string role)
        {
            if (role == "مستخدم")
            {
                main.ptn_users.Enabled = false; // الغاء صلاحية اضافة او حذف او تعديل مستخدم

            }
            // يمكنك إضافة المزيد من الصلاحيات حسب الحاجة هنا
        }
    }
}
