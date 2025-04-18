namespace WindowsFormsApp1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pn_navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptn_home = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_cat = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_supp = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_pur = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_Client = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_sell = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_report = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_users = new DevExpress.XtraEditors.SimpleButton();
            this.ptn_setting = new DevExpress.XtraEditors.SimpleButton();
            this.pn_headernavbar = new System.Windows.Forms.Panel();
            this.pn_titlenavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_roll = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptn_collapse = new DevExpress.XtraEditors.SimpleButton();
            this.pn_cont = new System.Windows.Forms.Panel();
            this.pn_topbar = new System.Windows.Forms.Panel();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.btn_logout = new DevExpress.XtraEditors.SimpleButton();
            this.btn_min = new DevExpress.XtraEditors.SimpleButton();
            this.pn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_max = new DevExpress.XtraEditors.SimpleButton();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pn_navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_headernavbar.SuspendLayout();
            this.pn_titlenavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.pn_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_navbar
            // 
            this.pn_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_navbar.Controls.Add(this.flowLayoutPanel1);
            this.pn_navbar.Controls.Add(this.pn_headernavbar);
            this.pn_navbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_navbar.Location = new System.Drawing.Point(1030, 0);
            this.pn_navbar.Name = "pn_navbar";
            this.pn_navbar.Size = new System.Drawing.Size(250, 720);
            this.pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ptn_home);
            this.flowLayoutPanel1.Controls.Add(this.ptn_cat);
            this.flowLayoutPanel1.Controls.Add(this.ptn_supp);
            this.flowLayoutPanel1.Controls.Add(this.ptn_pur);
            this.flowLayoutPanel1.Controls.Add(this.ptn_Client);
            this.flowLayoutPanel1.Controls.Add(this.ptn_sell);
            this.flowLayoutPanel1.Controls.Add(this.ptn_report);
            this.flowLayoutPanel1.Controls.Add(this.ptn_users);
            this.flowLayoutPanel1.Controls.Add(this.ptn_setting);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 246);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 474);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ptn_home
            // 
            this.ptn_home.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_home.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_home.Appearance.Options.UseFont = true;
            this.ptn_home.Appearance.Options.UseForeColor = true;
            this.ptn_home.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_home.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ptn_home.ImageOptions.SvgImage")));
            this.ptn_home.Location = new System.Drawing.Point(5, 3);
            this.ptn_home.Name = "ptn_home";
            this.ptn_home.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_home.Size = new System.Drawing.Size(242, 44);
            this.ptn_home.TabIndex = 9;
            this.ptn_home.Text = "الرئيسة";
            this.ptn_home.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // ptn_cat
            // 
            this.ptn_cat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_cat.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_cat.Appearance.Options.UseFont = true;
            this.ptn_cat.Appearance.Options.UseForeColor = true;
            this.ptn_cat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptn_cat.ImageOptions.Image")));
            this.ptn_cat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_cat.Location = new System.Drawing.Point(5, 53);
            this.ptn_cat.Name = "ptn_cat";
            this.ptn_cat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_cat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_cat.Size = new System.Drawing.Size(242, 44);
            this.ptn_cat.TabIndex = 10;
            this.ptn_cat.Text = "الأصناف";
            this.ptn_cat.Click += new System.EventHandler(this.ptn_cat_Click);
            // 
            // ptn_supp
            // 
            this.ptn_supp.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_supp.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_supp.Appearance.Options.UseFont = true;
            this.ptn_supp.Appearance.Options.UseForeColor = true;
            this.ptn_supp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptn_supp.ImageOptions.Image")));
            this.ptn_supp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_supp.Location = new System.Drawing.Point(5, 103);
            this.ptn_supp.Name = "ptn_supp";
            this.ptn_supp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_supp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_supp.Size = new System.Drawing.Size(242, 44);
            this.ptn_supp.TabIndex = 11;
            this.ptn_supp.Text = "الموردين";
            this.ptn_supp.Click += new System.EventHandler(this.ptn_supp_Click);
            // 
            // ptn_pur
            // 
            this.ptn_pur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_pur.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_pur.Appearance.Options.UseFont = true;
            this.ptn_pur.Appearance.Options.UseForeColor = true;
            this.ptn_pur.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.buy_32x32;
            this.ptn_pur.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_pur.Location = new System.Drawing.Point(5, 153);
            this.ptn_pur.Name = "ptn_pur";
            this.ptn_pur.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_pur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_pur.Size = new System.Drawing.Size(242, 44);
            this.ptn_pur.TabIndex = 12;
            this.ptn_pur.Text = "المشتريات";
            this.ptn_pur.Click += new System.EventHandler(this.ptn_pur_Click);
            // 
            // ptn_Client
            // 
            this.ptn_Client.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_Client.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_Client.Appearance.Options.UseFont = true;
            this.ptn_Client.Appearance.Options.UseForeColor = true;
            this.ptn_Client.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.employee_32x32;
            this.ptn_Client.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_Client.Location = new System.Drawing.Point(5, 203);
            this.ptn_Client.Name = "ptn_Client";
            this.ptn_Client.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_Client.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_Client.Size = new System.Drawing.Size(242, 44);
            this.ptn_Client.TabIndex = 13;
            this.ptn_Client.Text = "العملاء";
            this.ptn_Client.Click += new System.EventHandler(this.ptn_Client_Click);
            // 
            // ptn_sell
            // 
            this.ptn_sell.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_sell.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_sell.Appearance.Options.UseFont = true;
            this.ptn_sell.Appearance.Options.UseForeColor = true;
            this.ptn_sell.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.fullshoppingcart_32x32;
            this.ptn_sell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_sell.Location = new System.Drawing.Point(5, 253);
            this.ptn_sell.Name = "ptn_sell";
            this.ptn_sell.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_sell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_sell.Size = new System.Drawing.Size(242, 44);
            this.ptn_sell.TabIndex = 14;
            this.ptn_sell.Text = "المبيعات";
            this.ptn_sell.Click += new System.EventHandler(this.ptn_sell_Click);
            // 
            // ptn_report
            // 
            this.ptn_report.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_report.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_report.Appearance.Options.UseFont = true;
            this.ptn_report.Appearance.Options.UseForeColor = true;
            this.ptn_report.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.selectdata_32x32;
            this.ptn_report.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_report.Location = new System.Drawing.Point(5, 303);
            this.ptn_report.Name = "ptn_report";
            this.ptn_report.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_report.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_report.Size = new System.Drawing.Size(242, 44);
            this.ptn_report.TabIndex = 15;
            this.ptn_report.Text = "التقراير";
            this.ptn_report.Click += new System.EventHandler(this.ptn_report_Click);
            // 
            // ptn_users
            // 
            this.ptn_users.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_users.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_users.Appearance.Options.UseFont = true;
            this.ptn_users.Appearance.Options.UseForeColor = true;
            this.ptn_users.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.usergroup_32x32;
            this.ptn_users.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_users.Location = new System.Drawing.Point(5, 353);
            this.ptn_users.Name = "ptn_users";
            this.ptn_users.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_users.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_users.Size = new System.Drawing.Size(242, 44);
            this.ptn_users.TabIndex = 16;
            this.ptn_users.Text = "المستخدمين";
            this.ptn_users.Click += new System.EventHandler(this.ptn_users_Click);
            // 
            // ptn_setting
            // 
            this.ptn_setting.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_setting.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.ptn_setting.Appearance.Options.UseFont = true;
            this.ptn_setting.Appearance.Options.UseForeColor = true;
            this.ptn_setting.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ptn_setting.ImageOptions.SvgImage = global::WindowsFormsApp1.Properties.Resources.properties;
            this.ptn_setting.Location = new System.Drawing.Point(5, 403);
            this.ptn_setting.Name = "ptn_setting";
            this.ptn_setting.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_setting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptn_setting.Size = new System.Drawing.Size(242, 44);
            this.ptn_setting.TabIndex = 17;
            this.ptn_setting.Text = "الاعدادات";
            this.ptn_setting.Click += new System.EventHandler(this.ptn_setting_Click);
            // 
            // pn_headernavbar
            // 
            this.pn_headernavbar.Controls.Add(this.pn_titlenavbar);
            this.pn_headernavbar.Controls.Add(this.flowLayoutPanel2);
            this.pn_headernavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_headernavbar.Location = new System.Drawing.Point(0, 0);
            this.pn_headernavbar.Name = "pn_headernavbar";
            this.pn_headernavbar.Size = new System.Drawing.Size(250, 246);
            this.pn_headernavbar.TabIndex = 0;
            // 
            // pn_titlenavbar
            // 
            this.pn_titlenavbar.Controls.Add(this.pictureBox1);
            this.pn_titlenavbar.Controls.Add(this.lb_roll);
            this.pn_titlenavbar.Controls.Add(this.lb_username);
            this.pn_titlenavbar.Location = new System.Drawing.Point(3, 1);
            this.pn_titlenavbar.Name = "pn_titlenavbar";
            this.pn_titlenavbar.Size = new System.Drawing.Size(201, 244);
            this.pn_titlenavbar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_roll
            // 
            this.lb_roll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_roll.AutoSize = true;
            this.lb_roll.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_roll.Location = new System.Drawing.Point(59, 202);
            this.lb_roll.Name = "lb_roll";
            this.lb_roll.Size = new System.Drawing.Size(62, 27);
            this.lb_roll.TabIndex = 11;
            this.lb_roll.Text = "أدمـــن";
            // 
            // lb_username
            // 
            this.lb_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_username.AutoSize = true;
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_username.Location = new System.Drawing.Point(59, 172);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(105, 27);
            this.lb_username.TabIndex = 10;
            this.lb_username.Text = "امجد عبد السلام";
            this.lb_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ptn_collapse);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(207, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(43, 246);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // ptn_collapse
            // 
            this.ptn_collapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ptn_collapse.ImageOptions.Image")));
            this.ptn_collapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ptn_collapse.Location = new System.Drawing.Point(3, 3);
            this.ptn_collapse.Name = "ptn_collapse";
            this.ptn_collapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ptn_collapse.Size = new System.Drawing.Size(37, 29);
            this.ptn_collapse.TabIndex = 12;
            this.ptn_collapse.Click += new System.EventHandler(this.ptn_collapse_Click);
            // 
            // pn_cont
            // 
            this.pn_cont.BackColor = System.Drawing.Color.White;
            this.pn_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cont.Location = new System.Drawing.Point(0, 59);
            this.pn_cont.Name = "pn_cont";
            this.pn_cont.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pn_cont.Size = new System.Drawing.Size(1030, 661);
            this.pn_cont.TabIndex = 2;
            // 
            // pn_topbar
            // 
            this.pn_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pn_topbar.Controls.Add(this.lb_titlepage);
            this.pn_topbar.Controls.Add(this.btn_logout);
            this.pn_topbar.Controls.Add(this.btn_min);
            this.pn_topbar.Controls.Add(this.pn_close);
            this.pn_topbar.Controls.Add(this.btn_max);
            this.pn_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_topbar.Location = new System.Drawing.Point(0, 0);
            this.pn_topbar.Name = "pn_topbar";
            this.pn_topbar.Size = new System.Drawing.Size(1030, 59);
            this.pn_topbar.TabIndex = 3;
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_titlepage.Location = new System.Drawing.Point(478, 14);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(61, 27);
            this.lb_titlepage.TabIndex = 9;
            this.lb_titlepage.Text = "الرئيسية";
            // 
            // btn_logout
            // 
            this.btn_logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.ImageOptions.Image")));
            this.btn_logout.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_logout.Location = new System.Drawing.Point(162, 6);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_logout.Size = new System.Drawing.Size(42, 44);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.ToolTip = "تسجيل الخروج";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_min
            // 
            this.btn_min.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.ImageOptions.Image")));
            this.btn_min.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_min.Location = new System.Drawing.Point(100, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_min.Size = new System.Drawing.Size(50, 50);
            this.btn_min.TabIndex = 7;
            this.btn_min.ToolTip = "تصغير الشاشة";
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click_1);
            // 
            // pn_close
            // 
            this.pn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pn_close.ImageOptions.Image")));
            this.pn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.pn_close.Location = new System.Drawing.Point(12, 3);
            this.pn_close.Name = "pn_close";
            this.pn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.pn_close.Size = new System.Drawing.Size(50, 50);
            this.pn_close.TabIndex = 6;
            this.pn_close.ToolTip = "اغلاق البرنامج";
            this.pn_close.Click += new System.EventHandler(this.pn_close_Click_1);
            // 
            // btn_max
            // 
            this.btn_max.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.ImageOptions.Image")));
            this.btn_max.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_max.Location = new System.Drawing.Point(57, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_max.Size = new System.Drawing.Size(50, 50);
            this.btn_max.TabIndex = 5;
            this.btn_max.ToolTip = "تكبير / تصغير";
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click_1);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pn_topbar;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pn_cont);
            this.Controls.Add(this.pn_topbar);
            this.Controls.Add(this.pn_navbar);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "SMP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pn_navbar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pn_headernavbar.ResumeLayout(false);
            this.pn_titlenavbar.ResumeLayout(false);
            this.pn_titlenavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pn_topbar.ResumeLayout(false);
            this.pn_topbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_navbar;
        private System.Windows.Forms.Panel pn_cont;
        private System.Windows.Forms.Panel pn_headernavbar;
        private DevExpress.XtraEditors.SimpleButton ptn_collapse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton ptn_home;
        private DevExpress.XtraEditors.SimpleButton ptn_cat;
        private DevExpress.XtraEditors.SimpleButton ptn_supp;
        private DevExpress.XtraEditors.SimpleButton ptn_pur;
        private DevExpress.XtraEditors.SimpleButton ptn_Client;
        private DevExpress.XtraEditors.SimpleButton ptn_sell;
        private DevExpress.XtraEditors.SimpleButton ptn_report;
        private DevExpress.XtraEditors.SimpleButton ptn_setting;
        private System.Windows.Forms.Panel pn_titlenavbar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pn_topbar;
        private System.Windows.Forms.Label lb_titlepage;
        private DevExpress.XtraEditors.SimpleButton btn_logout;
        private DevExpress.XtraEditors.SimpleButton btn_min;
        private DevExpress.XtraEditors.SimpleButton pn_close;
        private DevExpress.XtraEditors.SimpleButton btn_max;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        public System.Windows.Forms.Label lb_username;
        public System.Windows.Forms.Label lb_roll;
        public DevExpress.XtraEditors.SimpleButton ptn_users;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

