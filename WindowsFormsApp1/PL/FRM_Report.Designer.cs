namespace WindowsFormsApp1.PL
{
    partial class FRM_Report 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Report));
            this.pn_report = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Re_supp = new System.Windows.Forms.Button();
            this.Re_cus = new System.Windows.Forms.Button();
            this.Re_pur = new System.Windows.Forms.Button();
            this.Re_sell = new System.Windows.Forms.Button();
            this.pn_report.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_report
            // 
            this.pn_report.Controls.Add(this.panel1);
            this.pn_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_report.Location = new System.Drawing.Point(0, 0);
            this.pn_report.Name = "pn_report";
            this.pn_report.Size = new System.Drawing.Size(1209, 636);
            this.pn_report.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Re_sell);
            this.panel1.Controls.Add(this.Re_pur);
            this.panel1.Controls.Add(this.Re_cus);
            this.panel1.Controls.Add(this.Re_supp);
            this.panel1.Location = new System.Drawing.Point(152, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 209);
            this.panel1.TabIndex = 0;
            // 
            // Re_supp
            // 
            this.Re_supp.FlatAppearance.BorderSize = 0;
            this.Re_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Re_supp.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Re_supp.Image = ((System.Drawing.Image)(resources.GetObject("Re_supp.Image")));
            this.Re_supp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Re_supp.Location = new System.Drawing.Point(707, 21);
            this.Re_supp.Name = "Re_supp";
            this.Re_supp.Size = new System.Drawing.Size(176, 169);
            this.Re_supp.TabIndex = 1;
            this.Re_supp.Text = "تقرير الموردين";
            this.Re_supp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Re_supp.UseVisualStyleBackColor = true;
            this.Re_supp.Click += new System.EventHandler(this.Re_supp_Click);
            // 
            // Re_cus
            // 
            this.Re_cus.FlatAppearance.BorderSize = 0;
            this.Re_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Re_cus.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Re_cus.Image = ((System.Drawing.Image)(resources.GetObject("Re_cus.Image")));
            this.Re_cus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Re_cus.Location = new System.Drawing.Point(482, 21);
            this.Re_cus.Name = "Re_cus";
            this.Re_cus.Size = new System.Drawing.Size(176, 169);
            this.Re_cus.TabIndex = 1;
            this.Re_cus.Text = "تقرير العملاء";
            this.Re_cus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Re_cus.UseVisualStyleBackColor = true;
            this.Re_cus.Click += new System.EventHandler(this.Re_cus_Click);
            // 
            // Re_pur
            // 
            this.Re_pur.FlatAppearance.BorderSize = 0;
            this.Re_pur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Re_pur.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Re_pur.Image = ((System.Drawing.Image)(resources.GetObject("Re_pur.Image")));
            this.Re_pur.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Re_pur.Location = new System.Drawing.Point(257, 21);
            this.Re_pur.Name = "Re_pur";
            this.Re_pur.Size = new System.Drawing.Size(176, 169);
            this.Re_pur.TabIndex = 1;
            this.Re_pur.Text = "تقرير المشتريات";
            this.Re_pur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Re_pur.UseVisualStyleBackColor = true;
            this.Re_pur.Click += new System.EventHandler(this.Re_pur_Click);
            // 
            // Re_sell
            // 
            this.Re_sell.FlatAppearance.BorderSize = 0;
            this.Re_sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Re_sell.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Re_sell.Image = ((System.Drawing.Image)(resources.GetObject("Re_sell.Image")));
            this.Re_sell.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Re_sell.Location = new System.Drawing.Point(32, 21);
            this.Re_sell.Name = "Re_sell";
            this.Re_sell.Size = new System.Drawing.Size(176, 169);
            this.Re_sell.TabIndex = 1;
            this.Re_sell.Text = "تقرير المبيعات";
            this.Re_sell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Re_sell.UseVisualStyleBackColor = true;
            this.Re_sell.Click += new System.EventHandler(this.Re_sell_Click);
            // 
            // FRM_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 636);
            this.Controls.Add(this.pn_report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Report";
            this.Text = "FRM_CAT";
            this.pn_report.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pn_report;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Re_sell;
        private System.Windows.Forms.Button Re_pur;
        private System.Windows.Forms.Button Re_cus;
        private System.Windows.Forms.Button Re_supp;
    }
}