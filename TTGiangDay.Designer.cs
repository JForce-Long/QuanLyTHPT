
namespace QuanLy_HS_GV_THPT
{
    partial class Thông_Tin_Giảng_Dạy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thông_Tin_Giảng_Dạy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchtt = new System.Windows.Forms.Button();
            this.cmbtt = new System.Windows.Forms.ComboBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.InDS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchtt);
            this.groupBox1.Controls.Add(this.cmbtt);
            this.groupBox1.Controls.Add(this.txttt);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.InDS);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1055, 599);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // searchtt
            // 
            this.searchtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtt.Image = ((System.Drawing.Image)(resources.GetObject("searchtt.Image")));
            this.searchtt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchtt.Location = new System.Drawing.Point(887, 14);
            this.searchtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchtt.Name = "searchtt";
            this.searchtt.Size = new System.Drawing.Size(139, 43);
            this.searchtt.TabIndex = 96;
            this.searchtt.Text = "Tìm kiếm";
            this.searchtt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchtt.UseVisualStyleBackColor = true;
            this.searchtt.Click += new System.EventHandler(this.searchtt_Click);
            // 
            // cmbtt
            // 
            this.cmbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(39)))));
            this.cmbtt.FormattingEnabled = true;
            this.cmbtt.Items.AddRange(new object[] {
            "Mã lớp",
            "Tên lớp"});
            this.cmbtt.Location = new System.Drawing.Point(516, 29);
            this.cmbtt.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtt.Name = "cmbtt";
            this.cmbtt.Size = new System.Drawing.Size(148, 28);
            this.cmbtt.TabIndex = 95;
            // 
            // txttt
            // 
            this.txttt.BackColor = System.Drawing.Color.White;
            this.txttt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(39)))));
            this.txttt.Location = new System.Drawing.Point(672, 29);
            this.txttt.Margin = new System.Windows.Forms.Padding(4);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(194, 27);
            this.txttt.TabIndex = 94;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(5, 11);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(53, 45);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // InDS
            // 
            this.InDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDS.Location = new System.Drawing.Point(158, 11);
            this.InDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InDS.Name = "InDS";
            this.InDS.Size = new System.Drawing.Size(136, 45);
            this.InDS.TabIndex = 2;
            this.InDS.Text = "In Danh Sách";
            this.InDS.UseVisualStyleBackColor = true;
            this.InDS.Click += new System.EventHandler(this.InDS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 490);
            this.dataGridView1.TabIndex = 1;
            // 
            // Thông_Tin_Giảng_Dạy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 596);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Thông_Tin_Giảng_Dạy";
            this.Text = "Thông_Tin_Giảng_Dạy";
            this.Load += new System.EventHandler(this.TTGiangDay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button InDS;
        private System.Windows.Forms.Button searchtt;
        private System.Windows.Forms.ComboBox cmbtt;
        private System.Windows.Forms.TextBox txttt;
    }
}