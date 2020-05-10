////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 5
//  File Name:      StatesForm.Designer.cs
//  Description:    Designer class for  StatesForm
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        April 24, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Project5
{
    /// <summary>
    /// Class for the StateForm.Designer
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class StatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatesForm));
            this.CapitalLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.AttemptsLabel = new System.Windows.Forms.Label();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.SelectCapsLabel = new System.Windows.Forms.Label();
            this.StatesTextBox = new System.Windows.Forms.TextBox();
            this.AttemptsTextBox = new System.Windows.Forms.TextBox();
            this.CorrectTextBox = new System.Windows.Forms.TextBox();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.CapitalsListBox = new System.Windows.Forms.ListBox();
            this.TimerTextBox = new System.Windows.Forms.TextBox();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CapitalLabel
            // 
            this.CapitalLabel.AutoSize = true;
            this.CapitalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapitalLabel.Location = new System.Drawing.Point(41, 41);
            this.CapitalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CapitalLabel.Name = "CapitalLabel";
            this.CapitalLabel.Size = new System.Drawing.Size(161, 20);
            this.CapitalLabel.TabIndex = 0;
            this.CapitalLabel.Text = "What is the capital of:";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLabel.Location = new System.Drawing.Point(62, 117);
            this.TimeLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(154, 20);
            this.TimeLeftLabel.TabIndex = 1;
            this.TimeLeftLabel.Text = "Time Left to Answer:";
            // 
            // AttemptsLabel
            // 
            this.AttemptsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AttemptsLabel.AutoSize = true;
            this.AttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptsLabel.Location = new System.Drawing.Point(66, 240);
            this.AttemptsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AttemptsLabel.Name = "AttemptsLabel";
            this.AttemptsLabel.Size = new System.Drawing.Size(74, 20);
            this.AttemptsLabel.TabIndex = 2;
            this.AttemptsLabel.Text = "Attempts";
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLabel.Location = new System.Drawing.Point(279, 240);
            this.CorrectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(61, 20);
            this.CorrectLabel.TabIndex = 3;
            this.CorrectLabel.Text = "Correct";
            // 
            // SelectCapsLabel
            // 
            this.SelectCapsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectCapsLabel.AutoSize = true;
            this.SelectCapsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCapsLabel.Location = new System.Drawing.Point(491, 41);
            this.SelectCapsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectCapsLabel.Name = "SelectCapsLabel";
            this.SelectCapsLabel.Size = new System.Drawing.Size(138, 20);
            this.SelectCapsLabel.TabIndex = 4;
            this.SelectCapsLabel.Text = "Select The Capital";
            // 
            // StatesTextBox
            // 
            this.StatesTextBox.Location = new System.Drawing.Point(220, 46);
            this.StatesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatesTextBox.Name = "StatesTextBox";
            this.StatesTextBox.ReadOnly = true;
            this.StatesTextBox.Size = new System.Drawing.Size(105, 20);
            this.StatesTextBox.TabIndex = 5;
            this.StatesTextBox.TabStop = false;
            // 
            // AttemptsTextBox
            // 
            this.AttemptsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AttemptsTextBox.Location = new System.Drawing.Point(70, 276);
            this.AttemptsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AttemptsTextBox.Name = "AttemptsTextBox";
            this.AttemptsTextBox.ReadOnly = true;
            this.AttemptsTextBox.Size = new System.Drawing.Size(76, 20);
            this.AttemptsTextBox.TabIndex = 1;
            this.AttemptsTextBox.TabStop = false;
            // 
            // CorrectTextBox
            // 
            this.CorrectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CorrectTextBox.Location = new System.Drawing.Point(283, 276);
            this.CorrectTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CorrectTextBox.Name = "CorrectTextBox";
            this.CorrectTextBox.ReadOnly = true;
            this.CorrectTextBox.Size = new System.Drawing.Size(76, 20);
            this.CorrectTextBox.TabIndex = 9;
            this.CorrectTextBox.TabStop = false;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionButton.Location = new System.Drawing.Point(66, 310);
            this.NextQuestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(154, 26);
            this.NextQuestionButton.TabIndex = 0;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // EndGameButton
            // 
            this.EndGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EndGameButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EndGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGameButton.Location = new System.Drawing.Point(283, 310);
            this.EndGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(106, 26);
            this.EndGameButton.TabIndex = 1;
            this.EndGameButton.Text = "End Game";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // CapitalsListBox
            // 
            this.CapitalsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CapitalsListBox.FormattingEnabled = true;
            this.CapitalsListBox.Location = new System.Drawing.Point(495, 92);
            this.CapitalsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.CapitalsListBox.Name = "CapitalsListBox";
            this.CapitalsListBox.ScrollAlwaysVisible = true;
            this.CapitalsListBox.Size = new System.Drawing.Size(150, 225);
            this.CapitalsListBox.TabIndex = 10;
            this.CapitalsListBox.TabStop = false;
            this.CapitalsListBox.SelectedIndexChanged += new System.EventHandler(this.CapitalsListBox_SelectedIndexChanged);
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerTextBox.ForeColor = System.Drawing.Color.Red;
            this.TimerTextBox.Location = new System.Drawing.Point(249, 117);
            this.TimerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.ReadOnly = true;
            this.TimerTextBox.Size = new System.Drawing.Size(46, 38);
            this.TimerTextBox.TabIndex = 2;
            this.TimerTextBox.TabStop = false;
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // StatesForm
            // 
            this.AcceptButton = this.NextQuestionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.EndGameButton;
            this.ClientSize = new System.Drawing.Size(682, 359);
            this.Controls.Add(this.TimerTextBox);
            this.Controls.Add(this.CapitalsListBox);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.CorrectTextBox);
            this.Controls.Add(this.AttemptsTextBox);
            this.Controls.Add(this.StatesTextBox);
            this.Controls.Add(this.SelectCapsLabel);
            this.Controls.Add(this.CorrectLabel);
            this.Controls.Add(this.AttemptsLabel);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.CapitalLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Capital Matching Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CapitalLabel;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Label AttemptsLabel;
        private System.Windows.Forms.Label CorrectLabel;
        private System.Windows.Forms.Label SelectCapsLabel;
        private System.Windows.Forms.TextBox StatesTextBox;
        private System.Windows.Forms.TextBox AttemptsTextBox;
        private System.Windows.Forms.TextBox CorrectTextBox;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.ListBox CapitalsListBox;
        private System.Windows.Forms.TextBox TimerTextBox;
        private System.Windows.Forms.Timer CountDownTimer;
    }
}

