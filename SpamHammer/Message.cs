using System;
using System.Collections.Generic;

namespace SpamHammer
{
    public class Message
    {
        static List<char> boundaryCharacters = new List<char> {' ', ',', '.', '<', '>', '/'};

        public MessageType ActualType;
        public MessageType GuessedType;
        private string Content;
        

        public Message(string message)
        {
            int i = message.IndexOf(',');
            string type = message.Substring(0, i);
            string content = message.Substring(i + 1);
            //todo: strip/analyze html
            try
            {
                Enum.TryParse(type, true, out ActualType);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("This probably shouldn't happen with the provided training data, should it?");
                ActualType = MessageType.Unknown;
            }

            Content = content;
        }
        
        public Dictionary<string, int> CollectAllNGrams(int maxNGramLength)
        {
            Dictionary<string, int> nGramCounts = new Dictionary<string, int>();
            for (int i = 1; i <= maxNGramLength; i++)
            {
                foreach (KeyValuePair<string, int> pair in CollectNLengthNGramCounts(i))
                {
                    if (!nGramCounts.ContainsKey(pair.Key))
                    {
                        nGramCounts[pair.Key] = 0;
                    }

                    nGramCounts[pair.Key] += pair.Value;
                }
            }
            return nGramCounts;
        }

        public Dictionary<string, int> CollectNLengthNGramCounts(int nGramLength)
        {
            Dictionary<string, int> nGramCounts = new Dictionary<string, int>();
            
            for (int i = 0; i + nGramLength <= Content.Length; i++)
            {
                string nGram = Content.Substring(i, nGramLength);
                if (!(i == 0 || boundaryCharacters.Contains(Content[i-1])))
                {
                    nGram = "_" + nGram;
                }

                if (!(i + nGramLength == Content.Length || boundaryCharacters.Contains(Content[i + nGramLength])))
                {
                    nGram = nGram + "_";
                }

                if (!nGramCounts.ContainsKey(nGram))
                {
                    nGramCounts[nGram] = 0;
                }

                nGramCounts[nGram]++;
            }

            return nGramCounts;
        }
    }
}
