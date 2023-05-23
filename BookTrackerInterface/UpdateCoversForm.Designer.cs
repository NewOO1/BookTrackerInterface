namespace FunctionalityForms
{
    partial class UpdateCoversForm
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
            labelTitle = new Label();
            labelCover = new Label();
            tbCover = new TextBox();
            cbTitle = new ComboBox();
            bCover = new Button();
            bSubmit = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(22, 32);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelCover
            // 
            labelCover.AutoSize = true;
            labelCover.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCover.Location = new Point(22, 80);
            labelCover.Name = "labelCover";
            labelCover.Size = new Size(47, 20);
            labelCover.TabIndex = 1;
            labelCover.Text = "Cover";
            // 
            // tbCover
            // 
            tbCover.Location = new Point(96, 81);
            tbCover.Name = "tbCover";
            tbCover.Size = new Size(281, 23);
            tbCover.TabIndex = 2;
            // 
            // cbTitle
            // 
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(96, 29);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(281, 23);
            cbTitle.TabIndex = 3;
            // 
            // bCover
            // 
            bCover.Location = new Point(302, 110);
            bCover.Name = "bCover";
            bCover.Size = new Size(75, 23);
            bCover.TabIndex = 4;
            bCover.Text = "Choose";
            bCover.UseVisualStyleBackColor = true;
            bCover.Click += bCover_Click;
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(22, 150);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 5;
            bSubmit.Text = "Update";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // UpdateCoversForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 197);
            Controls.Add(bSubmit);
            Controls.Add(bCover);
            Controls.Add(cbTitle);
            Controls.Add(tbCover);
            Controls.Add(labelCover);
            Controls.Add(labelTitle);
            Name = "UpdateCoversForm";
            Text = "UpdateCoversForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelCover;
        private TextBox tbCover;
        private ComboBox cbTitle;
        private Button bCover;
        private Button bSubmit;
    }
}