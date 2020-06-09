namespace QLTV.GUI.KHO
{
    partial class UC_NCC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NCC));
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.checkTen = new System.Windows.Forms.RadioButton();
            this.checkMa = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvNCC = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteNCC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateNCC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddNCC = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(138, 129);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 25);
            this.txtSDT.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "SDT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(138, 98);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(150, 25);
            this.txtDiaChi.TabIndex = 48;
            // 
            // checkTen
            // 
            this.checkTen.AutoSize = true;
            this.checkTen.Location = new System.Drawing.Point(129, 94);
            this.checkTen.Name = "checkTen";
            this.checkTen.Size = new System.Drawing.Size(84, 21);
            this.checkTen.TabIndex = 56;
            this.checkTen.TabStop = true;
            this.checkTen.Text = "Tên NCC";
            this.checkTen.UseVisualStyleBackColor = true;
            // 
            // checkMa
            // 
            this.checkMa.AutoSize = true;
            this.checkMa.Location = new System.Drawing.Point(129, 67);
            this.checkMa.Name = "checkMa";
            this.checkMa.Size = new System.Drawing.Size(81, 21);
            this.checkMa.TabIndex = 55;
            this.checkMa.TabStop = true;
            this.checkMa.Text = "Mã NCC";
            this.checkMa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tìm theo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NCC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Địa chỉ";
            // 
            // dtgvNCC
            // 
            this.dtgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNCC.Location = new System.Drawing.Point(3, 21);
            this.dtgvNCC.Name = "dtgvNCC";
            this.dtgvNCC.Size = new System.Drawing.Size(729, 167);
            this.dtgvNCC.TabIndex = 0;
            this.dtgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNCC_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvNCC);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 191);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Mời nhập";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(138, 64);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(150, 25);
            this.txtTenNCC.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "Quản Lí Nhà Cung Cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.checkTen);
            this.groupBox1.Controls.Add(this.checkMa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(431, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 184);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(126, 37);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(218, 25);
            this.txtTimKiem.TabIndex = 95;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 30D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(126, 139);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(214, 33);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteNCC
            // 
            this.btnDeleteNCC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteNCC.BorderRadius = 0;
            this.btnDeleteNCC.ButtonText = "Xóa NCC";
            this.btnDeleteNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNCC.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteNCC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteNCC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteNCC.Iconimage")));
            this.btnDeleteNCC.Iconimage_right = null;
            this.btnDeleteNCC.Iconimage_right_Selected = null;
            this.btnDeleteNCC.Iconimage_Selected = null;
            this.btnDeleteNCC.IconMarginLeft = 0;
            this.btnDeleteNCC.IconMarginRight = 0;
            this.btnDeleteNCC.IconRightVisible = true;
            this.btnDeleteNCC.IconRightZoom = 0D;
            this.btnDeleteNCC.IconVisible = true;
            this.btnDeleteNCC.IconZoom = 30D;
            this.btnDeleteNCC.IsTab = false;
            this.btnDeleteNCC.Location = new System.Drawing.Point(296, 244);
            this.btnDeleteNCC.Margin = new System.Windows.Forms.Padding(12);
            this.btnDeleteNCC.Name = "btnDeleteNCC";
            this.btnDeleteNCC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteNCC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteNCC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteNCC.selected = false;
            this.btnDeleteNCC.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteNCC.TabIndex = 94;
            this.btnDeleteNCC.Text = "Xóa NCC";
            this.btnDeleteNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNCC.Textcolor = System.Drawing.Color.White;
            this.btnDeleteNCC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNCC.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên NCC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaNCC);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenNCC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 165);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(138, 30);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(150, 25);
            this.txtMaNCC.TabIndex = 51;
            // 
            // btnHuy
            // 
            this.btnHuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.ButtonText = "Hủy";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHuy.Iconimage")));
            this.btnHuy.Iconimage_right = null;
            this.btnHuy.Iconimage_right_Selected = null;
            this.btnHuy.Iconimage_Selected = null;
            this.btnHuy.IconMarginLeft = 0;
            this.btnHuy.IconMarginRight = 0;
            this.btnHuy.IconRightVisible = true;
            this.btnHuy.IconRightZoom = 0D;
            this.btnHuy.IconVisible = true;
            this.btnHuy.IconZoom = 30D;
            this.btnHuy.IsTab = false;
            this.btnHuy.Location = new System.Drawing.Point(404, 254);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHuy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(98, 30);
            this.btnHuy.TabIndex = 91;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Textcolor = System.Drawing.Color.White;
            this.btnHuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnUpdateNCC
            // 
            this.btnUpdateNCC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateNCC.BorderRadius = 0;
            this.btnUpdateNCC.ButtonText = "Cập Nhật";
            this.btnUpdateNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNCC.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateNCC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateNCC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateNCC.Iconimage")));
            this.btnUpdateNCC.Iconimage_right = null;
            this.btnUpdateNCC.Iconimage_right_Selected = null;
            this.btnUpdateNCC.Iconimage_Selected = null;
            this.btnUpdateNCC.IconMarginLeft = 0;
            this.btnUpdateNCC.IconMarginRight = 0;
            this.btnUpdateNCC.IconRightVisible = true;
            this.btnUpdateNCC.IconRightZoom = 0D;
            this.btnUpdateNCC.IconVisible = true;
            this.btnUpdateNCC.IconZoom = 30D;
            this.btnUpdateNCC.IsTab = false;
            this.btnUpdateNCC.Location = new System.Drawing.Point(181, 244);
            this.btnUpdateNCC.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateNCC.Name = "btnUpdateNCC";
            this.btnUpdateNCC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateNCC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateNCC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateNCC.selected = false;
            this.btnUpdateNCC.Size = new System.Drawing.Size(98, 30);
            this.btnUpdateNCC.TabIndex = 90;
            this.btnUpdateNCC.Text = "Cập Nhật";
            this.btnUpdateNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNCC.Textcolor = System.Drawing.Color.White;
            this.btnUpdateNCC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNCC.Click += new System.EventHandler(this.btnUpdateNCC_Click);
            // 
            // btnAddNCC
            // 
            this.btnAddNCC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNCC.BorderRadius = 0;
            this.btnAddNCC.ButtonText = "Thêm Mới";
            this.btnAddNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNCC.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNCC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNCC.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddNCC.Iconimage")));
            this.btnAddNCC.Iconimage_right = null;
            this.btnAddNCC.Iconimage_right_Selected = null;
            this.btnAddNCC.Iconimage_Selected = null;
            this.btnAddNCC.IconMarginLeft = 0;
            this.btnAddNCC.IconMarginRight = 0;
            this.btnAddNCC.IconRightVisible = true;
            this.btnAddNCC.IconRightZoom = 0D;
            this.btnAddNCC.IconVisible = true;
            this.btnAddNCC.IconZoom = 30D;
            this.btnAddNCC.IsTab = false;
            this.btnAddNCC.Location = new System.Drawing.Point(67, 244);
            this.btnAddNCC.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNCC.Name = "btnAddNCC";
            this.btnAddNCC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNCC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddNCC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddNCC.selected = false;
            this.btnAddNCC.Size = new System.Drawing.Size(98, 30);
            this.btnAddNCC.TabIndex = 89;
            this.btnAddNCC.Text = "Thêm Mới";
            this.btnAddNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNCC.Textcolor = System.Drawing.Color.White;
            this.btnAddNCC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNCC.Click += new System.EventHandler(this.btnAddNCC_Click);
            // 
            // UC_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDeleteNCC);
            this.Controls.Add(this.btnUpdateNCC);
            this.Controls.Add(this.btnAddNCC);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_NCC";
            this.Size = new System.Drawing.Size(828, 598);
            this.Load += new System.EventHandler(this.UC_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton checkTen;
        private System.Windows.Forms.RadioButton checkMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgvNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateNCC;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddNCC;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteNCC;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaNCC;
    }
}
