////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 5
//  File Name:      P5Driver.cs
//  Description:    This is the driver for Project 5
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        April 24, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// Class which contains the Main Method
    /// </summary>
    static class P5Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            double PercentCorrect;  //calculates the percent correct


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StateCapsSplashScreen());
            //runs the StateCapsSplashScreen

            MessageBox.Show($"Hello this is the United States Capitals Geography quiz. \n\n" +
                $"You will be presented with a random state and will be required " +
                $"to match its capital from a list of capitals. You will then select the" +
                $"\"Next Question\" button to go to the next question \n\n" +
                $"Your attempts and number of questions answered correctly will be " +
                $"recorded. You can press the \"End Game\" button to end the program" +
                $"\n\nThe game will start as soon as you select the \"OK\" button", "US Capitals Quiz",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, 0);



            Application.Run(new StatesForm());
            //runs the main form

            if (StatesForm.AttemptsCounter == 51)
            {
                StatesForm.AttemptsCounter--;
                //Takes one off from the total attempts to get the 50 in total
            }


            PercentCorrect = (double)StatesForm.CorrectCounter / (double)StatesForm.AttemptsCounter * 100;
            PercentCorrect = Math.Round(PercentCorrect, 2);

            //Calculates the percent correct



            MessageBox.Show($"Thank you for trying your luck at the State Capitol Matching Game,\n\n" +
                $"YourScore was {PercentCorrect}% on {StatesForm.AttemptsCounter} attempts", "Goodbye " +
                "and Thank you",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, 0);

        }
    }
}
