using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {   
        //  Declare universal variables
        int widthHeightLengthValue = 0;
        double result = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
                      
            
        }

               
        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            
            calculateValues();
        }

        
        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
           
            calculateValues();
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            
            calculateValues();
        }

        protected void groundButton_CheckedChange(object sender, EventArgs e)
        {
            
            calculateValues();
        }

        protected void airButton_CheckedChanged(object sender, EventArgs e)
        {
            
            calculateValues();
        }

        protected void nextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            
            calculateValues();
        }



        //  Method to calculate all input values
        private void calculateValues()
        {
            // Declare variables for width, height and length values
            int widthValue;
            int heightValue;
            int lengthValue;

            //  Call hasValue method which checks if textboxes are empty
            // and if buttons have been selected
            hasValue();

            //  Checks if textboxes value is an int, if false, returns nothing.
            //  If true, passes value into respective variables
            if (int.TryParse(widthTextBox.Text, out widthValue) 
                && int.TryParse(heightTextBox.Text, out heightValue)
                && int.TryParse(lengthTextBox.Text, out lengthValue))
            {
                widthHeightLengthValue = widthValue * heightValue* lengthValue;
            } 
            else if (int.TryParse(widthTextBox.Text, out widthValue)
                && int.TryParse(heightTextBox.Text, out heightValue))
            {
                widthHeightLengthValue = widthValue * heightValue; 
            }
            else
            {
                return;
            }

            //  Call buttonIsChecked, checks which buttons have been selected
            buttonIsChecked();

            //  Returns result of calculateValue()
            resultLabel.Text = result.ToString();
        }



        //  Method to check if any buttons are checked and if
        //  textboxes have values
        private void hasValue()
        {
            if (!groundButton.Checked
                && !airButton.Checked
                && !nextDayButton.Checked)
                return;

            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return;
            
           
        }
    


        //  Method to check WHICH buttons have been selected
        private void buttonIsChecked()
        {
            if (groundButton.Checked) result = widthHeightLengthValue * .15;
            else if (airButton.Checked) result = widthHeightLengthValue * .25;
            else result = widthHeightLengthValue * .45;
        }
    }

}