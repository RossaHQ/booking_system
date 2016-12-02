using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Coursework
{
    public class Person 
    {
        private string first_Name;
        private string second_Name;
        public string getFirst_Name
        {
            get { return first_Name; }

            set 
            { 
                if (value == String.Empty)
                {
                    throw new ArgumentException("You cannot leave the name field blank.");
                }
                
                first_Name = value;

            }
        }

        public string getSecond_Name
        {
            get { return second_Name; }
            set 
            { 
                  if (value == String.Empty)
                {
                    throw new ArgumentException("You cannot leave the name field blank.");
                }

                 second_Name = value;

            }
        }
    }
}
