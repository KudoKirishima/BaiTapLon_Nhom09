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
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemhd = new System.Windows.Forms.Button();
            this.btSuahd = new System.Windows.Forms.Button();
            this.btXoahd = new System.Windows.Forms.Button();
            this.btInhd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tpHopDong.Controls.Add(this.panel3);
            this.tpHopDong.Controls.Add(this.panel2);
            this.tpHopDong.Controls.Add(this.panel1);
            this.tpHopDong.Location = new System.Drawing.Point(4, 25);
            this.tpHopDong.Name = "tpHopDong";
            this.tpHopDong.Padding = new System.Windows.Forms.Padding(3);
            this.tpHopDong.Size = new System.Drawing.Size(792, 421);
            this.tpHopDong.TabIndex = 3;
            this.tpHopDong.Text = "Hợp đồng";
            this.tpHopDong.UseVisualStyleBackColor = true;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(0, 0);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 57;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(786, 303);
            this.dgvHopDong.TabIndex = 0;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã hợp đồng";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên hợp đồng";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tên sinh viên ";
            this.Column3.MinimumWidth = 7;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Mã sinh viên ";
            this.Column4.MinimumWidth = 7;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Số phòng";
            this.Column5.MinimumWidth = 7;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Ngày lập ";
            this.Column6.MinimumWidth = 7;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Ngày hết hạn ";
            this.Column7.MinimumWidth = 7;
            this.Column7.Name = "Column7";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 56);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btInhd);
            this.panel2.Controls.Add(this.btXoahd);
            this.panel2.Controls.Add(this.btSuahd);
            this.panel2.Controls.Add(this.btThemhd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 56);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvHopDong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 303);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hợp đồng";
            // 
            // btThemhd
            // 
            this.btThemhd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThemhd.BackColor = System.Drawing.Color.DimGray;
            this.btThemhd.Location = new System.Drawing.Point(73, 6);
            this.btThemhd.Name = "btThemhd";
            this.btThemhd.Size = new System.Drawing.Size(80, 45);
            this.btThemhd.TabIndex = 0;
            this.btThemhd.Text = "Thêm";
            this.btThemhd.UseVisualStyleBackColor = false;
            this.btThemhd.Click += new System.EventHandler(this.btThemhd_Click);
            // 
            // btSuahd
            // 
            this.btSuahd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSuahd.BackColor = System.Drawing.Color.DimGray;
            this.btSuahd.Location = new System.Drawing.Point(258, 6);
            this.btSuahd.Name = "btSuahd";
            this.btSuahd.Size = new System.Drawing.Size(80, 45);
            this.btSuahd.TabIndex = 1;
            this.btSuahd.Text = "Sửa";
            this.btSuahd.UseVisualStyleBackColor = false;
            // 
            // btXoahd
            // 
            this.btXoahd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoahd.BackColor = System.Drawing.Color.DimGray;
            this.btXoahd.Location = new System.Drawing.Point(443, 6);
            this.btXoahd.Name = "btXoahd";
            this.btXoahd.Size = new System.Drawing.Size(80, 45);
            this.btXoahd.TabIndex = 2;
            this.btXoahd.Text = "Xóa";
            this.btXoahd.UseVisualStyleBackColor = false;
            // 
            // btInhd
            // 
            this.btInhd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInhd.BackColor = System.Drawing.Color.DimGray;
            this.btInhd.Location = new System.Drawing.Point(628, 6);
            this.btInhd.Name = "btInhd";
            this.btInhd.Size = new System.Drawing.Size(80, 45);
            this.btInhd.TabIndex = 3;
            this.btInhd.Text = "In";
            this.btInhd.UseVisualStyleBackColor = false;
            this.btInhd.Click += new System.EventHandler(this.btInhd_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTaiKhoan;
        private System.Windows.Forms.TabPage tpThongTinSV;
        private System.Windows.Forms.TabPage tpPhong;
        private System.Windows.Forms.TabPage tpHopDong;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btThemhd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoahd;
        private System.Windows.Forms.Button btSuahd;
        private System.Windows.Forms.Button btInhd;
    }
}