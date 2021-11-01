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

namespace LoopsFilesAndRandomNumbersHomework
{
    public partial class SaveFile : Form
    {
        public SaveFile()
        {
            InitializeComponent();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            int[] randNumArray = GenerateRandomNumbers();
            string numsAsString = string.Join("\n", randNumArray);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, numsAsString);
            }
        }

        private int[] GenerateRandomNumbers()
        {
            var rand = new Random();

            int numOfRandNum = Convert.ToInt32(RanNumTexbox.Text); 
            var randNums = new int[numOfRandNum];

            for (int i = 0; i < numOfRandNum; i++)
            {
                randNums[i] = rand.Next(101);
            }

            return randNums;
        }
    }
}
