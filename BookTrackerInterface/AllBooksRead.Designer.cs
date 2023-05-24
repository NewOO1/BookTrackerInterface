namespace FunctionalityForms
{
    partial class AllBooksRead
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
            bTrigger = new Button();
            tlp = new TableLayoutPanel();
            tbTotal = new TextBox();
            SuspendLayout();
            // 
            // bTrigger
            // 
            bTrigger.Location = new Point(12, 12);
            bTrigger.Name = "bTrigger";
            bTrigger.Size = new Size(75, 23);
            bTrigger.TabIndex = 0;
            bTrigger.Text = "Show";
            bTrigger.UseVisualStyleBackColor = true;
            bTrigger.Click += bTrigger_Click;
            // 
            // tlp
            // 
            tlp.AutoSize = true;
            tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp.ColumnCount = 5;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp.Location = new Point(24, 59);
            tlp.Name = "tlp";
            tlp.Size = new Size(0, 0);
            tlp.TabIndex = 1;
            // 
            // tbTotal
            // 
            tbTotal.BackColor = SystemColors.Control;
            tbTotal.BorderStyle = BorderStyle.None;
            tbTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbTotal.Location = new Point(121, 12);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(103, 28);
            tbTotal.TabIndex = 2;
            tbTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // BooksReadThisYear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1272, 824);
            Controls.Add(tbTotal);
            Controls.Add(tlp);
            Controls.Add(bTrigger);
            Name = "TotalBooksRead";
            Text = "TotalBooksRead";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bTrigger;
        private TableLayoutPanel tlp;
        private TextBox tbTotal;
    }
}