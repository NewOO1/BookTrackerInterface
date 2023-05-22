namespace BookTrackerInterface
{
    partial class AddNewComplBookForm
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
            components = new System.ComponentModel.Container();
            bSubmit = new Button();
            bookTitle = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelTitle = new Label();
            labelSeries = new Label();
            bookSeries = new ComboBox();
            labelBookNum = new Label();
            bookNum = new TextBox();
            bookAuthor = new ComboBox();
            labelAuthor = new Label();
            bookDate = new TextBox();
            labelDate = new Label();
            bookMedium = new ComboBox();
            labelMedium = new Label();
            labelGenre = new Label();
            bookGenre = new TextBox();
            listBookGenre = new ListBox();
            labelCover = new Label();
            bCoverFile = new Button();
            bookCover = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(277, 489);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 0;
            bSubmit.Text = "Submit";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += Submit_Click;
            // 
            // bookTitle
            // 
            bookTitle.Location = new Point(127, 41);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(226, 23);
            bookTitle.TabIndex = 1;
            bookTitle.TextAlign = HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(56, 44);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title";
            // 
            // labelSeries
            // 
            labelSeries.AutoSize = true;
            labelSeries.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeries.Location = new Point(56, 90);
            labelSeries.Name = "labelSeries";
            labelSeries.Size = new Size(48, 20);
            labelSeries.TabIndex = 4;
            labelSeries.Text = "Series";
            // 
            // bookSeries
            // 
            bookSeries.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookSeries.AutoCompleteSource = AutoCompleteSource.ListItems;
            bookSeries.FormattingEnabled = true;
            bookSeries.Location = new Point(176, 87);
            bookSeries.Name = "bookSeries";
            bookSeries.Size = new Size(177, 23);
            bookSeries.TabIndex = 5;
            // 
            // labelBookNum
            // 
            labelBookNum.AutoSize = true;
            labelBookNum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBookNum.Location = new Point(56, 134);
            labelBookNum.Name = "labelBookNum";
            labelBookNum.Size = new Size(101, 20);
            labelBookNum.TabIndex = 6;
            labelBookNum.Text = "Book Number";
            // 
            // bookNum
            // 
            bookNum.Location = new Point(328, 135);
            bookNum.Name = "bookNum";
            bookNum.Size = new Size(25, 23);
            bookNum.TabIndex = 7;
            bookNum.TextAlign = HorizontalAlignment.Right;
            // 
            // bookAuthor
            // 
            bookAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookAuthor.AutoCompleteSource = AutoCompleteSource.ListItems;
            bookAuthor.FormattingEnabled = true;
            bookAuthor.Location = new Point(176, 181);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(177, 23);
            bookAuthor.TabIndex = 9;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthor.Location = new Point(56, 184);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(54, 20);
            labelAuthor.TabIndex = 8;
            labelAuthor.Text = "Author";
            // 
            // bookDate
            // 
            bookDate.Location = new Point(176, 300);
            bookDate.Name = "bookDate";
            bookDate.Size = new Size(177, 23);
            bookDate.TabIndex = 11;
            bookDate.TextAlign = HorizontalAlignment.Right;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(56, 299);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(82, 20);
            labelDate.TabIndex = 10;
            labelDate.Text = "Finish Date";
            // 
            // bookMedium
            // 
            bookMedium.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookMedium.AutoCompleteSource = AutoCompleteSource.ListItems;
            bookMedium.FormattingEnabled = true;
            bookMedium.Location = new Point(233, 420);
            bookMedium.Name = "bookMedium";
            bookMedium.Size = new Size(119, 23);
            bookMedium.TabIndex = 13;
            // 
            // labelMedium
            // 
            labelMedium.AutoSize = true;
            labelMedium.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelMedium.Location = new Point(56, 423);
            labelMedium.Name = "labelMedium";
            labelMedium.Size = new Size(64, 20);
            labelMedium.TabIndex = 12;
            labelMedium.Text = "Medium";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelGenre.Location = new Point(56, 358);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(48, 20);
            labelGenre.TabIndex = 15;
            labelGenre.Text = "Genre";
            // 
            // bookGenre
            // 
            bookGenre.Location = new Point(176, 358);
            bookGenre.Name = "bookGenre";
            bookGenre.Size = new Size(177, 23);
            bookGenre.TabIndex = 17;
            bookGenre.TextAlign = HorizontalAlignment.Right;
            // 
            // listBookGenre
            // 
            listBookGenre.FormattingEnabled = true;
            listBookGenre.ItemHeight = 15;
            listBookGenre.Location = new Point(380, 358);
            listBookGenre.Name = "listBookGenre";
            listBookGenre.Size = new Size(120, 154);
            listBookGenre.TabIndex = 18;
            listBookGenre.Visible = false;
            // 
            // labelCover
            // 
            labelCover.AutoSize = true;
            labelCover.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCover.Location = new Point(56, 237);
            labelCover.Name = "labelCover";
            labelCover.Size = new Size(47, 20);
            labelCover.TabIndex = 19;
            labelCover.Text = "Cover";
            // 
            // bCoverFile
            // 
            bCoverFile.Location = new Point(380, 237);
            bCoverFile.Name = "bCoverFile";
            bCoverFile.Size = new Size(75, 23);
            bCoverFile.TabIndex = 21;
            bCoverFile.Text = "Choose";
            bCoverFile.UseVisualStyleBackColor = true;
            bCoverFile.Click += bCoverFile_Click;
            // 
            // bookCover
            // 
            bookCover.Location = new Point(127, 238);
            bookCover.Name = "bookCover";
            bookCover.Size = new Size(226, 23);
            bookCover.TabIndex = 22;
            bookCover.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(380, 135);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewComplBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 569);
            Controls.Add(button1);
            Controls.Add(bookCover);
            Controls.Add(bCoverFile);
            Controls.Add(labelCover);
            Controls.Add(listBookGenre);
            Controls.Add(bookGenre);
            Controls.Add(labelGenre);
            Controls.Add(bookMedium);
            Controls.Add(labelMedium);
            Controls.Add(bookDate);
            Controls.Add(labelDate);
            Controls.Add(bookAuthor);
            Controls.Add(labelAuthor);
            Controls.Add(bookNum);
            Controls.Add(labelBookNum);
            Controls.Add(bookSeries);
            Controls.Add(labelSeries);
            Controls.Add(labelTitle);
            Controls.Add(bookTitle);
            Controls.Add(bSubmit);
            Name = "AddNewComplBookForm";
            Text = "New Book";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSubmit;
        private TextBox bookTitle;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelTitle;
        private Label labelSeries;
        private ComboBox bookSeries;
        private Label labelBookNum;
        private TextBox bookNum;
        private ComboBox bookAuthor;
        private Label labelAuthor;
        private TextBox bookDate;
        private Label labelDate;
        private ComboBox bookMedium;
        private Label labelMedium;
        private Label labelGenre;
        private TextBox bookGenre;
        private ListBox listBookGenre;
        private Label labelCover;
        private Button bCoverFile;
        private TextBox bookCover;
        private Button button1;
    }
}