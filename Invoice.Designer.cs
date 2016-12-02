namespace Coursework
{
    partial class frm_inv
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
            this.lbl_invoice = new System.Windows.Forms.Label();
            this.btn_close_inv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_invoice
            // 
            this.lbl_invoice.AutoSize = true;
            this.lbl_invoice.Location = new System.Drawing.Point(26, 107);
            this.lbl_invoice.Name = "lbl_invoice";
            this.lbl_invoice.Size = new System.Drawing.Size(35, 13);
            this.lbl_invoice.TabIndex = 0;
            this.lbl_invoice.Text = "label1";
            // 
            // btn_close_inv
            // 
            this.btn_close_inv.Location = new System.Drawing.Point(133, 227);
            this.btn_close_inv.Name = "btn_close_inv";
            this.btn_close_inv.Size = new System.Drawing.Size(75, 23);
            this.btn_close_inv.TabIndex = 1;
            this.btn_close_inv.Text = "Close";
            this.btn_close_inv.UseVisualStyleBackColor = true;
            this.btn_close_inv.Click += new System.EventHandler(this.btn_close_inv_Click);
            // 
            // frm_inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 262);
            this.Controls.Add(this.btn_close_inv);
            this.Controls.Add(this.lbl_invoice);
            this.Name = "frm_inv";
            this.Text = "Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_invoice;
        private System.Windows.Forms.Button btn_close_inv;
    }
}