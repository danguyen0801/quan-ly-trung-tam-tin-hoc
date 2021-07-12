
namespace QuanlyTrungTam
{
    partial class Dang_ki_hoc
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
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.tMaHV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.bDangki = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(490, 441);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(303, 22);
            this.dtpNgaysinh.TabIndex = 43;
            // 
            // tMaHV
            // 
            this.tMaHV.Location = new System.Drawing.Point(484, 91);
            this.tMaHV.Name = "tMaHV";
            this.tMaHV.Size = new System.Drawing.Size(309, 22);
            this.tMaHV.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mã HV";
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioitinh.Location = new System.Drawing.Point(484, 231);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(309, 24);
            this.cbbGioitinh.TabIndex = 40;
            // 
            // bDangki
            // 
            this.bDangki.Location = new System.Drawing.Point(490, 538);
            this.bDangki.Name = "bDangki";
            this.bDangki.Size = new System.Drawing.Size(187, 84);
            this.bDangki.TabIndex = 39;
            this.bDangki.Text = "Đăng kí";
            this.bDangki.UseVisualStyleBackColor = true;
            this.bDangki.Click += new System.EventHandler(this.bDangki_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ngày sinh";
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(484, 361);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(309, 22);
            this.tEmail.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Email";
            // 
            // tSDT
            // 
            this.tSDT.Location = new System.Drawing.Point(484, 297);
            this.tSDT.Name = "tSDT";
            this.tSDT.Size = new System.Drawing.Size(309, 22);
            this.tSDT.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "SDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Giới tính";
            // 
            // tHoten
            // 
            this.tHoten.Location = new System.Drawing.Point(484, 158);
            this.tHoten.Name = "tHoten";
            this.tHoten.Size = new System.Drawing.Size(309, 22);
            this.tHoten.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Họ tên";
            // 
            // Dang_ki_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1032, 711);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.tMaHV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbGioitinh);
            this.Controls.Add(this.bDangki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tHoten);
            this.Controls.Add(this.label1);
            this.Name = "Dang_ki_hoc";
            this.Text = "Dang_ki_hoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox tMaHV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.Button bDangki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tHoten;
        private System.Windows.Forms.Label label1;
    }
}