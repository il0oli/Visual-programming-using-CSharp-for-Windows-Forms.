namespace WindowsFormsApp1.PL
{
    partial class FRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_close = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.edt_pass = new System.Windows.Forms.TextBox();
            this.ch_pass = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.link_show = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(411, 397);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(234, 40);
            this.lb_titlepage.TabIndex = 11;
            this.lb_titlepage.Text = "اسم المستخدم";
            this.lb_titlepage.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(485, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "كلمة السر";
            this.label1.Click += new System.EventHandler(this.lb_titlepage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 47);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pn_close
            // 
            this.pn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pn_close.ImageOptions.Image")));
            this.pn_close.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.pn_close.Location = new System.Drawing.Point(629, 0);
            this.pn_close.Name = "pn_close";
            this.pn_close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.pn_close.Size = new System.Drawing.Size(44, 44);
            this.pn_close.TabIndex = 10;
            this.pn_close.Click += new System.EventHandler(this.pn_close_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(78, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 81);
            this.label3.TabIndex = 17;
            this.label3.Text = "تسجيل الدخول";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(0, 738);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(676, 77);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "تسجيل الخول";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(238, 124);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(174, 226);
            this.pic_cover.TabIndex = 13;
            this.pic_cover.EditValueChanged += new System.EventHandler(this.pic_cover_EditValueChanged);
            this.pic_cover.Click += new System.EventHandler(this.pic_cover_Click);
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 16F);
            this.edt_name.Location = new System.Drawing.Point(66, 414);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(286, 40);
            this.edt_name.TabIndex = 18;
            // 
            // edt_pass
            // 
            this.edt_pass.Font = new System.Drawing.Font("Tahoma", 16F);
            this.edt_pass.Location = new System.Drawing.Point(66, 489);
            this.edt_pass.Name = "edt_pass";
            this.edt_pass.Size = new System.Drawing.Size(286, 40);
            this.edt_pass.TabIndex = 18;
            this.edt_pass.UseSystemPasswordChar = true;
            // 
            // ch_pass
            // 
            this.ch_pass.AllowBindingControlAnimation = true;
            this.ch_pass.AllowBindingControlColorChanges = false;
            this.ch_pass.AllowBindingControlLocation = true;
            this.ch_pass.AllowCheckBoxAnimation = false;
            this.ch_pass.AllowCheckmarkAnimation = true;
            this.ch_pass.AllowOnHoverStates = true;
            this.ch_pass.AutoCheck = true;
            this.ch_pass.BackColor = System.Drawing.Color.Transparent;
            this.ch_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ch_pass.BackgroundImage")));
            this.ch_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ch_pass.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ch_pass.BorderRadius = 12;
            this.ch_pass.Checked = false;
            this.ch_pass.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.ch_pass.Cursor = System.Windows.Forms.Cursors.Default;
            this.ch_pass.CustomCheckmarkImage = null;
            this.ch_pass.Location = new System.Drawing.Point(66, 548);
            this.ch_pass.MinimumSize = new System.Drawing.Size(17, 17);
            this.ch_pass.Name = "ch_pass";
            this.ch_pass.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ch_pass.OnCheck.BorderRadius = 12;
            this.ch_pass.OnCheck.BorderThickness = 2;
            this.ch_pass.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.ch_pass.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ch_pass.OnCheck.CheckmarkThickness = 2;
            this.ch_pass.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ch_pass.OnDisable.BorderRadius = 12;
            this.ch_pass.OnDisable.BorderThickness = 2;
            this.ch_pass.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ch_pass.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ch_pass.OnDisable.CheckmarkThickness = 2;
            this.ch_pass.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ch_pass.OnHoverChecked.BorderRadius = 12;
            this.ch_pass.OnHoverChecked.BorderThickness = 2;
            this.ch_pass.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ch_pass.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ch_pass.OnHoverChecked.CheckmarkThickness = 2;
            this.ch_pass.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ch_pass.OnHoverUnchecked.BorderRadius = 12;
            this.ch_pass.OnHoverUnchecked.BorderThickness = 1;
            this.ch_pass.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ch_pass.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.ch_pass.OnUncheck.BorderRadius = 12;
            this.ch_pass.OnUncheck.BorderThickness = 1;
            this.ch_pass.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ch_pass.Size = new System.Drawing.Size(31, 31);
            this.ch_pass.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ch_pass.TabIndex = 19;
            this.ch_pass.ThreeState = false;
            this.ch_pass.ToolTipText = null;
            this.ch_pass.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.ch_pass_CheckedChanged);
            // 
            // link_show
            // 
            this.link_show.AutoSize = true;
            this.link_show.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_show.Location = new System.Drawing.Point(102, 546);
            this.link_show.Name = "link_show";
            this.link_show.Size = new System.Drawing.Size(172, 31);
            this.link_show.TabIndex = 20;
            this.link_show.TabStop = true;
            this.link_show.Text = "اظهار كلمة السر";
            this.link_show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_show_LinkClicked);
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 827);
            this.Controls.Add(this.link_show);
            this.Controls.Add(this.ch_pass);
            this.Controls.Add(this.edt_pass);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_titlepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titlepage;
        private DevExpress.XtraEditors.SimpleButton pn_close;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.TextBox edt_pass;
        private Bunifu.UI.WinForms.BunifuCheckBox ch_pass;
        private System.Windows.Forms.LinkLabel link_show;
    }
}