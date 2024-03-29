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
            bBooksReadThisYearSeth = new Button();
            bAllBooksSeth = new Button();
            bBooksReadThisYearEm = new Button();
            bAllBooksEm = new Button();
            SuspendLayout();
            // 
            // bAddNewBook
            // 
            bAddNewBook.Location = new Point(12, 13);
            bAddNewBook.Name = "bAddNewBook";
            bAddNewBook.Size = new Size(167, 23);
            bAddNewBook.TabIndex = 0;
            bAddNewBook.Text = "Add New Book";
            bAddNewBook.UseVisualStyleBackColor = true;
            bAddNewBook.Click += bAddNewBook_Click;
            // 
            // bUpdateCover
            // 
            bUpdateCover.Location = new Point(12, 72);
            bUpdateCover.Name = "bUpdateCover";
            bUpdateCover.Size = new Size(167, 23);
            bUpdateCover.TabIndex = 1;
            bUpdateCover.Text = "Update Covers";
            bUpdateCover.UseVisualStyleBackColor = true;
            bUpdateCover.Click += bUpdateCover_Click;
            // 
            // bAddNewCompletion
            // 
            bAddNewCompletion.Location = new Point(12, 42);
            bAddNewCompletion.Name = "bAddNewCompletion";
            bAddNewCompletion.Size = new Size(167, 24);
            bAddNewCompletion.TabIndex = 2;
            bAddNewCompletion.Text = "Add New Completion";
            bAddNewCompletion.UseVisualStyleBackColor = true;
            bAddNewCompletion.Click += bAddNewCompletion_Click;
            // 
            // bBooksReadThisYearSeth
            // 
            bBooksReadThisYearSeth.Location = new Point(12, 159);
            bBooksReadThisYearSeth.Name = "bBooksReadThisYearSeth";
            bBooksReadThisYearSeth.Size = new Size(167, 23);
            bBooksReadThisYearSeth.TabIndex = 3;
            bBooksReadThisYearSeth.Text = "Books Read This Year [Seth]\r\n\r\n";
            bBooksReadThisYearSeth.UseVisualStyleBackColor = true;
            bBooksReadThisYearSeth.Click += bBooksReadThisYear_Click;
            // 
            // bAllBooksSeth
            // 
            bAllBooksSeth.Location = new Point(12, 188);
            bAllBooksSeth.Name = "bAllBooksSeth";
            bAllBooksSeth.Size = new Size(167, 23);
            bAllBooksSeth.TabIndex = 4;
            bAllBooksSeth.Text = "All Books Read [Seth]";
            bAllBooksSeth.UseVisualStyleBackColor = true;
            bAllBooksSeth.Click += bAllBooks_Click;
            // 
            // bBooksReadThisYearEm
            // 
            bBooksReadThisYearEm.Location = new Point(12, 101);
            bBooksReadThisYearEm.Name = "bBooksReadThisYearEm";
            bBooksReadThisYearEm.Size = new Size(167, 23);
            bBooksReadThisYearEm.TabIndex = 5;
            bBooksReadThisYearEm.Text = "Books Read This Year [Em]";
            bBooksReadThisYearEm.UseVisualStyleBackColor = true;
            bBooksReadThisYearEm.Click += bBooksReadThisYearEm_Click;
            // 
            // bAllBooksEm
            // 
            bAllBooksEm.Location = new Point(12, 130);
            bAllBooksEm.Name = "bAllBooksEm";
            bAllBooksEm.Size = new Size(167, 23);
            bAllBooksEm.TabIndex = 6;
            bAllBooksEm.Text = "All Books Read [Em]";
            bAllBooksEm.UseVisualStyleBackColor = true;
            bAllBooksEm.Click += bAllBooksEm_Click;
            // 
            // MainMenuWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 248);
            Controls.Add(bAllBooksEm);
            Controls.Add(bBooksReadThisYearEm);
            Controls.Add(bAllBooksSeth);
            Controls.Add(bBooksReadThisYearSeth);
            Controls.Add(bAddNewCompletion);
            Controls.Add(bUpdateCover);
            Controls.Add(bAddNewBook);
            Name = "MainMenuWindow";
            Text = "Book Tracker Hub";
            ResumeLayout(false);
        }

        #endregion

        private Button bAddNewBook;
        private Button bUpdateCover;
        private Button bAddNewCompletion;
        private Button bBooksReadThisYearSeth;
        private Button bAllBooksSeth;
        private Button bBooksReadThisYearEm;
        private Button bAllBooksEm;
    }
}