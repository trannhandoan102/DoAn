namespace DoAn_One
{
    partial class frmDoiMK
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
            this.lbmini = new System.Windows.Forms.Label();
            this.lbexit = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNhapLaiPass = new System.Windows.Forms.TextBox();
            this.pbMatKhau = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.pbTaiKhoan = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassCu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.erpDoiMK = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDoiMK)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmini
            // 
            this.lbmini.AutoSize = true;
            this.lbmini.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmini.ForeColor = System.Drawing.Color.White;
            this.lbmini.Location = new System.Drawing.Point(710, -1);
            this.lbmini.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmini.Name = "lbmini";
            this.lbmini.Size = new System.Drawing.Size(28, 39);
            this.lbmini.TabIndex = 30;
            this.lbmini.Text = "-";
            // 
            // lbexit
            // 
            this.lbexit.AutoSize = true;
            this.lbexit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexit.ForeColor = System.Drawing.Color.White;
            this.lbexit.Location = new System.Drawing.Point(760, 10);
            this.lbexit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbexit.Name = "lbexit";
            this.lbexit.Size = new System.Drawing.Size(23, 27);
            this.lbexit.TabIndex = 29;
            this.lbexit.Text = "x";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(149, 539);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(164, 50);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(240, 475);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 1);
            this.panel2.TabIndex = 27;
            // 
            // txtNhapLaiPass
            // 
            this.txtNhapLaiPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtNhapLaiPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNhapLaiPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiPass.ForeColor = System.Drawing.Color.White;
            this.txtNhapLaiPass.HideSelection = false;
            this.txtNhapLaiPass.Location = new System.Drawing.Point(287, 445);
            this.txtNhapLaiPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapLaiPass.Name = "txtNhapLaiPass";
            this.txtNhapLaiPass.Size = new System.Drawing.Size(239, 23);
            this.txtNhapLaiPass.TabIndex = 26;
            this.txtNhapLaiPass.TabStop = false;
            this.txtNhapLaiPass.Text = "Nhập lại mật khẩu";
            this.txtNhapLaiPass.Click += new System.EventHandler(this.txtNhapLaiPass_Click);
            // 
            // pbMatKhau
            // 
            this.pbMatKhau.Image = global::DoAn_One.Properties.Resources.clockUser_32;
            this.pbMatKhau.Location = new System.Drawing.Point(239, 431);
            this.pbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.pbMatKhau.Name = "pbMatKhau";
            this.pbMatKhau.Size = new System.Drawing.Size(40, 37);
            this.pbMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMatKhau.TabIndex = 25;
            this.pbMatKhau.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(239, 388);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 1);
            this.panel1.TabIndex = 24;
            // 
            // txtPassNew
            // 
            this.txtPassNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassNew.ForeColor = System.Drawing.Color.White;
            this.txtPassNew.HideSelection = false;
            this.txtPassNew.Location = new System.Drawing.Point(293, 357);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(239, 23);
            this.txtPassNew.TabIndex = 23;
            this.txtPassNew.TabStop = false;
            this.txtPassNew.Text = "Mật khẩu mới";
            this.txtPassNew.Click += new System.EventHandler(this.txtPassNew_Click);
            // 
            // pbTaiKhoan
            // 
            this.pbTaiKhoan.Image = global::DoAn_One.Properties.Resources.Users;
            this.pbTaiKhoan.Location = new System.Drawing.Point(237, 344);
            this.pbTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.pbTaiKhoan.Name = "pbTaiKhoan";
            this.pbTaiKhoan.Size = new System.Drawing.Size(40, 37);
            this.pbTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTaiKhoan.TabIndex = 22;
            this.pbTaiKhoan.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(240, 298);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 1);
            this.panel3.TabIndex = 37;
            // 
            // txtPassCu
            // 
            this.txtPassCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCu.ForeColor = System.Drawing.Color.White;
            this.txtPassCu.HideSelection = false;
            this.txtPassCu.Location = new System.Drawing.Point(287, 268);
            this.txtPassCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassCu.Name = "txtPassCu";
            this.txtPassCu.Size = new System.Drawing.Size(239, 23);
            this.txtPassCu.TabIndex = 36;
            this.txtPassCu.TabStop = false;
            this.txtPassCu.Text = "Mật khẩu cũ";
            this.txtPassCu.Click += new System.EventHandler(this.txtPassCu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_One.Properties.Resources.clockUser_32;
            this.pictureBox1.Location = new System.Drawing.Point(239, 254);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(239, 211);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 1);
            this.panel4.TabIndex = 34;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txtTaiKhoan.HideSelection = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(293, 180);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(239, 23);
            this.txtTaiKhoan.TabIndex = 33;
            this.txtTaiKhoan.TabStop = false;
            this.txtTaiKhoan.Text = "Tài khoản";
            this.txtTaiKhoan.Click += new System.EventHandler(this.txtTaiKhoan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAn_One.Properties.Resources.Users;
            this.pictureBox2.Location = new System.Drawing.Point(237, 167);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(446, 538);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 51);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(262, 47);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 66);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "Đổi Mật Khẩu";
            // 
            // erpDoiMK
            // 
            this.erpDoiMK.ContainerControl = this;
            // 
            // frmDoiMK
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 641);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPassCu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbmini);
            this.Controls.Add(this.lbexit);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNhapLaiPass);
            this.Controls.Add(this.pbMatKhau);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.pbTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMK";
            this.Text = "frmDoiMK";
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDoiMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbmini;
        private System.Windows.Forms.Label lbexit;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNhapLaiPass;
        private System.Windows.Forms.PictureBox pbMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.PictureBox pbTaiKhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassCu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ErrorProvider erpDoiMK;
    }
}