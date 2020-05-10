////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 5
//  File Name:      StateCapsSplashScreen.cs
//  Description:    This is the main Splash Screen class for Project 5
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// The class for the StateCapsSplashScreen.cs file
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class StateCapsSplashScreen : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateCapsSplashScreen"/> class.
        /// </summary>
        public StateCapsSplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Tick event of the StateCapsSplashScreenTimer control.
        /// It closes the Splash screen after the 2500 interval
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void StateCapsSplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
