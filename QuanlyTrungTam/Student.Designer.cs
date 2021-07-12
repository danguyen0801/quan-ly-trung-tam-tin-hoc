﻿namespace QuanlyTrungTam
{
    partial class Student
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TCTT_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DKTL_Button = new System.Windows.Forms.Button();
            this.DKMH_Button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.TCTT_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DKTL_Button);
            this.panel1.Controls.Add(this.DKMH_Button);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 377);
            this.panel1.TabIndex = 1;
            // 
            // TCTT_Button
            // 
            this.TCTT_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.TCTT_Button.BackgroundImage = global::QuanlyTrungTam.Properties.Resources.personal_information;
            this.TCTT_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TCTT_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCTT_Button.Location = new System.Drawing.Point(626, 112);
            this.TCTT_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TCTT_Button.Name = "TCTT_Button";
            this.TCTT_Button.Size = new System.Drawing.Size(146, 187);
            this.TCTT_Button.TabIndex = 4;
            this.TCTT_Button.Text = "Tra cứu thông tin";
            this.TCTT_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TCTT_Button.UseVisualStyleBackColor = false;
            this.TCTT_Button.Click += new System.EventHandler(this.TCTT_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Học viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DKTL_Button
            // 
            this.DKTL_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.DKTL_Button.BackgroundImage = global::QuanlyTrungTam.Properties.Resources.note;
            this.DKTL_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DKTL_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DKTL_Button.Location = new System.Drawing.Point(469, 112);
            this.DKTL_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DKTL_Button.Name = "DKTL_Button";
            this.DKTL_Button.Size = new System.Drawing.Size(132, 187);
            this.DKTL_Button.TabIndex = 2;
            this.DKTL_Button.Text = "Đăng ký thi lại";
            this.DKTL_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DKTL_Button.UseVisualStyleBackColor = false;
            this.DKTL_Button.Click += new System.EventHandler(this.DKTL_Button_Click);
            // 
            // DKMH_Button
            // 
            this.DKMH_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.DKMH_Button.BackgroundImage = global::QuanlyTrungTam.Properties.Resources.bookshelf;
            this.DKMH_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DKMH_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DKMH_Button.Location = new System.Drawing.Point(290, 112);
            this.DKMH_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DKMH_Button.Name = "DKMH_Button";
            this.DKMH_Button.Size = new System.Drawing.Size(146, 187);
            this.DKMH_Button.TabIndex = 1;
            this.DKMH_Button.Text = "Đăng ký môn học";
            this.DKMH_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DKMH_Button.UseVisualStyleBackColor = false;
            this.DKMH_Button.Click += new System.EventHandler(this.DKMH_Button_Click);
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::QuanlyTrungTam.Properties.Resources.student;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(276, 377);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(652, 328);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(108, 38);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "Đăng xuất";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 377);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Student";
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button DKMH_Button;
        private System.Windows.Forms.Button DKTL_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TCTT_Button;
        private System.Windows.Forms.Button logout_button;
    }
}