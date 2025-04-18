// استيراد المكتبات الضرورية
using DevExpress.Pdf;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.EPL;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1.PL
{
    public partial class FRM_SELL_ADD : Form
    {
        // إنشاء كائنات البيانات والأعمال التي سيتم استخدامها
        private DB_SMPEntities db = new DB_SMPEntities(); // كائن قاعدة البيانات
        private TB_PUR tb_pur = new TB_PUR();
        private TB_SELL tb_sell = new TB_SELL();
        private BL.Methods methods = new BL.Methods(); // كائن لمكتبة الوظائف الخاصة بالتطبيق


        private double qtp, qtn, qtr , x; // متغيرات للعمليات الحسابية
        public int id; // معرف المورد المراد تعديله (0 إذا كانت عملية إضافة جديدة)

        private Color borderColor = Color.SteelBlue;
        private int borderWidth = 5;

        public FRM_SELL_ADD()
        {
            InitializeComponent(); // تهيئة واجهة المستخدم
        }

        // دالة لرسم الحاشية الخارجية للنافذة
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        // العمليات عند النقر على العناصر في الواجهة
        private void lb_titlepage_Click(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }

        // العمليات عند النقر على زر الإضافة أو التعديل
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast(); // إنشاء كائن لعرض رسائل الإعلام
            Dialog dialog = new Dialog(); // إنشاء كائن لعرض مربع حوار

            // قراءة وتحقق من بيانات المدخلات

            qtp = Convert.ToDouble(txt_qt.Text);
            qtn = Convert.ToDouble(edt_qt.Text);

           
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الالمادة المطلوبة";
                dialog.Show();
            }
            else
            {
                // التحقق من إجراء إضافة أو تعديل
                if (id == 0)
                {
                    qtr = qtp - qtn;


                    if (qtr >= 0)
                    {
                        // عملية إضافة جديدة
                        // عملية إضافة جديدة
                        tb_sell.Sell_Name = edt_name.Text;
                        tb_sell.Sell_Cus = edt_cus.Text;
                        tb_sell.Sell_price = Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Qt = Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_Tprice = Convert.ToDouble(edt_qt.Text) * Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Date = DateTime.Now;

                        // حفظ التغييرات في قاعدة البيانات
                        db.TB_SELL.Add(tb_sell);
                        tb_pur.Pur_Qt = qtr;
                        db.Entry(tb_pur).State = EntityState.Modified;
                        db.SaveChanges();
                        toast.lbl_caption.Text = "تم اجراء عملية شراء";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        label4.Visible = true;
                    }
                }
                else
                {
                    // عملية تعديل
                    // عملية تعديل
                    try
                    {



                      
                        tb_sell = db.TB_SELL.Where(x => x.ID == id).FirstOrDefault();
                        x = Convert.ToDouble(tb_sell.Sell_Qt);
                        tb_sell.Sell_Name = edt_name.Text;
                        tb_sell.Sell_Cus = edt_cus.Text;
                        tb_sell.Sell_price = Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Qt = Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_Tprice = Convert.ToDouble(edt_qt.Text) * Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Date = DateTime.Now;
                     
                        if (x == qtn)
                        {
                            //qtr = x;
                        }

                        else if (x > qtn)
                        {
                            qtr = x - qtn;
                        }
                       else if (x < qtn)
                        {
                            qtr = x - qtn;
                        }
                        // حفظ التغييرات في جدول البيع
                        db.Entry(tb_sell).State = EntityState.Modified;
                        db.SaveChanges();

                        // حساب الفرق بين الكمية الجديدة والكمية السابقة للمبيعات

                       

                        // تحديث كمية المشتريات في جدول الشراء باستخدام الفرق
                        tb_pur.Pur_Qt += qtr;
                        db.Entry(tb_pur).State = EntityState.Modified;
                        db.SaveChanges();

                        toast.lbl_caption.Text = "تم تعديل عملية شراء ";
                        toast.Show();
                        this.Close();
                    }
                    catch
                    {
                        toast.lbl_caption.Text = "حصل خطأ ";
                        toast.Show();
                        this.Close();
                    }
                }
            }
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {
            SetComboBoxValues(id, id);
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
            // toolTip1.SetToolTip(edt_buy, "ادخل سعر الشراء");
        }

        private void edt_buy_Leave(object sender, EventArgs e)
        {
            // toolTip1.SetToolTip(edt_buy, "");
        }

        private void edt_det_Enter(object sender, EventArgs e)
        {
            // toolTip1.SetToolTip(edt_det, "تفاصيل عملية البيع والشراء ");
        }

        private void edt_det_Leave(object sender, EventArgs e)
        {
            // toolTip1.SetToolTip(edt_det, "");
        }

        private void edt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            // استعراض وعرض بعض البيانات بناءً على الاختيار في القائمة المنسدلة
            tb_pur = db.TB_PUR.Where(x => x.Pur_Name == edt_name.Text).FirstOrDefault();
            txt_buy.Text = tb_pur.Pur_Buy.ToString();
            txt_sell.Text = tb_pur.Pur_Sell.ToString();
            edt_sell.Text = tb_pur.Pur_Sell.ToString();
            txt_qt.Text = tb_pur.Pur_Qt.ToString();
        }

        private void pic_cover_EditValueChanged(object sender, EventArgs e)
        {
            // يُترك هذا السطر فارغًا، ليس له وظيفة مهمة في الوقت الحالي.
        }

        private void FRM_PUR_ADD_Activated(object sender, EventArgs e)
        {
            // استعراض وعرض بعض البيانات بناءً على بيانات قاعدة البيانات
            var rs1 = db.TB_PUR.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_CUS.Select(x => x.Supp_Name).ToList();
            edt_name.DataSource = rs1;
            edt_cus.DataSource = rs2;

            AutoCompleteStringCollection ACSC1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();
            ACSC1.AddRange(rs1.ToArray());
            ACSC2.AddRange(rs2.ToArray());
            edt_name.AutoCompleteCustomSource = ACSC1;
            edt_cus.AutoCompleteCustomSource = ACSC2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_PUR_ADD frm_add = new FRM_PUR_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_CUS_ADD frm_add = new FRM_CUS_ADD();
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
                    //sell = Convert.ToDouble(edt_sell.Text);
                    //buy = Convert.ToDouble(edt_buy.Text);
                    //qt = Convert.ToDouble(edt_qt.Value);

                    //tsell = sell * qt;
                    //tbuy = buy * qt;
                    //trev = tsell - tbuy;

                    //edt_tsell.Text = tsell.ToString();
                    //edt_tbuy.Text = tbuy.ToString();
                    //edt_trev.Text = trev.ToString();
                }
                catch
                {
                }
            }
            catch (FormatException ex)
            {
                Dialog dialog = new Dialog();
                dialog.txt_caption.Text = "قم بادخال قيمة " + ex;
                dialog.Show();
            }
        }



        // تقوم هذه الدالة بعرض البيانات في كومبو بوكس عند التعديل 
        // id وذلك استنادا على الـــ
        private void SetComboBoxValues(int materialID, int customerID)
        {
            // ابحث عن المادة باستخدام ID واعين القيم للـ edt_name
            var material = db.TB_SELL.Where(x => x.ID == materialID).FirstOrDefault();
            if (material != null)
            {
                edt_name.Text = material.Sell_Name;
            }

            // ابحث عن العميل باستخدام ID واعين القيم للـ edt_cus
            var customer = db.TB_SELL.Where(x => x.ID == customerID).FirstOrDefault();
            if (customer != null)
            {
                edt_cus.Text = customer.Sell_Cus;
            }
        }

        private void LoadComboBoxValues()
        {
            // استعلام للحصول على قائمة القيم المتاحة لـ edt_name وتعيينها إلى DataSource
            var availableNames = db.TB_SELL.Select(x => x.Sell_Name).Distinct().ToList();
            edt_name.DataSource = availableNames;

            // استعلام للحصول على قائمة العملاء المتاحين وتعيينها إلى DataSource
            var availableCustomers = db.TB_SELL.Select(x => x.Sell_Cus).Distinct().ToList();
            edt_cus.DataSource = availableCustomers;
        }


    }
}

