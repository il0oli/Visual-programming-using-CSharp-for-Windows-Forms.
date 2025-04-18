using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    internal class YourDbContext : DB_SMPEntities
    {
        public DbSet<TB_CAT> TB_CATs { get; set; }
        public DbSet<TB_SUPP> TB_SUPPs { get; set; }
        // قم بتعريف موديلات الجداول الأخرى إذا كانت موجودة
    }

    public class YourRepository
    {
        private YourDbContext db = new YourDbContext();

        public int GetIdByNameInCatTable(string name)
        {
            var record = db.TB_CAT.FirstOrDefault(c => c.CAT_Name == name);

            if (record != null)
            {
                return record.ID;
            }
            else
            {
                throw new ArgumentException("السجل غير موجود بالاسم المحدد في جدول TB_CAT");
            }
        }

        public int GetIdByNameInSuppTable(string name)
        {
            var record = db.TB_SUPP.FirstOrDefault(s => s.Supp_Name == name);

            if (record != null)
            {
                return record.ID;
            }
            else
            {
                throw new ArgumentException("السجل غير موجود بالاسم المحدد في جدول TB_SUPP");
            }
        }
    }
}
