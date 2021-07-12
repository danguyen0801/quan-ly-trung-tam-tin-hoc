
namespace QuanlyTrungTam
{
    partial class LapLichThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.malophpcbx = new System.Windows.Forms.ComboBox();
            this.manvcbx = new System.Windows.Forms.ComboBox();
            this.malichthitxt = new System.Windows.Forms.TextBox();
            this.phongthitxt = new System.Windows.Forms.TextBox();
            this.thoigianthitxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch thi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên";
            // 
            // malophpcbx
            // 
            this.malophpcbx.FormattingEnabled = true;
            this.malophpcbx.Location = new System.Drawing.Point(609, 61);
            this.malophpcbx.Name = "malophpcbx";
            this.malophpcbx.Size = new System.Drawing.Size(100, 24);
            this.malophpcbx.TabIndex = 5;
            // 
            // manvcbx
            // 
            this.manvcbx.FormattingEnabled = true;
            this.manvcbx.Location = new System.Drawing.Point(219, 202);
            this.manvcbx.Name = "manvcbx";
            this.manvcbx.Size = new System.Drawing.Size(100, 24);
            this.manvcbx.TabIndex = 6;
            // 
            // malichthitxt
            // 
            this.malichthitxt.Location = new System.Drawing.Point(219, 61);
            this.malichthitxt.Name = "malichthitxt";
            this.malichthitxt.Size = new System.Drawing.Size(100, 22);
            this.malichthitxt.TabIndex = 7;
            // 
            // phongthitxt
            // 
            this.phongthitxt.Location = new System.Drawing.Point(219, 130);
            this.phongthitxt.Name = "phongthitxt";
            this.phongthitxt.Size = new System.Drawing.Size(100, 22);
            this.phongthitxt.TabIndex = 8;
            // 
            // thoigianthitxt
            // 
            this.thoigianthitxt.Location = new System.Drawing.Point(609, 130);
            this.thoigianthitxt.Name = "thoigianthitxt";
            this.thoigianthitxt.Size = new System.Drawing.Size(100, 22);
            this.thoigianthitxt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(592, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LapLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thoigianthitxt);
            this.Controls.Add(this.phongthitxt);
            this.Controls.Add(this.malichthitxt);
            this.Controls.Add(this.manvcbx);
            this.Controls.Add(this.malophpcbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LapLichThi";
            this.Text = "LapLichThi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox malophpcbx;
        private System.Windows.Forms.ComboBox manvcbx;
        private System.Windows.Forms.TextBox malichthitxt;
        private System.Windows.Forms.TextBox phongthitxt;
        private System.Windows.Forms.TextBox thoigianthitxt;
        private System.Windows.Forms.Button button1;
    }
}