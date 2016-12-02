namespace Coursework
{
    partial class frm_cert
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
            this.btn_close_cert = new System.Windows.Forms.Button();
            this.lbl_cert = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // btn_close_cert
            // 
            this.btn_close_cert.Location = new System.Drawing.Point(132, 188);
            this.btn_close_cert.Name = "btn_close_cert";
            this.btn_close_cert.Size = new System.Drawing.Size(75, 23);
            this.btn_close_cert.TabIndex = 0;
            this.btn_close_cert.Text = "Close";
            this.btn_close_cert.UseVisualStyleBackColor = true;
            this.btn_close_cert.Click += new System.EventHandler(this.btn_close_cert_Click);
            // 
            // lbl_cert
            // 
            this.lbl_cert.AutoSize = true;
            this.lbl_cert.Location = new System.Drawing.Point(26, 98);
            this.lbl_cert.Name = "lbl_cert";
            this.lbl_cert.Size = new System.Drawing.Size(35, 13);
            this.lbl_cert.TabIndex = 1;
            this.lbl_cert.Text = "label1";
            this.lbl_cert.Click += new System.EventHandler(this.lbl_cert_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frm_cert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 250);
            this.Controls.Add(this.lbl_cert);
            this.Controls.Add(this.btn_close_cert);
            this.Name = "frm_cert";
            this.Text = "Certificate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close_cert;
        private System.Windows.Forms.Label lbl_cert;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}