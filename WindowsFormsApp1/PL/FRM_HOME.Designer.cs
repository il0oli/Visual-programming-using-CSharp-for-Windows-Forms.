namespace WindowsFormsApp1.PL
{
    partial class FRM_HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_HOME));
            this.pn_home = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_sell = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_supp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pur = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cat = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_cat = new System.Windows.Forms.Label();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_supp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_sell = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_cus = new System.Windows.Forms.Label();
            this.lb_ = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_pur = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_report = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pn_home.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.bunifuCards5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.bunifuCards6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_home
            // 
            this.pn_home.Controls.Add(this.panel2);
            this.pn_home.Controls.Add(this.flowLayoutPanel1);
            this.pn_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_home.Location = new System.Drawing.Point(0, 0);
            this.pn_home.Name = "pn_home";
            this.pn_home.Size = new System.Drawing.Size(1030, 720);
            this.pn_home.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_sell);
            this.panel2.Controls.Add(this.btn_cus);
            this.panel2.Controls.Add(this.btn_supp);
            this.panel2.Controls.Add(this.btn_pur);
            this.panel2.Controls.Add(this.btn_cat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 93);
            this.panel2.TabIndex = 1;
            // 
            // btn_sell
            // 
            this.btn_sell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sell.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.Appearance.Options.UseFont = true;
            this.btn_sell.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.additem_32x32;
            this.btn_sell.Location = new System.Drawing.Point(816, 8);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(169, 75);
            this.btn_sell.TabIndex = 4;
            this.btn_sell.Text = "عملية بيع";
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_cus
            // 
            this.btn_cus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cus.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus.Appearance.Options.UseFont = true;
            this.btn_cus.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.additem_32x32;
            this.btn_cus.Location = new System.Drawing.Point(626, 8);
            this.btn_cus.Name = "btn_cus";
            this.btn_cus.Size = new System.Drawing.Size(169, 75);
            this.btn_cus.TabIndex = 3;
            this.btn_cus.Text = "اضافة عميل";
            this.btn_cus.Click += new System.EventHandler(this.btn_cus_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_supp.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp.Appearance.Options.UseFont = true;
            this.btn_supp.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.additem_32x32;
            this.btn_supp.Location = new System.Drawing.Point(245, 8);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(169, 75);
            this.btn_supp.TabIndex = 2;
            this.btn_supp.Text = "اضافة مورد";
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btn_pur
            // 
            this.btn_pur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_pur.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pur.Appearance.Options.UseFont = true;
            this.btn_pur.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.additem_32x32;
            this.btn_pur.Location = new System.Drawing.Point(438, 8);
            this.btn_pur.Name = "btn_pur";
            this.btn_pur.Size = new System.Drawing.Size(169, 75);
            this.btn_pur.TabIndex = 1;
            this.btn_pur.Text = "عملية شراء";
            this.btn_pur.Click += new System.EventHandler(this.btn_pur_Click);
            // 
            // btn_cat
            // 
            this.btn_cat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cat.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cat.Appearance.Options.UseFont = true;
            this.btn_cat.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.additem_32x32;
            this.btn_cat.Location = new System.Drawing.Point(51, 8);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(169, 75);
            this.btn_cat.TabIndex = 0;
            this.btn_cat.Text = "اضافة صنف";
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards1);
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards2);
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards3);
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards4);
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards5);
            this.flowLayoutPanel1.Controls.Add(this.bunifuCards6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 627);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.BottomShadow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lb_cat);
            this.bunifuCards1.Controls.Add(this.lb_titlepage);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.LeftShadow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(23, 23);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.RightShadow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(299, 202);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lb_cat
            // 
            this.lb_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cat.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cat.ForeColor = System.Drawing.Color.DimGray;
            this.lb_cat.Location = new System.Drawing.Point(26, 32);
            this.lb_cat.Name = "lb_cat";
            this.lb_cat.Size = new System.Drawing.Size(94, 71);
            this.lb_cat.TabIndex = 11;
            this.lb_cat.Text = "42";
            this.lb_cat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titlepage.Location = new System.Drawing.Point(113, 152);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(121, 40);
            this.lb_titlepage.TabIndex = 10;
            this.lb_titlepage.Text = "الأصناف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.BottomShadow = true;
            this.bunifuCards2.color = System.Drawing.Color.Tomato;
            this.bunifuCards2.Controls.Add(this.lb_supp);
            this.bunifuCards2.Controls.Add(this.label3);
            this.bunifuCards2.Controls.Add(this.pictureBox2);
            this.bunifuCards2.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.LeftShadow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(328, 23);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.RightShadow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(299, 202);
            this.bunifuCards2.TabIndex = 1;
            // 
            // lb_supp
            // 
            this.lb_supp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_supp.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supp.ForeColor = System.Drawing.Color.DimGray;
            this.lb_supp.Location = new System.Drawing.Point(26, 32);
            this.lb_supp.Name = "lb_supp";
            this.lb_supp.Size = new System.Drawing.Size(94, 71);
            this.lb_supp.TabIndex = 11;
            this.lb_supp.Text = "19";
            this.lb_supp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(113, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "الموردين";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(153, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.BottomShadow = true;
            this.bunifuCards3.color = System.Drawing.Color.Tomato;
            this.bunifuCards3.Controls.Add(this.lb_sell);
            this.bunifuCards3.Controls.Add(this.label5);
            this.bunifuCards3.Controls.Add(this.pictureBox3);
            this.bunifuCards3.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.LeftShadow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(633, 23);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.RightShadow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(299, 202);
            this.bunifuCards3.TabIndex = 2;
            // 
            // lb_sell
            // 
            this.lb_sell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_sell.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sell.ForeColor = System.Drawing.Color.DimGray;
            this.lb_sell.Location = new System.Drawing.Point(26, 32);
            this.lb_sell.Name = "lb_sell";
            this.lb_sell.Size = new System.Drawing.Size(94, 71);
            this.lb_sell.TabIndex = 11;
            this.lb_sell.Text = "32";
            this.lb_sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(113, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "المبيعات";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.BottomShadow = true;
            this.bunifuCards4.color = System.Drawing.Color.Tomato;
            this.bunifuCards4.Controls.Add(this.lb_cus);
            this.bunifuCards4.Controls.Add(this.lb_);
            this.bunifuCards4.Controls.Add(this.pictureBox4);
            this.bunifuCards4.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.LeftShadow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(23, 231);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.RightShadow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(299, 202);
            this.bunifuCards4.TabIndex = 3;
            // 
            // lb_cus
            // 
            this.lb_cus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_cus.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cus.ForeColor = System.Drawing.Color.DimGray;
            this.lb_cus.Location = new System.Drawing.Point(26, 32);
            this.lb_cus.Name = "lb_cus";
            this.lb_cus.Size = new System.Drawing.Size(94, 71);
            this.lb_cus.TabIndex = 11;
            this.lb_cus.Text = "75";
            this.lb_cus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_
            // 
            this.lb_.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_.AutoSize = true;
            this.lb_.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_.ForeColor = System.Drawing.Color.DimGray;
            this.lb_.Location = new System.Drawing.Point(128, 143);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(106, 40);
            this.lb_.TabIndex = 10;
            this.lb_.Text = "العملاء";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(153, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(143, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuCards5
            // 
            this.bunifuCards5.BackColor = System.Drawing.Color.White;
            this.bunifuCards5.BorderRadius = 5;
            this.bunifuCards5.BottomSahddow = true;
            this.bunifuCards5.BottomShadow = true;
            this.bunifuCards5.color = System.Drawing.Color.Tomato;
            this.bunifuCards5.Controls.Add(this.lb_pur);
            this.bunifuCards5.Controls.Add(this.label9);
            this.bunifuCards5.Controls.Add(this.pictureBox5);
            this.bunifuCards5.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuCards5.LeftSahddow = false;
            this.bunifuCards5.LeftShadow = false;
            this.bunifuCards5.Location = new System.Drawing.Point(328, 231);
            this.bunifuCards5.Name = "bunifuCards5";
            this.bunifuCards5.RightSahddow = true;
            this.bunifuCards5.RightShadow = true;
            this.bunifuCards5.ShadowDepth = 20;
            this.bunifuCards5.Size = new System.Drawing.Size(299, 202);
            this.bunifuCards5.TabIndex = 4;
            // 
            // lb_pur
            // 
            this.lb_pur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_pur.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pur.ForeColor = System.Drawing.Color.DimGray;
            this.lb_pur.Location = new System.Drawing.Point(26, 32);
            this.lb_pur.Name = "lb_pur";
            this.lb_pur.Size = new System.Drawing.Size(94, 71);
            this.lb_pur.TabIndex = 11;
            this.lb_pur.Text = "12";
            this.lb_pur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(83, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 40);
            this.label9.TabIndex = 10;
            this.label9.Text = "المشتريات";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(153, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 116);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.White;
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.BottomShadow = true;
            this.bunifuCards6.color = System.Drawing.Color.Tomato;
            this.bunifuCards6.Controls.Add(this.lb_report);
            this.bunifuCards6.Controls.Add(this.label11);
            this.bunifuCards6.Controls.Add(this.pictureBox6);
            this.bunifuCards6.IndicatorColor = System.Drawing.Color.Tomato;
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.LeftShadow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(633, 231);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.RightShadow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(299, 202);
            this.bunifuCards6.TabIndex = 5;
            // 
            // lb_report
            // 
            this.lb_report.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_report.Font = new System.Drawing.Font("Tahoma", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_report.ForeColor = System.Drawing.Color.DimGray;
            this.lb_report.Location = new System.Drawing.Point(26, 32);
            this.lb_report.Name = "lb_report";
            this.lb_report.Size = new System.Drawing.Size(62, 71);
            this.lb_report.TabIndex = 11;
            this.lb_report.Text = "9";
            this.lb_report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(136, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 40);
            this.label11.TabIndex = 10;
            this.label11.Text = "التقارير";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(153, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(143, 116);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // FRM_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_HOME";
            this.Text = "FRM_HOME";
            this.pn_home.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.bunifuCards5.ResumeLayout(false);
            this.bunifuCards5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.bunifuCards6.ResumeLayout(false);
            this.bunifuCards6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_cat;
        private DevExpress.XtraEditors.SimpleButton btn_sell;
        private DevExpress.XtraEditors.SimpleButton btn_cus;
        private DevExpress.XtraEditors.SimpleButton btn_supp;
        private DevExpress.XtraEditors.SimpleButton btn_pur;
        public System.Windows.Forms.Panel pn_home;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lb_cat;
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label lb_supp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label lb_sell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label lb_cus;
        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private System.Windows.Forms.Label lb_pur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.Label lb_report;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}