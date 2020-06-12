namespace QLTV.GUI.MainForm
{
    partial class Form1
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
            this.btn_QL_Sach = new System.Windows.Forms.Button();
            this.btn_QL_DocGia = new System.Windows.Forms.Button();
            this.btn_QL_Kho = new System.Windows.Forms.Button();
            this.btn_QL_MuonTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QL_Sach
            // 
            this.btn_QL_Sach.Location = new System.Drawing.Point(64, 67);
            this.btn_QL_Sach.Name = "btn_QL_Sach";
            this.btn_QL_Sach.Size = new System.Drawing.Size(206, 69);
            this.btn_QL_Sach.TabIndex = 0;
            this.btn_QL_Sach.Text = "Quản Lý Sách";
            this.btn_QL_Sach.UseVisualStyleBackColor = true;
            this.btn_QL_Sach.Click += new System.EventHandler(this.btn_QL_Sach_Click);
            // 
            // btn_QL_DocGia
            // 
            this.btn_QL_DocGia.Location = new System.Drawing.Point(289, 67);
            this.btn_QL_DocGia.Name = "btn_QL_DocGia";
            this.btn_QL_DocGia.Size = new System.Drawing.Size(206, 69);
            this.btn_QL_DocGia.TabIndex = 0;
            this.btn_QL_DocGia.Text = "Quản Lý Độc Giả";
            this.btn_QL_DocGia.UseVisualStyleBackColor = true;
            this.btn_QL_DocGia.Click += new System.EventHandler(this.btn_QL_DocGia_Click);
            // 
            // btn_QL_Kho
            // 
            this.btn_QL_Kho.Location = new System.Drawing.Point(289, 142);
            this.btn_QL_Kho.Name = "btn_QL_Kho";
            this.btn_QL_Kho.Size = new System.Drawing.Size(206, 69);
            this.btn_QL_Kho.TabIndex = 0;
            this.btn_QL_Kho.Text = "Quản Lý Kho";
            this.btn_QL_Kho.UseVisualStyleBackColor = true;
            this.btn_QL_Kho.Click += new System.EventHandler(this.btn_QL_Kho_Click);
            // 
            // btn_QL_MuonTra
            // 
            this.btn_QL_MuonTra.Location = new System.Drawing.Point(64, 142);
            this.btn_QL_MuonTra.Name = "btn_QL_MuonTra";
            this.btn_QL_MuonTra.Size = new System.Drawing.Size(206, 69);
            this.btn_QL_MuonTra.TabIndex = 0;
            this.btn_QL_MuonTra.Text = "Quản Lý Mượn Trả";
            this.btn_QL_MuonTra.UseVisualStyleBackColor = true;
            this.btn_QL_MuonTra.Click += new System.EventHandler(this.btn_QL_MuonTra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 297);
            this.Controls.Add(this.btn_QL_MuonTra);
            this.Controls.Add(this.btn_QL_Kho);
            this.Controls.Add(this.btn_QL_DocGia);
            this.Controls.Add(this.btn_QL_Sach);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QL_Sach;
        private System.Windows.Forms.Button btn_QL_DocGia;
        private System.Windows.Forms.Button btn_QL_Kho;
        private System.Windows.Forms.Button btn_QL_MuonTra;
    }
}