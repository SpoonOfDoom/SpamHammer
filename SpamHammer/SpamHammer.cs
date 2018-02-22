using System.Collections.Generic;
using System.Linq;

namespace SpamHammer
{
    public class SpamHammer
    {
        public void AnalyseSpamTrainingData(List<string> spamTrainingData)
        {
            List<Message> messages = spamTrainingData.Select(s => new Message(s)).ToList();

        }

        public void AnalyseHamTrainingData(List<string> hamTrainingData)
        {

        }

        public void AnalyseTestData(List<string> testData)
        {

        }

        private void AnalyseSpamMessage(Message message)
        {

        }

        private void AnalyseHamMessage(Message message)
        {

        }

        private void AnalyseTestMessage(Message message)
        {

        }
    }
}
