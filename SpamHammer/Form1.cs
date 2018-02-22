using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SpamHammer
{
    public partial class Form1 : Form
    {
        private SpamHammer spamHammer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoTraining_Click(object sender, EventArgs e)
        {
            List<string> spamTrainingData = new List<string>();
            List<string> hamTrainingData = new List<string>();

            string[] inputLines = File.ReadAllLines("SpamDetectionData.txt");
            List<string> targetList = null;
            for (int i = 0; i < inputLines.Length; i++)
            {
                string line = inputLines[i];
                if (line.StartsWith("# Spam"))
                {
                    targetList = spamTrainingData;
                    continue;
                }

                if (line.StartsWith("# Ham"))
                {
                    targetList = hamTrainingData;
                    continue;
                }

                if (line.StartsWith("# Test"))
                {
                    break;
                }

                targetList.Add(line);
            }

            spamHammer.AnalyseSpamTrainingData(spamTrainingData);
            spamHammer.AnalyseHamTrainingData(hamTrainingData);
        }
    }
}
