using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFile
{
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            int totalOfNums = 0;
            int listSize = 0;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileLocation = openFileDialog.FileName;

                List<int> numsAsInts = new List<int>();

                using (TextReader reader = File.OpenText(fileLocation))
                {
                    string num;
                    while ((num = reader.ReadLine()) != null)
                    {
                        numsAsInts.Add(int.Parse(num));
                    } 
                }

                listSize = numsAsInts.Count;

                RandNumListBox.Items.Clear();

                foreach (int num in numsAsInts)
                {
                    RandNumListBox.Items.Add(num);
                    totalOfNums += num;
                }
            }

            numTotalLabels.Text = $"{numTotalLabels.Text}{totalOfNums}";
            numRandNumLabel.Text = $"{numRandNumLabel.Text}{listSize}";
        }
    }
}
