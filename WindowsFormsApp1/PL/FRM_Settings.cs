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
using System.Windows.Forms;
using WindowsFormsApp1.EPL;
using System.Configuration;

namespace WindowsFormsApp1.PL 
{
    public partial class FRM_Settings : Form 
    {
      
        public FRM_Settings()
        {
            InitializeComponent(); // تهيئة واجهة المستخدم
        }

      
        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
           
        }

        private void pn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // نقوم بظبط نص الاتصال بقاعدة البيانات
            const string qu = "\"";
            var sv = edt_sv.Text;
            var constr = @"metadata=res://*/SMPM.csdl|res://*/SMPM.ssdl|res://*/SMPM.msl;provider=System.Data.SqlClient;provider connection string="+qu+";data source="+sv+";initial catalog=DB_SMP;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";

            // set نقوم بعمل 
            // لقاعدة البيانات 
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString = constr;
            // نعمل حفظ للبيانات
            config.Save();

            // Refresh نعمل 
            ConfigurationManager.RefreshSection("connectionString");

            var strl = config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString;
            MessageBox.Show(strl);
            Application.Restart();

        }
    }
}
