namespace BaiTapLon_Nhom9
{
    partial class frmQuanLy
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTaiKhoan = new System.Windows.Forms.TabPage();
            this.tpThongTinSV = new System.Windows.Forms.TabPage();
            this.tpPhong = new System.Windows.Forms.TabPage();
            this.tpHopDong = new System.Windows.Forms.TabPage();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTaiKhoan);
            this.tabControl1.Controls.Add(this.tpThongTinSV);
            this.tabControl1.Controls.Add(this.tpPhong);
            this.tabControl1.Controls.Add(this.tpHopDong);
            this.tabControl1.Controls.Add(this.tpHoaDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTaiKhoan
            // 
            this.tpTaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.tpTaiKhoan.Name = "tpTaiKhoan";
            this.tpTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpTaiKhoan.Size = new System.Drawing.Size(792, 421);
            this.tpTaiKhoan.TabIndex = 0;
            this.tpTaiKhoan.Text = "Tài khoản";
            this.tpTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tpThongTinSV
            // 
            this.tpThongTinSV.Location = new System.Drawing.Point(4, 25);
            this.tpThongTinSV.Name = "tpThongTinSV";
            this.tpThongTinSV.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinSV.Size = new System.Drawing.Size(792, 421);
            this.tpThongTinSV.TabIndex = 1;
            this.tpThongTinSV.Text = "Thông tin sinh viên";
            this.tpThongTinSV.UseVisualStyleBackColor = true;
            // 
            // tpPhong
            // 
            this.tpPhong.Location = new System.Drawing.Point(4, 25);
            this.tpPhong.Name = "tpPhong";
            this.tpPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhong.Size = new System.Drawing.Size(792, 421);
            this.tpPhong.TabIndex = 2;
            this.tpPhong.Text = "Phòng";
            this.tpPhong.UseVisualStyleBackColor = true;
            // 
            // tpHopDong
            // 
            this.tpHopDong.Controls.Add(this.dataGridView1);
            this.tpHopDong.Location = new System.Drawing.Point(4, 25);
            this.tpHopDong.Name = "tpHopDong";
            this.tpHopDong.Padding = new System.Windows.Forms.Padding(3);
            this.tpHopDong.Size = new System.Drawing.Size(792, 421);
            this.tpHopDong.TabIndex = 3;
            this.tpHopDong.Text = "Hợp đồng";
            this.tpHopDong.UseVisualStyleBackColor = true;
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoaDon.Size = new System.Drawing.Size(792, 421);
            this.tpHoaDon.TabIndex = 4;
            this.tpHoaDon.Text = "Hóa đơn";
            this.tpHoaDon.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý ";
            this.tabControl1.ResumeLayout(false);
            this.tpHopDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.TabPage tpThongTinSV;
        private System.Windows.Forms.TabPage tpPhong;
        private System.Windows.Forms.TabPage tpHopDong;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}