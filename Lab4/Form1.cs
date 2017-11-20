//Timothy Mahan
//Lab4
//Due: 2/16/16
//Section: 01
/*Program takes the input GPA and test score and tests it to see if the applicant should be accepted or rejected.
 If the GPA is at least a 3 and the test score is at least a 60, the applicant is accepted. If the GPA is below 3, and
 the test score is an 80 or greater, the applicant is accepted, otherwise the applicant is rejected.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class lab4 : Form
    {
        private const byte APP_ACCEPTED = 1;//Field variable to add 1 to totalAccepted variable 
        private const byte APP_REJECTED = 1;//Field variable to add 1 to totalRejected variable
        private ushort totalAccepted = 0; //Field variable to count accepted applications
        private ushort totalRejected = 0; //Field variable to count rejected application


        public lab4()
        {
            InitializeComponent();
        }

        private void enterSubBtn_Click(object sender, EventArgs e)
        {
            double gpaVar = 0; //Declare gpaVar variable that will hold the GPA entered by user
            uint testScore = 0; //Declare testScore variable that will hold the testScore entered by user

            if (double.TryParse(gpaTxtBox.Text, out gpaVar))//Convert gpa text string to double and put in gpa double variable
            {
                if (uint.TryParse(testScoreTxtBox.Text, out testScore)) //Convert test score to double and placed in test Score variable
                {
                    if (gpaVar >= 3 && testScore >= 60)//If GPA is greater than 3, accepts application, adds APP_ACCEPTED to totalRejected.
                    {
                        totalAccepted += APP_ACCEPTED;
                        MessageBox.Show("Accept");
                    }
                    else
                    {
                        if (testScore >= 80)//If test score is greater than 80, accepts application, adds APP_ACCEPTED to totalRejected
                        {
                            totalAccepted += APP_ACCEPTED;
                            MessageBox.Show("Accept");
                        }


                        else
                        {
                            totalRejected += APP_REJECTED;//If gpa is less than 3 and testscore is less than 80, add APP_REJECTED to totalREJECTED
                            MessageBox.Show("Reject");

                            

                        }

                    }

                }
                else
                {
                    MessageBox.Show("Invalid data entered in the Test Score box, please enter whole numbers ONLY.");
                
                }
                
        }
            else
            {
                MessageBox.Show("Invalid data entered in the GPA box, please enter numbers ONLY");
            }
            ttlAcceptDispLbl.Text = totalAccepted.ToString();
            ttlRejectDispLbl.Text = totalRejected.ToString();
        }
    }
}
            
        
    
