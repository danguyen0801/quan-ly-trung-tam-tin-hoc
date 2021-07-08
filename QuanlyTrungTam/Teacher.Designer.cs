namespace QuanlyTrungTam
{
    partial class Teacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.Score_input_Button = new System.Windows.Forms.Button();
            this.Schedule_Button = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Score_input_Button);
            this.panel1.Controls.Add(this.Schedule_Button);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 366);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giáo viên";
            // 
            // Score_input_Button
            // 
            this.Score_input_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.Score_input_Button.BackgroundImage = global::QuanlyTrungTam.Properties.Resources.score_input;
            this.Score_input_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Score_input_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_input_Button.Location = new System.Drawing.Point(546, 112);
            this.Score_input_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Score_input_Button.Name = "Score_input_Button";
            this.Score_input_Button.Size = new System.Drawing.Size(132, 187);
            this.Score_input_Button.TabIndex = 2;
            this.Score_input_Button.Text = "Nhập điểm";
            this.Score_input_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Score_input_Button.UseVisualStyleBackColor = false;
            // 
            // Schedule_Button
            // 
            this.Schedule_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.Schedule_Button.BackgroundImage = global::QuanlyTrungTam.Properties.Resources.schedule;
            this.Schedule_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Schedule_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_Button.Location = new System.Drawing.Point(351, 112);
            this.Schedule_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule_Button.Name = "Schedule_Button";
            this.Schedule_Button.Size = new System.Drawing.Size(146, 187);
            this.Schedule_Button.TabIndex = 1;
            this.Schedule_Button.Text = "Xem thời khóa biểu";
            this.Schedule_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Schedule_Button.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = global::QuanlyTrungTam.Properties.Resources.teacher;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(276, 366);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Score_input_Button;
        private System.Windows.Forms.Button Schedule_Button;
        private System.Windows.Forms.PictureBox logo;
    }
}