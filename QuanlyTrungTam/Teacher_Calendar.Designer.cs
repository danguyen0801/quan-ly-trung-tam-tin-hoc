
namespace QuanlyTrungTam
{
    partial class Teacher_Calendar
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
            this.Scores_Button = new System.Windows.Forms.Button();
            this.Schedule_Button = new System.Windows.Forms.Button();
            this.Scores = new System.Windows.Forms.PictureBox();
            this.Schedule = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.Scores_Button);
            this.panel1.Controls.Add(this.Scores);
            this.panel1.Controls.Add(this.Schedule_Button);
            this.panel1.Controls.Add(this.Schedule);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 99);
            this.panel1.TabIndex = 1;
            // 
            // Scores_Button
            // 
            this.Scores_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.Scores_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores_Button.Location = new System.Drawing.Point(413, 68);
            this.Scores_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Scores_Button.Name = "Scores_Button";
            this.Scores_Button.Size = new System.Drawing.Size(119, 28);
            this.Scores_Button.TabIndex = 9;
            this.Scores_Button.Text = "Nhập điểm";
            this.Scores_Button.UseVisualStyleBackColor = false;
            // 
            // Schedule_Button
            // 
            this.Schedule_Button.AutoEllipsis = true;
            this.Schedule_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.Schedule_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schedule_Button.Location = new System.Drawing.Point(171, 68);
            this.Schedule_Button.Name = "Schedule_Button";
            this.Schedule_Button.Size = new System.Drawing.Size(132, 28);
            this.Schedule_Button.TabIndex = 5;
            this.Schedule_Button.Text = "Thời khóa biểu";
            this.Schedule_Button.UseVisualStyleBackColor = false;
            // 
            // Scores
            // 
            this.Scores.Image = global::QuanlyTrungTam.Properties.Resources.score_input;
            this.Scores.Location = new System.Drawing.Point(449, 11);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(52, 57);
            this.Scores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scores.TabIndex = 6;
            this.Scores.TabStop = false;
            // 
            // Schedule
            // 
            this.Schedule.Image = global::QuanlyTrungTam.Properties.Resources.schedule;
            this.Schedule.Location = new System.Drawing.Point(208, 11);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(52, 57);
            this.Schedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Schedule.TabIndex = 1;
            this.Schedule.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(286, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "THỜI KHÓA BIỂU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCode,
            this.Subject_Name,
            this.Subject_Time,
            this.Number_Subject});
            this.dataGridView1.Location = new System.Drawing.Point(152, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 295);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // SubjectCode
            // 
            this.SubjectCode.HeaderText = "Mã Môn";
            this.SubjectCode.Name = "SubjectCode";
            // 
            // Subject_Name
            // 
            this.Subject_Name.HeaderText = "Tên Môn";
            this.Subject_Name.Name = "Subject_Name";
            // 
            // Subject_Time
            // 
            this.Subject_Time.HeaderText = "Thời Gian";
            this.Subject_Time.Name = "Subject_Time";
            // 
            // Number_Subject
            // 
            this.Number_Subject.HeaderText = "Số Tín Chỉ";
            this.Number_Subject.Name = "Number_Subject";
            // 
            // Teacher_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Teacher_Calendar";
            this.Text = "Teacher_Calendar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Scores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Scores_Button;
        private System.Windows.Forms.PictureBox Scores;
        private System.Windows.Forms.Button Schedule_Button;
        private System.Windows.Forms.PictureBox Schedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_Subject;
    }
}