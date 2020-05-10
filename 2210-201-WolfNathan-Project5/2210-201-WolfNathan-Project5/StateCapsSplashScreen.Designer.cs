////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 5
//  File Name:      StateCapsSplashScreen.cs
//  Description:    This is the Splash Screen Designer class for Project 5
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        April 24, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project5
{
    /// <summary>
    /// The class for the StateCapsSplashScreen.Designer file
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class StateCapsSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateCapsSplashScreen));
            this.SCSSLabel = new System.Windows.Forms.Label();
            this.StateCapsSplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SCSSLabel
            // 
            this.SCSSLabel.AutoSize = true;
            this.SCSSLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SCSSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCSSLabel.ForeColor = System.Drawing.Color.Black;
            this.SCSSLabel.Location = new System.Drawing.Point(134, 400);
            this.SCSSLabel.Name = "SCSSLabel";
            this.SCSSLabel.Size = new System.Drawing.Size(683, 44);
            this.SCSSLabel.TabIndex = 0;
            this.SCSSLabel.Text = "United States Capitals Geography Quiz";
            // 
            // StateCapsSplashScreenTimer
            // 
            this.StateCapsSplashScreenTimer.Enabled = true;
            this.StateCapsSplashScreenTimer.Interval = 2500;
            this.StateCapsSplashScreenTimer.Tick += new System.EventHandler(this.StateCapsSplashScreenTimer_Tick);
            // 
            // StateCapsSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 453);
            this.Controls.Add(this.SCSSLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StateCapsSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateCapsSplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SCSSLabel;
        private System.Windows.Forms.Timer StateCapsSplashScreenTimer;
    }
}