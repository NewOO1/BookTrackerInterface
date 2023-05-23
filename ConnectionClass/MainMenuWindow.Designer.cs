namespace ConnectionClass
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
            SuspendLayout();
            // 
            // bAddNewBook
            // 
            bAddNewBook.Location = new Point(39, 71);
            bAddNewBook.Name = "bAddNewBook";
            bAddNewBook.Size = new Size(118, 23);
            bAddNewBook.TabIndex = 0;
            bAddNewBook.Text = "Add New Book";
            bAddNewBook.UseVisualStyleBackColor = true;
            bAddNewBook.Click += bAddNewBook_Click;
            // 
            // BaseComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bAddNewBook);
            Name = "BaseComponent";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bAddNewBook;
    }
}