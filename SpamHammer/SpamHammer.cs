using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SpamHammer
{
    public class SpamHammer
    {
        private Dictionary<string, double> spamNGramStats = new Dictionary<string, double>();
        private Dictionary<string, double> hamNGramStats = new Dictionary<string, double>();
        public int missingNGramPoints = 300;

        public void Reset()
        {
            spamNGramStats.Clear();
            hamNGramStats.Clear();
        }

        public int GetStatsCount(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Ham:
                    return hamNGramStats.Count;
                case MessageType.Spam:
                    return spamNGramStats.Count;
                default:
                    throw new ArgumentOutOfRangeException(nameof(messageType), messageType, null);
            }
        }

        public void AnalyseSpamTrainingData(List<string> spamTrainingData, int maxNGramLength)
        {
            List<Message> messages = spamTrainingData.Select(s => new Message(s)).ToList();

            foreach (Message message in messages)
            {
                foreach (KeyValuePair<string, int> pair in message.CollectAllNGrams(maxNGramLength))
                {
                    if (!spamNGramStats.ContainsKey(pair.Key))
                    {
                        spamNGramStats[pair.Key] = 0;
                    }

                    spamNGramStats[pair.Key] += pair.Value;
                }
            }

            foreach (string key in spamNGramStats.Keys.ToList())
            {
                spamNGramStats[key] = spamNGramStats[key] / messages.Count;
            }
        }

        public void AnalyseHamTrainingData(List<string> hamTrainingData, int maxNGramLength)
        {
            List<Message> messages = hamTrainingData.Select(s => new Message(s)).ToList();

            foreach (Message message in messages)
            {
                foreach (KeyValuePair<string, int> kvp in message.CollectAllNGrams(maxNGramLength))
                {
                    if (!hamNGramStats.ContainsKey(kvp.Key))
                    {
                        hamNGramStats[kvp.Key] = 0;
                    }

                    hamNGramStats[kvp.Key] += kvp.Value;
                }
            }

            foreach (string key in hamNGramStats.Keys.ToList())
            {
                hamNGramStats[key] = hamNGramStats[key] / messages.Count;
            }
        }

        private void JudgeMessage(Message message, int maxNGramLength)
        {
            Dictionary<string, int> messageNGrams = message.CollectAllNGrams(maxNGramLength);
            double spamScore = CalculateScore(messageNGrams, spamNGramStats);
            double hamScore = CalculateScore(messageNGrams, hamNGramStats);
            message.GuessedType = spamScore > hamScore ? MessageType.Spam : MessageType.Ham;
        }

        private double CalculateScore(Dictionary<string, int> candidateNGrams, Dictionary<string, double> referenceNGrams)
        {
            double totalScore = 0;
            
            foreach (KeyValuePair<string, int> pair in candidateNGrams)
            {
                if (referenceNGrams.ContainsKey(pair.Key))
                {
                    //this feels weird, because we're never adding a positive value to the score, but the end result should be the same. Greater differences result in lower score.
                    double diff = Math.Abs(pair.Value - referenceNGrams[pair.Key]);
                    totalScore -= diff;
                }
                else
                {
                    totalScore -= missingNGramPoints; //arbitrary value. todo: use some kind of average amount maybe? Or use ranking instead of specific value differences at all?
                    //the specific value of this impacts the overall result much more than I expected. Higher values seem to result in much better accuracy for shorter nGrams, which makes sense to a certain degree.
                    //I did expect extremely large values (millions or more) to start negatively impacting the results at some point, but that doesn't seem to be true.
                    //With 300, I get more than 90% accuracy even with only length-1 nGrams, which seems almost too good to be true.
                }
            }
            return totalScore;
        }

        public Tuple<int, int> AnalyseTestData(List<string> testData, int maxNGramLength)
        {
            if (spamNGramStats.Count == 0 || hamNGramStats.Count == 0)
            {
                MessageBox.Show("Cannot evaluate test data without first learning from the training data!",
                                "I should really serialize that data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }
            List<Message> messages = testData.Select(s => new Message(s)).ToList();

            foreach (Message message in messages)
            {
                JudgeMessage(message, maxNGramLength);
            }

            return Tuple.Create(messages.Count(m => m.ActualType == m.GuessedType),
                                messages.Count(m => m.ActualType != m.GuessedType));
        }
    }
}
