using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class frm_cert : Form
    {
        
        public frm_cert(string cert_details)
        {
           
            InitializeComponent();
            //change the label in the form to the cert details from the main
            lbl_cert.Text = cert_details;
        }

        private void btn_close_cert_Click(object sender, EventArgs e)
        {
            //closes this window
            this.Close();
        }

        private void lbl_cert_Click(object sender, EventArgs e)
        {
           
        }
    }
}
