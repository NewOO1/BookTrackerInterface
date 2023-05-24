﻿namespace ConnectionClass
{
    partial class MainMenuWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bAddNewBook = new Button();
            bUpdateCover = new Button();
            bAddNewCompletion = new Button();
            bBooksReadThisYear = new Button();
            SuspendLayout();
            // 
            // bAddNewBook
            // 
            bAddNewBook.Location = new Point(39, 71);
            bAddNewBook.Name = "bAddNewBook";
            bAddNewBook.Size = new Size(133, 23);
            bAddNewBook.TabIndex = 0;
            bAddNewBook.Text = "Add New Book";
            bAddNewBook.UseVisualStyleBackColor = true;
            bAddNewBook.Click += bAddNewBook_Click;
            // 
            // bUpdateCover
            // 
            bUpdateCover.Location = new Point(39, 134);
            bUpdateCover.Name = "bUpdateCover";
            bUpdateCover.Size = new Size(133, 23);
            bUpdateCover.TabIndex = 1;
            bUpdateCover.Text = "Update Covers";
            bUpdateCover.UseVisualStyleBackColor = true;
            bUpdateCover.Click += bUpdateCover_Click;
            // 
            // bAddNewCompletion
            // 
            bAddNewCompletion.Location = new Point(39, 197);
            bAddNewCompletion.Name = "bAddNewCompletion";
            bAddNewCompletion.Size = new Size(133, 24);
            bAddNewCompletion.TabIndex = 2;
            bAddNewCompletion.Text = "Add New Completion";
            bAddNewCompletion.UseVisualStyleBackColor = true;
            bAddNewCompletion.Click += bAddNewCompletion_Click;
            // 
            // bBooksReadThisYear
            // 
            bBooksReadThisYear.Location = new Point(39, 249);
            bBooksReadThisYear.Name = "bBooksReadThisYear";
            bBooksReadThisYear.Size = new Size(133, 23);
            bBooksReadThisYear.TabIndex = 3;
            bBooksReadThisYear.Text = "Books Read This Year";
            bBooksReadThisYear.UseVisualStyleBackColor = true;
            bBooksReadThisYear.Click += bBooksReadThisYear_Click;
            // 
            // MainMenuWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bBooksReadThisYear);
            Controls.Add(bAddNewCompletion);
            Controls.Add(bUpdateCover);
            Controls.Add(bAddNewBook);
            Name = "MainMenuWindow";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bAddNewBook;
        private Button bUpdateCover;
        private Button bAddNewCompletion;
        private Button bBooksReadThisYear;
    }
}