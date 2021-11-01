
namespace OpenFile
{
    partial class OpenFile
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
            this.RandNumListBox = new System.Windows.Forms.ListBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.numTotalLabels = new System.Windows.Forms.Label();
            this.numRandNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RandNumListBox
            // 
            this.RandNumListBox.FormattingEnabled = true;
            this.RandNumListBox.ItemHeight = 15;
            this.RandNumListBox.Items.AddRange(new object[] {
            ""});
            this.RandNumListBox.Location = new System.Drawing.Point(33, 12);
            this.RandNumListBox.Name = "RandNumListBox";
            this.RandNumListBox.Size = new System.Drawing.Size(120, 94);
            this.RandNumListBox.TabIndex = 0;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(53, 112);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // numTotalLabels
            // 
            this.numTotalLabels.AutoSize = true;
            this.numTotalLabels.Location = new System.Drawing.Point(12, 138);
            this.numTotalLabels.Name = "numTotalLabels";
            this.numTotalLabels.Size = new System.Drawing.Size(102, 15);
            this.numTotalLabels.TabIndex = 2;
            this.numTotalLabels.Text = "Total of numbers: ";
            // 
            // numRandNumLabel
            // 
            this.numRandNumLabel.AutoSize = true;
            this.numRandNumLabel.Location = new System.Drawing.Point(12, 153);
            this.numRandNumLabel.Name = "numRandNumLabel";
            this.numRandNumLabel.Size = new System.Drawing.Size(121, 15);
            this.numRandNumLabel.TabIndex = 3;
            this.numRandNumLabel.Text = "Number of numbers: ";
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 174);
            this.Controls.Add(this.numRandNumLabel);
            this.Controls.Add(this.numTotalLabels);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.RandNumListBox);
            this.Name = "OpenFile";
            this.Text = "Open File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RandNumListBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label numTotalLabels;
        private System.Windows.Forms.Label numRandNumLabel;
    }
}

