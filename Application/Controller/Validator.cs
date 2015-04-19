using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.Controller
{
    class Validator
    {
         private static string title = "Entry Error";

        //Gets and sets the title of the invalidation error
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        //Checks if a value in the form is present
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        /// <summary>
        /// Check if value is int32
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Check if value is decimal
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be a decimal or integer value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsValidBloodPressure(TextBox textBox)
        {
            
            try
            {
                string[] textToCheck = textBox.Text.Split('/');
                if (textToCheck.Length != 2)
                {
                    MessageBox.Show(textBox.Tag.ToString() + " must have integer/integer format. Please Use one / (slash) to divide the systolic and diastolic pressure!", Title);
                    return false;
                }
                else
                {
                    Convert.ToInt32(textToCheck[0]);
                    Convert.ToInt32(textToCheck[1]);
                    return true;
                }
            }
           
            catch (Exception exception)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must have integer/integer format.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}

