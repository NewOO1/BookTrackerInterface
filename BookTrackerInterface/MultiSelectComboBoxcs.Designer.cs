namespace BookTrackerInterface
{
    partial class MultiSelectComboBoxcs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bookGenreBox = new TextBox();
            listBoxGenre = new ListBox();
            SuspendLayout();
            // 
            // bookGenreBox
            // 
            bookGenreBox.Location = new Point(91, 42);
            bookGenreBox.Name = "bookGenreBox";
            bookGenreBox.Size = new Size(100, 23);
            bookGenreBox.TabIndex = 0;
            // 
            // listBoxGenre
            // 
            listBoxGenre.FormattingEnabled = true;
            listBoxGenre.ItemHeight = 15;
            listBoxGenre.Items.AddRange(new object[] { "Fantasy", "Humor", "Sci-Fi" });
            listBoxGenre.Location = new Point(91, 42);
            listBoxGenre.Name = "listBoxGenre";
            listBoxGenre.Size = new Size(120, 94);
            listBoxGenre.TabIndex = 2;
            // 
            // MultiSelectComboBoxcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxGenre);
            Controls.Add(bookGenreBox);
            Name = "MultiSelectComboBoxcs";
            Size = new Size(369, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookGenreBox;
        private ListBox listBoxGenre;
    }
}
