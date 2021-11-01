
namespace LoopsFilesAndRandomNumbersHomework
{
    partial class SaveFile
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
            this.RanNumLabel = new System.Windows.Forms.Label();
            this.RanNumTexbox = new System.Windows.Forms.TextBox();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RanNumLabel
            // 
            this.RanNumLabel.AutoSize = true;
            this.RanNumLabel.Location = new System.Drawing.Point(12, 9);
            this.RanNumLabel.Name = "RanNumLabel";
            this.RanNumLabel.Size = new System.Drawing.Size(253, 15);
            this.RanNumLabel.TabIndex = 0;
            this.RanNumLabel.Text = "Number of random numbers the file will hold: ";
            // 
            // RanNumTexbox
            // 
            this.RanNumTexbox.Location = new System.Drawing.Point(271, 6);
            this.RanNumTexbox.Name = "RanNumTexbox";
            this.RanNumTexbox.Size = new System.Drawing.Size(100, 23);
            this.RanNumTexbox.TabIndex = 1;
            this.RanNumTexbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(154, 56);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // SaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 91);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.RanNumTexbox);
            this.Controls.Add(this.RanNumLabel);
            this.Name = "SaveFile";
            this.Text = "Save File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RanNumLabel;
        private System.Windows.Forms.TextBox RanNumTexbox;
        private System.Windows.Forms.Button SaveFileButton;
    }
}

