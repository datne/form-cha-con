namespace Form_Cha_Con
{
    partial class XoSo
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
            this.txtDaySoNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuaySo = new System.Windows.Forms.Button();
            this.txtSoQuay = new System.Windows.Forms.TextBox();
            this.txtDaySoTrung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnResetKq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDaySoNhap
            // 
            this.txtDaySoNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaySoNhap.Location = new System.Drawing.Point(266, 34);
            this.txtDaySoNhap.Name = "txtDaySoNhap";
            this.txtDaySoNhap.Size = new System.Drawing.Size(151, 24);
            this.txtDaySoNhap.TabIndex = 3;
            this.txtDaySoNhap.TextChanged += new System.EventHandler(this.txtDaySoNhap_TextChanged);
            this.txtDaySoNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaySoNhap_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập dãy số (gồm 6 chữ số)";
            // 
            // btnQuaySo
            // 
            this.btnQuaySo.Enabled = false;
            this.btnQuaySo.Location = new System.Drawing.Point(60, 101);
            this.btnQuaySo.Name = "btnQuaySo";
            this.btnQuaySo.Size = new System.Drawing.Size(75, 23);
            this.btnQuaySo.TabIndex = 4;
            this.btnQuaySo.Text = "Quay số";
            this.btnQuaySo.UseVisualStyleBackColor = true;
            this.btnQuaySo.Click += new System.EventHandler(this.btnQuaySo_Click);
            // 
            // txtSoQuay
            // 
            this.txtSoQuay.Enabled = false;
            this.txtSoQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoQuay.Location = new System.Drawing.Point(144, 101);
            this.txtSoQuay.Name = "txtSoQuay";
            this.txtSoQuay.Size = new System.Drawing.Size(151, 24);
            this.txtSoQuay.TabIndex = 5;
            // 
            // txtDaySoTrung
            // 
            this.txtDaySoTrung.Enabled = false;
            this.txtDaySoTrung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaySoTrung.Location = new System.Drawing.Point(173, 171);
            this.txtDaySoTrung.Name = "txtDaySoTrung";
            this.txtDaySoTrung.Size = new System.Drawing.Size(151, 24);
            this.txtDaySoTrung.TabIndex = 7;
            this.txtDaySoTrung.TextChanged += new System.EventHandler(this.txtDaySoTrung_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dãy số trúng";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(140, 219);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(85, 20);
            this.lbKetQua.TabIndex = 8;
            this.lbKetQua.Text = "KẾT QUẢ";
            // 
            // btnResetKq
            // 
            this.btnResetKq.Location = new System.Drawing.Point(367, 3);
            this.btnResetKq.Name = "btnResetKq";
            this.btnResetKq.Size = new System.Drawing.Size(75, 23);
            this.btnResetKq.TabIndex = 9;
            this.btnResetKq.Text = "Reset";
            this.btnResetKq.UseVisualStyleBackColor = true;
            this.btnResetKq.Click += new System.EventHandler(this.btnResetKq_Click);
            // 
            // XoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 277);
            this.Controls.Add(this.btnResetKq);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.txtDaySoTrung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoQuay);
            this.Controls.Add(this.btnQuaySo);
            this.Controls.Add(this.txtDaySoNhap);
            this.Controls.Add(this.label1);
            this.Name = "XoSo";
            this.Text = "XoSo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDaySoNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoQuay;
        private System.Windows.Forms.TextBox txtDaySoTrung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnQuaySo;
        private System.Windows.Forms.Button btnResetKq;
    }
}