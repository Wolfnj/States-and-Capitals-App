////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 5
//  File Name:      StatesForm.cs
//  Description:    This is the main form for Project 5
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        April 24, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// StatesForm Class which contains method for the geography game
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class StatesForm : Form
    {
        private static Random R = new Random();               //Random integer calculator

        private static SortedDictionary<string, string> StatesCaps = new SortedDictionary<string, string>();
        //this will store the state capitals along with their respective states


        private static List<string> States = new List<string>();       //Contains all the state names
        private static List<string> Capitals = new List<string>();      //Contains all the capital names

        private int StatesIndex;            //Gets a random index from states

        public static int AttemptsCounter=0;        //counts the number of attempts the user has so far

        public static int CorrectCounter=0;         //counts the number of correct answers so far

        private static int TimeLeft = 15;       //User has 15 seconds for attempt

        private static bool ClearSelectedBln = false;   //For not going into the changedINdex method
                                                        //for the list box when the ClearSelected method
                                                        //is called

        /// <summary>
        /// Initializes a new instance of the <see cref="StatesForm"/> class.
        /// Starts the StatesForm. IT will read in from the text fill
        /// and set up the first question
        /// </summary>
        public StatesForm()
        {
            InitializeComponent();




            StreamReader reader;        //for reading in the text file


            string strIn;       //reads in each line from the text file

            try
            {
                reader = new StreamReader("..\\..\\TextFolder\\StatesCaps.txt");
                while (reader.Peek() != -1)
                {
                    strIn = reader.ReadLine();  //gets the line
                    String[] fields = strIn.Split(','); //splits on the delimiter ','
                    States.Add(fields[1]);
                    Capitals.Add(fields[0]);
                    StatesCaps.Add(fields[1], fields[0]); 
                    //Adds the proper string to the proper List or container
                    
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Capitals.Sort();
            CapitalsListBox.DataSource = Capitals;
            //Adds all the capitals the  list box

            StatesIndex = R.Next(50);

            StatesTextBox.Text = States[StatesIndex];

            AttemptsTextBox.Text = (AttemptsCounter).ToString();
            CorrectTextBox.Text = CorrectCounter.ToString();

            TimerTextBox.BackColor = Color.White;
            TimerTextBox.ForeColor = Color.Red;
            TimerTextBox.ReadOnly = true;
            TimerTextBox.Text = TimeLeft.ToString();
            CountDownTimer.Start();

            ClearSelectedBln = false;
            CapitalsListBox.ClearSelected();
            ClearSelectedBln = true;

            //ClearSelected in the CapitalsListBox, but does not go into the code of
            //the CapitalsListBox_SelectedIndexChanged method

            CapitalsListBox.Enabled = true;

            AttemptsCounter++;
            //First attempt will start

            AttemptsTextBox.Text = (AttemptsCounter).ToString();
            CorrectTextBox.Text = CorrectCounter.ToString();

        }//end StatesForm()


        /// <summary>
        /// Handles the Click event of the NextQuestionButton control.
        /// Checks if the user got the name of the state's capital correct 
        /// or if they got it wrong.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            TimeLeft = 15;
            CountDownTimer.Start();
            //Reset the timer back to 15 seconds
            //and start it again

            ClearSelectedBln = false;
            CapitalsListBox.ClearSelected();
            ClearSelectedBln = true;
            //ClearSelected in the CapitalsListBox, but does not go into the code of
            //the CapitalsListBox_SelectedIndexChanged method


            CapitalsListBox.Enabled = true;


            TimerTextBox.Text = TimeLeft.ToString();
        


            if (AttemptsCounter == 51)
            {
                AttemptsTextBox.Text = (AttemptsCounter).ToString();
                CorrectTextBox.Text = CorrectCounter.ToString();
                System.Threading.Thread.Sleep(2000);
                this.Close();
            }
            else
            {
                //Remove the state from the list of states if the user gets it correct
                StatesIndex = R.Next(50 - AttemptsCounter);
                //Updates the new random int which will choose a new state
                StatesTextBox.Text = States[StatesIndex];
                AttemptsTextBox.Text = (AttemptsCounter).ToString();
                CorrectTextBox.Text = CorrectCounter.ToString();
            }
        }//end NextQuestionButton_Click(object sender, EventArgs e)




        /// <summary>
        /// Handles the Click event of the EndGameButton control.
        /// Closes the application
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EndGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end EndGameButton_Click(object sender, EventArgs e)

        /// <summary>
        /// Handles the Tick event of the CountDownTimer control.
        /// Handles what happens when the timer runs out
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                // Display the new time left
                // by updating TimerTextBox.
                TimeLeft = TimeLeft - 1;

                TimerTextBox.Text = TimeLeft.ToString();
            }
            else
            {
                AttemptsCounter++;  //updates the number of attempts

                States.Remove(StatesTextBox.Text);

                CapitalsListBox.Enabled = false;
                CountDownTimer.Enabled = false;


     
            }
        }//end CountDownTimer_Tick(object sender, EventArgs e)



        /// <summary>
        /// Handles what happens when the user selects an index
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CapitalsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClearSelectedBln == true)
            {
                if (StatesCaps[StatesTextBox.Text] == (string)CapitalsListBox.SelectedItem)
                {

                        AttemptsCounter++;  //updates the number of attempts
    
                        CorrectCounter++;   //updates the number of correct answers

                    States.Remove(StatesTextBox.Text);


                    AttemptsTextBox.Text = (AttemptsCounter-1).ToString();
                    CorrectTextBox.Text = CorrectCounter.ToString();
                    CapitalsListBox.Enabled = false;
                    CountDownTimer.Enabled = false;
  

                }
                else
                {


                    AttemptsCounter++;  //updates the number of attempts

       
                    States.Remove(StatesTextBox.Text);
                    CapitalsListBox.Enabled = false;
                    CountDownTimer.Enabled = false;
                    //Remove the state from the list of states if the user gets it correct




                }//end if (StatesCaps[StatesTextBox.Text] == (string)CapitalsListBox.SelectedItem)
            }//end if (ClearSelectedBln == true)
        }//end CapitalsListBox_SelectedIndexChanged(object sender, EventArgs e)
    }//end StateForm
}//end Project5
