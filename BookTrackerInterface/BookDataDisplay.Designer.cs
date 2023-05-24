namespace FunctionalityForms
{
    partial class BookDataDisplay
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
            tbTitle = new TextBox();
            tbSeries = new TextBox();
            tbNum = new TextBox();
            tbAuthor = new TextBox();
            pbCover = new PictureBox();
            tbDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.BackColor = SystemColors.Window;
            tbTitle.Location = new Point(3, 142);
            tbTitle.Multiline = true;
            tbTitle.Name = "tbTitle";
            tbTitle.ReadOnly = true;
            tbTitle.Size = new Size(179, 39);
            tbTitle.TabIndex = 0;
            // 
            // tbSeries
            // 
            tbSeries.BackColor = SystemColors.Window;
            tbSeries.Location = new Point(3, 187);
            tbSeries.Name = "tbSeries";
            tbSeries.ReadOnly = true;
            tbSeries.Size = new Size(126, 23);
            tbSeries.TabIndex = 1;
            // 
            // tbNum
            // 
            tbNum.BackColor = SystemColors.Window;
            tbNum.Location = new Point(156, 187);
            tbNum.Name = "tbNum";
            tbNum.ReadOnly = true;
            tbNum.Size = new Size(26, 23);
            tbNum.TabIndex = 2;
            tbNum.TextAlign = HorizontalAlignment.Center;
            // 
            // tbAuthor
            // 
            tbAuthor.BackColor = SystemColors.Window;
            tbAuthor.Location = new Point(3, 216);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.ReadOnly = true;
            tbAuthor.Size = new Size(179, 23);
            tbAuthor.TabIndex = 3;
            // 
            // pbCover
            // 
            pbCover.Location = new Point(3, 4);
            pbCover.Name = "pbCover";
            pbCover.Size = new Size(179, 132);
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbCover.TabIndex = 4;
            pbCover.TabStop = false;
            // 
            // tbDate
            // 
            tbDate.BackColor = SystemColors.Window;
            tbDate.Location = new Point(3, 245);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(126, 23);
            tbDate.TabIndex = 5;
            // 
            // BookDataDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tbDate);
            Controls.Add(pbCover);
            Controls.Add(tbAuthor);
            Controls.Add(tbNum);
            Controls.Add(tbSeries);
            Controls.Add(tbTitle);
            Name = "BookDataDisplay";
            Size = new Size(187, 271);
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitle;
        private TextBox tbSeries;
        private TextBox tbNum;
        private TextBox tbAuthor;
        private PictureBox pbCover;
        private TextBox tbDate;
    }
}
