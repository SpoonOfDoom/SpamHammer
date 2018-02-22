using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SpamHammer
{
    public partial class Form1 : Form
    {
        private SpamHammer spamHammer = new SpamHammer();
        private int maxNGramLength;
        private string trainingDataFilename = "SpamDetectionData.txt";
        List<string> spamTrainingData = new List<string>();
        List<string> hamTrainingData = new List<string>();
        List<string> testData = new List<string>();


        public Form1()
        {
            InitializeComponent();
            textBoxMissingNGramPoints.Text = spamHammer.missingNGramPoints.ToString();
        }

        private void btnDoTraining_Click(object sender, EventArgs e)
        {
            try
            {
                maxNGramLength = int.Parse(textBoxNGramLength.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a valid integer for the nGram length.",
                                "Couldn't parse nGram length input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            labelStatus.Text = "I'mma learn me some things!";
            btnAnalyseTestData.Enabled = false;
            btnDoTraining.Enabled = false;
            textBoxNGramLength.Enabled = false;

            if (spamTrainingData.Count == 0 || hamTrainingData.Count == 0 || testData.Count == 0)
            {
                spamTrainingData.Clear();
                hamTrainingData.Clear();
                testData.Clear();
                
                SortTestData(trainingDataFilename);
            }

            spamHammer.AnalyseSpamTrainingData(spamTrainingData, maxNGramLength);
            labelStatus.Text = "Learned spam!";
            spamHammer.AnalyseHamTrainingData(hamTrainingData, maxNGramLength);
            labelStatus.Text = "I learned!";
            labelSpamNGramCount.Text = spamHammer.GetStatsCount(MessageType.Spam).ToString();
            labelHamNGramsFound.Text = spamHammer.GetStatsCount(MessageType.Ham).ToString();
            btnAnalyseTestData.Enabled = true;
            textBoxNGramLength.Enabled = true;
        }

        private void SortTestData(string filename)
        {
            string[] inputLines = File.ReadAllLines(filename);
            List<string> targetList = null;
            foreach (string line in inputLines)
            {
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
                    targetList = testData;
                    continue;
                }

                if (line.Trim().Length == 0)
                {
                    continue;
                }

                targetList.Add(line);
            }
        }

        private void btnAnalyseTestData_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Doing the thing...";
            btnAnalyseTestData.Enabled = false;
            if (spamTrainingData.Count == 0)
            {
                MessageBox.Show("Cannot evaluate test data without first learning from the training data!",
                                "I should really serialize that data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            Tuple<int, int> results = spamHammer.AnalyseTestData(testData, maxNGramLength);
            if (results is null)
            {
                labelStatus.Text = "Couldn't do the thing.";
                return;
            }
            double correct = results.Item1;
            double wrong = results.Item2;
            double correctPercent = (correct / testData.Count) * 100;
            double wrongPercent = (wrong / testData.Count) * 100;
            labelStatus.Text = "I did the thing!";
            labelCorrect.Text = $"{correct} / {testData.Count} correct ({correctPercent.ToString("F2")}%)";
            labelWrong.Text = $"{wrong} / {testData.Count} wrong ({wrongPercent.ToString("F2")}%)";
            btnAnalyseTestData.Enabled = true;
        }

        private void textBoxNGramLength_TextChanged(object sender, EventArgs e)
        {
            spamHammer.Reset();
            btnDoTraining.Enabled = true;
            btnAnalyseTestData.Enabled = false;

            labelStatus.Text = "Reset!";
            labelCorrect.Text = "0 / 0";
            labelWrong.Text = "0 / 0";
            labelHamNGramsFound.Text = "0";
            labelSpamNGramCount.Text = "0";
        }

        private void textBoxMissingNGramPoints_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newValue = int.Parse(textBoxMissingNGramPoints.Text);
                spamHammer.missingNGramPoints = newValue;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a valid integer for the missing nGram point value.",
                                "Couldn't parse missing nGram points input.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
