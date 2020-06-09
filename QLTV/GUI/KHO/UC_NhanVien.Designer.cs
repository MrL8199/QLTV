namespace QLTV.GUI.KHO
{
    partial class UC_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NhanVien));
            this.checkTen = new System.Windows.Forms.RadioButton();
            this.checkMa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteNV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateNV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddNV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkTen
            // 
            this.checkTen.AutoSize = true;
            this.checkTen.Location = new System.Drawing.Point(126, 105);
            this.checkTen.Name = "checkTen";
            this.checkTen.Size = new System.Drawing.Size(109, 21);
            this.checkTen.TabIndex = 48;
            this.checkTen.TabStop = true;
            this.checkTen.Text = "Tên nhân viên";
            this.checkTen.UseVisualStyleBackColor = true;
            // 
            // checkMa
            // 
            this.checkMa.AutoSize = true;
            this.checkMa.Location = new System.Drawing.Point(126, 78);
            this.checkMa.Name = "checkMa";
            this.checkMa.Size = new System.Drawing.Size(106, 21);
            this.checkMa.TabIndex = 47;
            this.checkMa.TabStop = true;
            this.checkMa.Text = "Mã nhân viên";
            this.checkMa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tìm theo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.checkTen);
            this.groupBox1.Controls.Add(this.checkMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(423, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 194);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(126, 36);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(218, 25);
            this.txtTimKiem.TabIndex = 67;
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
            this.btnSearch.Location = new System.Drawing.Point(126, 146);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(216, 32);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mời nhập";
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteNV.BorderRadius = 0;
            this.btnDeleteNV.ButtonText = "Xóa NV";
            this.btnDeleteNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNV.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteNV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteNV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteNV.Iconimage")));
            this.btnDeleteNV.Iconimage_right = null;
            this.btnDeleteNV.Iconimage_right_Selected = null;
            this.btnDeleteNV.Iconimage_Selected = null;
            this.btnDeleteNV.IconMarginLeft = 0;
            this.btnDeleteNV.IconMarginRight = 0;
            this.btnDeleteNV.IconRightVisible = true;
            this.btnDeleteNV.IconRightZoom = 0D;
            this.btnDeleteNV.IconVisible = true;
            this.btnDeleteNV.IconZoom = 30D;
            this.btnDeleteNV.IsTab = false;
            this.btnDeleteNV.Location = new System.Drawing.Point(294, 225);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(9);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteNV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteNV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteNV.selected = false;
            this.btnDeleteNV.Size = new System.Drawing.Size(93, 32);
            this.btnDeleteNV.TabIndex = 66;
            this.btnDeleteNV.Text = "Xóa NV";
            this.btnDeleteNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Textcolor = System.Drawing.Color.White;
            this.btnDeleteNV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(129, 51);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(150, 25);
            this.txtTenNV.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên NV";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvNhanVien);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(40, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 191);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNhanVien.Location = new System.Drawing.Point(3, 21);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.Size = new System.Drawing.Size(729, 167);
            this.dtgvNhanVien.TabIndex = 0;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Mã Kho";
            // 
            // txtMaKho
            // 
            this.txtMaKho.FormattingEnabled = true;
            this.txtMaKho.Location = new System.Drawing.Point(129, 82);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(150, 25);
            this.txtMaKho.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quản Lí Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMaKho);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 136);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(129, 18);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(150, 25);
            this.txtMaNV.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mã NV";
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
            this.btnHuy.Location = new System.Drawing.Point(178, 267);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHuy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(98, 30);
            this.btnHuy.TabIndex = 88;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Textcolor = System.Drawing.Color.White;
            this.btnHuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateNV.BorderRadius = 0;
            this.btnUpdateNV.ButtonText = "Cập Nhật";
            this.btnUpdateNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNV.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateNV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateNV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateNV.Iconimage")));
            this.btnUpdateNV.Iconimage_right = null;
            this.btnUpdateNV.Iconimage_right_Selected = null;
            this.btnUpdateNV.Iconimage_Selected = null;
            this.btnUpdateNV.IconMarginLeft = 0;
            this.btnUpdateNV.IconMarginRight = 0;
            this.btnUpdateNV.IconRightVisible = true;
            this.btnUpdateNV.IconRightZoom = 0D;
            this.btnUpdateNV.IconVisible = true;
            this.btnUpdateNV.IconZoom = 30D;
            this.btnUpdateNV.IsTab = false;
            this.btnUpdateNV.Location = new System.Drawing.Point(178, 227);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdateNV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdateNV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateNV.selected = false;
            this.btnUpdateNV.Size = new System.Drawing.Size(98, 30);
            this.btnUpdateNV.TabIndex = 87;
            this.btnUpdateNV.Text = "Cập Nhật";
            this.btnUpdateNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNV.Textcolor = System.Drawing.Color.White;
            this.btnUpdateNV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNV.BorderRadius = 0;
            this.btnAddNV.ButtonText = "Thêm Mới";
            this.btnAddNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNV.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddNV.Iconimage")));
            this.btnAddNV.Iconimage_right = null;
            this.btnAddNV.Iconimage_right_Selected = null;
            this.btnAddNV.Iconimage_Selected = null;
            this.btnAddNV.IconMarginLeft = 0;
            this.btnAddNV.IconMarginRight = 0;
            this.btnAddNV.IconRightVisible = true;
            this.btnAddNV.IconRightZoom = 0D;
            this.btnAddNV.IconVisible = true;
            this.btnAddNV.IconZoom = 30D;
            this.btnAddNV.IsTab = false;
            this.btnAddNV.Location = new System.Drawing.Point(64, 227);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddNV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddNV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddNV.selected = false;
            this.btnAddNV.Size = new System.Drawing.Size(98, 30);
            this.btnAddNV.TabIndex = 86;
            this.btnAddNV.Text = "Thêm Mới";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Textcolor = System.Drawing.Color.White;
            this.btnAddNV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(822, 598);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton checkTen;
        private System.Windows.Forms.RadioButton checkMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtMaKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteNV;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateNV;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddNV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
    }
}
