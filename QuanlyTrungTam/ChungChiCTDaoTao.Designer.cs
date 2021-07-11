
namespace QuanlyTrungTam
{
    partial class ChungChiCTDaoTao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dschungchictdaotao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.luubtn = new System.Windows.Forms.Button();
            this.mahvcbx = new System.Windows.Forms.ComboBox();
            this.mactcbx = new System.Windows.Forms.ComboBox();
            this.machungchitxt = new System.Windows.Forms.TextBox();
            this.ngaycaptxt = new System.Windows.Forms.TextBox();
            this.xeploaitxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dschungchictdaotao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dschungchictdaotao);
            this.groupBox1.Location = new System.Drawing.Point(-3, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chứng chỉ chương trình đào tạo";
            // 
            // dschungchictdaotao
            // 
            this.dschungchictdaotao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dschungchictdaotao.Location = new System.Drawing.Point(0, 21);
            this.dschungchictdaotao.Name = "dschungchictdaotao";
            this.dschungchictdaotao.RowHeadersWidth = 51;
            this.dschungchictdaotao.RowTemplate.Height = 24;
            this.dschungchictdaotao.Size = new System.Drawing.Size(806, 257);
            this.dschungchictdaotao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chứng chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã chương trình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã học viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Xếp loại";
            // 
            // luubtn
            // 
            this.luubtn.BackColor = System.Drawing.Color.DarkCyan;
            this.luubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luubtn.Location = new System.Drawing.Point(588, 123);
            this.luubtn.Name = "luubtn";
            this.luubtn.Size = new System.Drawing.Size(100, 37);
            this.luubtn.TabIndex = 6;
            this.luubtn.Text = "Lưu";
            this.luubtn.UseVisualStyleBackColor = false;
            this.luubtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mahvcbx
            // 
            this.mahvcbx.FormattingEnabled = true;
            this.mahvcbx.Location = new System.Drawing.Point(588, 19);
            this.mahvcbx.Name = "mahvcbx";
            this.mahvcbx.Size = new System.Drawing.Size(100, 24);
            this.mahvcbx.TabIndex = 7;
            this.mahvcbx.SelectedIndexChanged += new System.EventHandler(this.mahvcbx_SelectedIndexChanged);
            // 
            // mactcbx
            // 
            this.mactcbx.FormattingEnabled = true;
            this.mactcbx.Location = new System.Drawing.Point(200, 120);
            this.mactcbx.Name = "mactcbx";
            this.mactcbx.Size = new System.Drawing.Size(100, 24);
            this.mactcbx.TabIndex = 8;
            // 
            // machungchitxt
            // 
            this.machungchitxt.Location = new System.Drawing.Point(200, 19);
            this.machungchitxt.Name = "machungchitxt";
            this.machungchitxt.Size = new System.Drawing.Size(100, 22);
            this.machungchitxt.TabIndex = 9;
            // 
            // ngaycaptxt
            // 
            this.ngaycaptxt.Location = new System.Drawing.Point(200, 68);
            this.ngaycaptxt.Name = "ngaycaptxt";
            this.ngaycaptxt.Size = new System.Drawing.Size(100, 22);
            this.ngaycaptxt.TabIndex = 10;
            // 
            // xeploaitxt
            // 
            this.xeploaitxt.Location = new System.Drawing.Point(588, 68);
            this.xeploaitxt.Name = "xeploaitxt";
            this.xeploaitxt.Size = new System.Drawing.Size(100, 22);
            this.xeploaitxt.TabIndex = 11;
            // 
            // ChungChiCTDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xeploaitxt);
            this.Controls.Add(this.ngaycaptxt);
            this.Controls.Add(this.machungchitxt);
            this.Controls.Add(this.mactcbx);
            this.Controls.Add(this.mahvcbx);
            this.Controls.Add(this.luubtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChungChiCTDaoTao";
            this.Text = "ChungChiCTDaoTao";
            this.Load += new System.EventHandler(this.ChungChiCTDaoTao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dschungchictdaotao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dschungchictdaotao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button luubtn;
        private System.Windows.Forms.ComboBox mahvcbx;
        private System.Windows.Forms.ComboBox mactcbx;
        private System.Windows.Forms.TextBox machungchitxt;
        private System.Windows.Forms.TextBox ngaycaptxt;
        private System.Windows.Forms.TextBox xeploaitxt;
    }
}