namespace FunctionalityForms
{
    partial class AddNewBookForm
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
            tbTitle = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelTitle = new Label();
            labelSeries = new Label();
            cbSeries = new ComboBox();
            labelBookNum = new Label();
            tbNum = new TextBox();
            cbAuthor = new ComboBox();
            labelAuthor = new Label();
            tbDate = new TextBox();
            labelDate = new Label();
            cbMedium = new ComboBox();
            labelMedium = new Label();
            labelGenre = new Label();
            tbGenre = new TextBox();
            listBookGenre = new ListBox();
            labelCover = new Label();
            bCoverFile = new Button();
            tbCover = new TextBox();
            pbCover = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
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
            // tbTitle
            // 
            tbTitle.Location = new Point(127, 41);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(226, 23);
            tbTitle.TabIndex = 1;
            tbTitle.TextAlign = HorizontalAlignment.Right;
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
            // cbSeries
            // 
            cbSeries.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSeries.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSeries.FormattingEnabled = true;
            cbSeries.Location = new Point(176, 87);
            cbSeries.Name = "cbSeries";
            cbSeries.Size = new Size(177, 23);
            cbSeries.TabIndex = 5;
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
            // tbNum
            // 
            tbNum.Location = new Point(328, 135);
            tbNum.Name = "tbNum";
            tbNum.Size = new Size(25, 23);
            tbNum.TabIndex = 7;
            tbNum.TextAlign = HorizontalAlignment.Right;
            // 
            // cbAuthor
            // 
            cbAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAuthor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(176, 181);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(177, 23);
            cbAuthor.TabIndex = 9;
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
            // tbDate
            // 
            tbDate.Location = new Point(176, 300);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(177, 23);
            tbDate.TabIndex = 11;
            tbDate.TextAlign = HorizontalAlignment.Right;
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
            // cbMedium
            // 
            cbMedium.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMedium.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbMedium.FormattingEnabled = true;
            cbMedium.Location = new Point(233, 420);
            cbMedium.Name = "cbMedium";
            cbMedium.Size = new Size(119, 23);
            cbMedium.TabIndex = 13;
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
            // tbGenre
            // 
            tbGenre.Location = new Point(176, 358);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(177, 23);
            tbGenre.TabIndex = 17;
            tbGenre.TextAlign = HorizontalAlignment.Right;
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
            // tbCover
            // 
            tbCover.Location = new Point(127, 238);
            tbCover.Name = "tbCover";
            tbCover.Size = new Size(226, 23);
            tbCover.TabIndex = 22;
            tbCover.TextAlign = HorizontalAlignment.Right;
            // 
            // pbCover
            // 
            pbCover.Location = new Point(380, 41);
            pbCover.Name = "pbCover";
            pbCover.Size = new Size(120, 171);
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbCover.TabIndex = 23;
            pbCover.TabStop = false;
            // 
            // AddNewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 569);
            Controls.Add(pbCover);
            Controls.Add(tbCover);
            Controls.Add(bCoverFile);
            Controls.Add(labelCover);
            Controls.Add(listBookGenre);
            Controls.Add(tbGenre);
            Controls.Add(labelGenre);
            Controls.Add(cbMedium);
            Controls.Add(labelMedium);
            Controls.Add(tbDate);
            Controls.Add(labelDate);
            Controls.Add(cbAuthor);
            Controls.Add(labelAuthor);
            Controls.Add(tbNum);
            Controls.Add(labelBookNum);
            Controls.Add(cbSeries);
            Controls.Add(labelSeries);
            Controls.Add(labelTitle);
            Controls.Add(tbTitle);
            Controls.Add(bSubmit);
            Name = "AddNewBookForm";
            Text = "New Book";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSubmit;
        private TextBox tbTitle;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelTitle;
        private Label labelSeries;
        private ComboBox cbSeries;
        private Label labelBookNum;
        private TextBox tbNum;
        private ComboBox cbAuthor;
        private Label labelAuthor;
        private TextBox tbDate;
        private Label labelDate;
        private ComboBox cbMedium;
        private Label labelMedium;
        private Label labelGenre;
        private TextBox tbGenre;
        private ListBox listBookGenre;
        private Label labelCover;
        private Button bCoverFile;
        private TextBox tbCover;
        private PictureBox pbCover;
    }
}