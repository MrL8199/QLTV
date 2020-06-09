namespace QLTV.GUI.KHO
{
    partial class UC_KiemKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KiemKe));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvKiemKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaPhieuKK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.dtNgayKK = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkNgay = new System.Windows.Forms.RadioButton();
            this.checkMa = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddPKK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.InPKK = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKiemKe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvKiemKe);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(70, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 163);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu Kiểm Kê";
            // 
            // dtgvKiemKe
            // 
            this.dtgvKiemKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKiemKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKiemKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKiemKe.Location = new System.Drawing.Point(3, 21);
            this.dtgvKiemKe.Name = "dtgvKiemKe";
            this.dtgvKiemKe.Size = new System.Drawing.Size(676, 139);
            this.dtgvKiemKe.TabIndex = 0;
            this.dtgvKiemKe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKiemKe_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Phiếu Kiểm Kê";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaPhieuKK);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaKho);
            this.groupBox2.Controls.Add(this.dtNgayKK);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(70, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 187);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin kiểm kê";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMaPhieuKK
            // 
            this.txtMaPhieuKK.Location = new System.Drawing.Point(146, 59);
            this.txtMaPhieuKK.Name = "txtMaPhieuKK";
            this.txtMaPhieuKK.Size = new System.Drawing.Size(150, 25);
            this.txtMaPhieuKK.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Mã Phiếu KK";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(146, 90);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(150, 25);
            this.txtMaKho.TabIndex = 71;
            // 
            // dtNgayKK
            // 
            this.dtNgayKK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKK.Location = new System.Drawing.Point(146, 121);
            this.dtNgayKK.Name = "dtNgayKK";
            this.dtNgayKK.Size = new System.Drawing.Size(150, 25);
            this.dtNgayKK.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày kiểm kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã số kho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Mời nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.checkNgay);
            this.groupBox1.Controls.Add(this.checkMa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(419, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 187);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(109, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 25);
            this.txtTimKiem.TabIndex = 70;
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
            this.btnSearch.Location = new System.Drawing.Point(109, 146);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(177, 29);
            this.btnSearch.TabIndex = 67;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkNgay
            // 
            this.checkNgay.AutoSize = true;
            this.checkNgay.Location = new System.Drawing.Point(109, 113);
            this.checkNgay.Name = "checkNgay";
            this.checkNgay.Size = new System.Drawing.Size(76, 21);
            this.checkNgay.TabIndex = 56;
            this.checkNgay.TabStop = true;
            this.checkNgay.Text = "Ngày kk";
            this.checkNgay.UseVisualStyleBackColor = true;
            // 
            // checkMa
            // 
            this.checkMa.AutoSize = true;
            this.checkMa.Location = new System.Drawing.Point(109, 86);
            this.checkMa.Name = "checkMa";
            this.checkMa.Size = new System.Drawing.Size(99, 21);
            this.checkMa.TabIndex = 55;
            this.checkMa.TabStop = true;
            this.checkMa.Text = "Mã phiếu kk";
            this.checkMa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tìm theo:";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Xóa PKK";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 30D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(382, 274);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(12);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(94, 39);
            this.bunifuFlatButton3.TabIndex = 69;
            this.bunifuFlatButton3.Text = "Xóa PKK";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.btnDeletePKK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Mã NV";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(160, 487);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(149, 26);
            this.txtTenNV.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Tên NV kiểm kê";
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Hủy";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 30D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(513, 274);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(100, 39);
            this.bunifuFlatButton7.TabIndex = 85;
            this.bunifuFlatButton7.Text = "Hủy";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnAddPKK
            // 
            this.btnAddPKK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPKK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPKK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPKK.BorderRadius = 0;
            this.btnAddPKK.ButtonText = "Thêm Mới";
            this.btnAddPKK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPKK.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPKK.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPKK.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPKK.Iconimage")));
            this.btnAddPKK.Iconimage_right = null;
            this.btnAddPKK.Iconimage_right_Selected = null;
            this.btnAddPKK.Iconimage_Selected = null;
            this.btnAddPKK.IconMarginLeft = 0;
            this.btnAddPKK.IconMarginRight = 0;
            this.btnAddPKK.IconRightVisible = true;
            this.btnAddPKK.IconRightZoom = 0D;
            this.btnAddPKK.IconVisible = true;
            this.btnAddPKK.IconZoom = 30D;
            this.btnAddPKK.IsTab = false;
            this.btnAddPKK.Location = new System.Drawing.Point(250, 274);
            this.btnAddPKK.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddPKK.Name = "btnAddPKK";
            this.btnAddPKK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddPKK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddPKK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPKK.selected = false;
            this.btnAddPKK.Size = new System.Drawing.Size(115, 39);
            this.btnAddPKK.TabIndex = 83;
            this.btnAddPKK.Text = "Thêm Mới";
            this.btnAddPKK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPKK.Textcolor = System.Drawing.Color.White;
            this.btnAddPKK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPKK.Click += new System.EventHandler(this.btnAddPKK_Click);
            // 
            // InPKK
            // 
            this.InPKK.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.InPKK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.InPKK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InPKK.BorderRadius = 0;
            this.InPKK.ButtonText = "In PKK";
            this.InPKK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InPKK.DisabledColor = System.Drawing.Color.Gray;
            this.InPKK.Iconcolor = System.Drawing.Color.Transparent;
            this.InPKK.Iconimage = ((System.Drawing.Image)(resources.GetObject("InPKK.Iconimage")));
            this.InPKK.Iconimage_right = null;
            this.InPKK.Iconimage_right_Selected = null;
            this.InPKK.Iconimage_Selected = null;
            this.InPKK.IconMarginLeft = 0;
            this.InPKK.IconMarginRight = 0;
            this.InPKK.IconRightVisible = true;
            this.InPKK.IconRightZoom = 0D;
            this.InPKK.IconVisible = true;
            this.InPKK.IconZoom = 30D;
            this.InPKK.IsTab = false;
            this.InPKK.Location = new System.Drawing.Point(623, 485);
            this.InPKK.Margin = new System.Windows.Forms.Padding(5);
            this.InPKK.Name = "InPKK";
            this.InPKK.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.InPKK.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.InPKK.OnHoverTextColor = System.Drawing.Color.White;
            this.InPKK.selected = false;
            this.InPKK.Size = new System.Drawing.Size(98, 30);
            this.InPKK.TabIndex = 86;
            this.InPKK.Text = "In PKK";
            this.InPKK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InPKK.Textcolor = System.Drawing.Color.White;
            this.InPKK.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InPKK.Click += new System.EventHandler(this.InPKK_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(397, 489);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(149, 26);
            this.txtMaNV.TabIndex = 87;
            // 
            // UC_KiemKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.InPKK);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton7);
            this.Controls.Add(this.btnAddPKK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "UC_KiemKe";
            this.Size = new System.Drawing.Size(822, 598);
            this.Load += new System.EventHandler(this.UC_KiemKe_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKiemKe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvKiemKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtNgayKK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkNgay;
        private System.Windows.Forms.RadioButton checkMa;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPKK;
        private Bunifu.Framework.UI.BunifuFlatButton InPKK;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaPhieuKK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
    }
}
