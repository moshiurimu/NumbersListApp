namespace NumbersListApp
{
    partial class AddNumberUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.showAllNumberButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(168, 244);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(91, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(118, 142);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(141, 95);
            this.numbersListBox.TabIndex = 10;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(118, 27);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(141, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // showAllNumberButton
            // 
            this.showAllNumberButton.Location = new System.Drawing.Point(184, 102);
            this.showAllNumberButton.Name = "showAllNumberButton";
            this.showAllNumberButton.Size = new System.Drawing.Size(75, 23);
            this.showAllNumberButton.TabIndex = 9;
            this.showAllNumberButton.Text = "Show All";
            this.showAllNumberButton.UseVisualStyleBackColor = true;
            this.showAllNumberButton.Click += new System.EventHandler(this.showAllNumberButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(184, 63);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Number";
            // 
            // AddNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.numbersListBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.showAllNumberButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "AddNumberUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button showAllNumberButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
    }
}

