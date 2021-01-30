
namespace QuanLy_HS_GV_THPT
{
    partial class ManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.QLGV = new System.Windows.Forms.Button();
            this.QLHS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.TTGD = new System.Windows.Forms.Button();
            this.QLLOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QLGV
            // 
            this.QLGV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.QLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLGV.ForeColor = System.Drawing.Color.Red;
            this.QLGV.Location = new System.Drawing.Point(93, 361);
            this.QLGV.Name = "QLGV";
            this.QLGV.Size = new System.Drawing.Size(194, 75);
            this.QLGV.TabIndex = 1;
            this.QLGV.Text = "Quản Lý GV";
            this.QLGV.UseVisualStyleBackColor = false;
            this.QLGV.Click += new System.EventHandler(this.QLGV_Click);
            // 
            // QLHS
            // 
            this.QLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLHS.ForeColor = System.Drawing.Color.Red;
            this.QLHS.Location = new System.Drawing.Point(487, 361);
            this.QLHS.Name = "QLHS";
            this.QLHS.Size = new System.Drawing.Size(193, 75);
            this.QLHS.TabIndex = 2;
            this.QLHS.Text = "Quản Lý HS";
            this.QLHS.UseVisualStyleBackColor = true;
            this.QLHS.Click += new System.EventHandler(this.QLHS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phần mềm quản lý GV, HS THPT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 37);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // TTGD
            // 
            this.TTGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTGD.ForeColor = System.Drawing.Color.Red;
            this.TTGD.Location = new System.Drawing.Point(93, 211);
            this.TTGD.Name = "TTGD";
            this.TTGD.Size = new System.Drawing.Size(194, 75);
            this.TTGD.TabIndex = 5;
            this.TTGD.Text = "Thông Tin Giảng Dạy";
            this.TTGD.UseVisualStyleBackColor = true;
            this.TTGD.Click += new System.EventHandler(this.TTGD_Click);
            // 
            // QLLOP
            // 
            this.QLLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLLOP.ForeColor = System.Drawing.Color.Red;
            this.QLLOP.Location = new System.Drawing.Point(487, 211);
            this.QLLOP.Name = "QLLOP";
            this.QLLOP.Size = new System.Drawing.Size(193, 75);
            this.QLLOP.TabIndex = 6;
            this.QLLOP.Text = "Quản Lý Lớp";
            this.QLLOP.UseVisualStyleBackColor = true;
            this.QLLOP.Click += new System.EventHandler(this.QLLOP_Click);
            // 
            // ManHinhChinh
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 485);
            this.Controls.Add(this.QLLOP);
            this.Controls.Add(this.TTGD);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QLHS);
            this.Controls.Add(this.QLGV);
            this.Name = "ManHinhChinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QLGV;
        private System.Windows.Forms.Button QLHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button TTGD;
        private System.Windows.Forms.Button QLLOP;
    }
}