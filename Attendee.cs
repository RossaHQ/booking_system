using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public class Attendee : Person
    {
        private int attendee_Ref;
        private string con_Name;
        private string reg_Type;
        private string inst_Name;
        private bool paid;
        private bool presenter;
        private string paper_Title;
        public int cost;
     



        public int getAttendee_Ref
        {

            get { return attendee_Ref; }
            set
            {
                if (Enumerable.Range(40000,60000).Contains(value))
                {
                    attendee_Ref = value; 
                }
                else
                {
                    throw new ArgumentException("You must enter a value between 40000 and 60000");
                }
            }
        }

        public string getCon_Name
        {
            get { return con_Name; }

            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("You must enter a conference name.");
                }

                con_Name = value;
            }   
        }

        public string getInst_Name
        {
            get { return inst_Name; }
            set { inst_Name = value; }
        }

        public string getReg_Type
        {
            get { return reg_Type; }
            set {
                
                if (reg_Type != "Full" || reg_Type != "Student" || reg_Type != "Organiser")
                {
                    throw new ArgumentException("You must enter full, stundent or organiser.");
                }
                reg_Type = value; 
            }
        }

        public bool getPaid
        {
            get { return paid; }
            set { paid = value; }
        }

        public bool getPresenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        public string getPaper_Title
        {
            get { return paper_Title; }
            set 
            { 
                if (presenter == true && value == String.Empty)
                {
                    throw new ArgumentException("You must enter the title of your paper.");
                }

                paper_Title = value;

            }
        }

        public int getCost()
        {
             cost = 0;
             if(reg_Type == "Full")
             {
                 if (presenter == true)
                     cost = 450;
                 else
                     cost = 500;
             }
            if(reg_Type == "Student")
            {
                if (presenter == true)
                    cost = 270;
                else
                    cost = 300;
            }
            return cost;
        }
        
    } 
}

