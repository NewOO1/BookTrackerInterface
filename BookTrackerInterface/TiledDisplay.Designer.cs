namespace FunctionalityForms
{
    partial class TiledDisplay
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
            tlp = new TableLayoutPanel();
            tbTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPerMonth = new TextBox();
            SuspendLayout();
            // 
            // tlp
            // 
            tlp.AutoScroll = true;
            tlp.AutoSize = true;
            tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp.ColumnCount = 4;
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
            tbTotal.Location = new Point(304, 12);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(42, 28);
            tbTotal.TabIndex = 2;
            tbTotal.TabStop = false;
            tbTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(274, 30);
            label1.TabIndex = 3;
            label1.Text = "Total Books Read This Year ::";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(524, 12);
            label2.Name = "label2";
            label2.Size = new Size(208, 30);
            label2.TabIndex = 4;
            label2.Text = "Average Per Month ::";
            // 
            // tbPerMonth
            // 
            tbPerMonth.BackColor = SystemColors.Control;
            tbPerMonth.BorderStyle = BorderStyle.None;
            tbPerMonth.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbPerMonth.Location = new Point(738, 12);
            tbPerMonth.Name = "tbPerMonth";
            tbPerMonth.ReadOnly = true;
            tbPerMonth.Size = new Size(42, 28);
            tbPerMonth.TabIndex = 5;
            tbPerMonth.TabStop = false;
            tbPerMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // TiledDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1272, 824);
            Controls.Add(tbPerMonth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbTotal);
            Controls.Add(tlp);
            Name = "TiledDisplay";
            Text = "TiledDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlp;
        private TextBox tbTotal;
        private Label label1;
        private Label label2;
        private TextBox tbPerMonth;
    }
}