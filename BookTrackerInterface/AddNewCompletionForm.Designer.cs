namespace FunctionalityForms
{
    partial class AddNewCompletionForm
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
            labelDate = new Label();
            labelMedium = new Label();
            cbTitle = new ComboBox();
            tbDate = new TextBox();
            cbMedium = new ComboBox();
            bSubmit = new Button();
            cbWho = new ComboBox();
            labelWho = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(17, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(17, 49);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            // 
            // labelMedium
            // 
            labelMedium.AutoSize = true;
            labelMedium.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMedium.Location = new Point(15, 81);
            labelMedium.Name = "labelMedium";
            labelMedium.Size = new Size(64, 20);
            labelMedium.TabIndex = 2;
            labelMedium.Text = "Medium";
            // 
            // cbTitle
            // 
            cbTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(100, 20);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(271, 23);
            cbTitle.TabIndex = 3;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(100, 49);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(123, 23);
            tbDate.TabIndex = 4;
            // 
            // cbMedium
            // 
            cbMedium.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMedium.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbMedium.FormattingEnabled = true;
            cbMedium.Location = new Point(100, 78);
            cbMedium.Name = "cbMedium";
            cbMedium.Size = new Size(121, 23);
            cbMedium.TabIndex = 5;
            // 
            // bSubmit
            // 
            bSubmit.Location = new Point(17, 141);
            bSubmit.Name = "bSubmit";
            bSubmit.Size = new Size(75, 23);
            bSubmit.TabIndex = 6;
            bSubmit.Text = "Submit";
            bSubmit.UseVisualStyleBackColor = true;
            bSubmit.Click += bSubmit_Click;
            // 
            // cbWho
            // 
            cbWho.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbWho.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbWho.FormattingEnabled = true;
            cbWho.Location = new Point(100, 107);
            cbWho.Name = "cbWho";
            cbWho.Size = new Size(121, 23);
            cbWho.TabIndex = 8;
            // 
            // labelWho
            // 
            labelWho.AutoSize = true;
            labelWho.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWho.Location = new Point(17, 110);
            labelWho.Name = "labelWho";
            labelWho.Size = new Size(40, 20);
            labelWho.TabIndex = 7;
            labelWho.Text = "Who";
            // 
            // AddNewCompletionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 196);
            Controls.Add(cbWho);
            Controls.Add(labelWho);
            Controls.Add(bSubmit);
            Controls.Add(cbMedium);
            Controls.Add(tbDate);
            Controls.Add(cbTitle);
            Controls.Add(labelMedium);
            Controls.Add(labelDate);
            Controls.Add(labelTitle);
            Name = "AddNewCompletionForm";
            Text = "AddNewCompletion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDate;
        private Label labelMedium;
        private ComboBox cbTitle;
        private TextBox tbDate;
        private ComboBox cbMedium;
        private Button bSubmit;
        private ComboBox cbWho;
        private Label labelWho;
    }
}