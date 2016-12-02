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
    public partial class frm_inv : Form
    {
          
        public frm_inv(string inv_details)
        {
            InitializeComponent();
            //change the label to show the invoice details
            lbl_invoice.Text = inv_details;
        }

        private void btn_close_inv_Click(object sender, EventArgs e)
        {
            //closes this window
            this.Close();
        }
 
    }
}



