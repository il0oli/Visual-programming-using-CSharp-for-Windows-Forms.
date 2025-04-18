using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        // init form
        PL.FRM_CAT frm_cat = new PL.FRM_CAT();
        PL.FRM_HOME frm_home = new PL.FRM_HOME();
        PL.FRM_SUPP frm_supp = new PL.FRM_SUPP();
        PL.FRM_PUR frm_pur = new PL.FRM_PUR();
        PL.FRM_CUS frm_cus = new PL.FRM_CUS();
        PL.FRM_SELL frm_sell = new PL.FRM_SELL();
        PL.FRM_Report frm_report = new PL.FRM_Report();
        PL.FRM_USERS frm_user   = new PL.FRM_USERS();
        DB_SMPEntities db = new DB_SMPEntities();
        TB_USERS tb_user = new TB_USERS();
        
        
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        // Collapse 
        private void ptn_collapse_Click(object sender, EventArgs e)
        {
            if(pn_navbar.Width == 250)
            {
                pn_navbar.Width = 50;
                pn_titlenavbar.Visible = false;
                pn_headernavbar.Height = 200;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenavbar.Visible = true;
                pn_headernavbar.Height = 246;
            }
        }

        // load home
        private void simpleButton6_Click(object sender, EventArgs e)
        {
           pn_cont.Controls.Clear();
           pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        // load cat
        private void ptn_cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities();
            frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
            lb_titlepage.Text = "الاصناف";
        }


        // close app
        private void pn_close_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }


        // max app
        private void btn_max_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }


        // min app
        private void btn_min_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // load supp
        private void ptn_supp_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_supp.pn_supp);
            db = new DB_SMPEntities();
            // frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
            lb_titlepage.Text = "الموردين";
        }

        // load pur
        private void ptn_pur_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_pur);
            db = new DB_SMPEntities();
           
            lb_titlepage.Text = "المشتريات";
        }

        private void ptn_Client_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cus.pn_cus);
            db = new DB_SMPEntities();

            lb_titlepage.Text = "العملاء";
        }
        
        // loads sell
        private void ptn_sell_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_sell);
            db = new DB_SMPEntities();

            lb_titlepage.Text = "المبيعات";
        }

        private void ptn_report_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_report);
           
            lb_titlepage.Text = "التقارير";
        }

        private void ptn_users_Click(object sender, EventArgs e)
        {

            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_user.pn_users);

            lb_titlepage.Text = "المستخدمين";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            PL.FRM_Login fRM_Login = new PL.FRM_Login();
            tb_user = db.TB_USERS.Where(x => x.User_State == "True").FirstOrDefault();
            tb_user.User_State = "False";
            db.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            this.Enabled = false;
            fRM_Login.Show();
            this.Hide();
        }

        private void ptn_setting_Click(object sender, EventArgs e)
        {
                PL.FRM_Settings fRM_Settings = new PL.FRM_Settings();
                fRM_Settings.Show();
        }
    }
}
