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
    public partial class Main : Form
    {
        //create a new instance of the attendee class in main
        Attendee attender = new Attendee();
        //declaring variables for invoice and certificate forms
        public string cert_details;
        public string inv_details;

        public Main()
        {
            InitializeComponent();        
        }
        
        public void set_button_Click(object sender, EventArgs e)

        {
            //sets the values held within the textboxes to the relevant variables in the attendee class
            //implement try and catch for each case of validation in the attendee
            attender.getFirst_Name = txt_first_name.Text;
            try
            {
                attender.getFirst_Name = txt_first_name.Text;
            }
            catch(Exception excep)
            {
                Console.WriteLine(excep.Message);
            }
            attender.getSecond_Name = txt_second_name.Text;
            try
            {
                attender.getSecond_Name = txt_second_name.Text;
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }
            attender.getAttendee_Ref = Convert.ToInt32(txt_attendee.Text);
            try
            {
                attender.getAttendee_Ref = Convert.ToInt32(txt_attendee.Text);

            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }
            attender.getInst_Name = txt_inst_name.Text;
            attender.getCon_Name = txt_conf.Text;
            try
            {
                attender.getCon_Name = txt_conf.Text;

            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }
            attender.getReg_Type = cmb_reg.Text;
            try
            {
                attender.getReg_Type = cmb_reg.Text;

            }
            catch (Exception excep)
            {
                Console.WriteLine(excep.Message);
            }
            attender.getPaid = Convert.ToBoolean(cmb_paid.Text);
            attender.getPresenter = Convert.ToBoolean(cmb_pres.Text);
            attender.getPaper_Title = txt_paper.Text;
            try
             {
                 attender.getPaper_Title = txt_paper.Text;
            
            }
            catch(Exception excep)
            {
                Console.WriteLine(excep.Message);
            }

            inv_details = "" + attender.getFirst_Name + " " + attender.getSecond_Name + " of " + attender.getInst_Name + " is required to pay £" + attender.getCost() + ".";
            cert_details = "This is to certify that " + attender.getFirst_Name + attender.getSecond_Name + " attended " + attender.getCon_Name + ".";
        }

        private void get_button_Click(object sender, EventArgs e)
        {
            //fills the textboxes with the relevant values from the attendee class
            txt_first_name.Text = attender.getFirst_Name;
            txt_second_name.Text = attender.getSecond_Name;
            txt_attendee.Text = Convert.ToString(attender.getAttendee_Ref);
            txt_inst_name.Text = attender.getInst_Name;
            txt_conf.Text = attender.getCon_Name;
            cmb_reg.Text = attender.getReg_Type;
            cmb_paid.Text = Convert.ToString(attender.getPaid);
            cmb_pres.Text = Convert.ToString(attender.getPresenter);
            txt_paper.Text = attender.getPaper_Title;

        }

        private void invoice_button_Click(object sender, EventArgs e)
        {
            //opens the invoice window
            frm_inv inv = new frm_inv(inv_details);
            inv.ShowDialog();
        }

        private void cert_button_Click(object sender, EventArgs e)
        {
            //opens the certificate window
            frm_cert cert = new frm_cert(cert_details);
            cert.ShowDialog();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            //makes all textboxes empty
            txt_attendee.Text = String.Empty;
            txt_conf.Text = String.Empty;
            txt_first_name.Text = String.Empty;
            txt_second_name.Text = String.Empty;
            cmb_reg.Text = String.Empty;
            cmb_pres.Text = String.Empty;
            cmb_paid.Text = String.Empty;
            txt_paper.Text = String.Empty;
            txt_inst_name.Text = String.Empty;
   

        }

        private void cmb_reg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
