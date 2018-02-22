using System;

namespace SpamHammer
{
    public class Message
    {
        public MessageType ActualType;
        public MessageType GuessedType;
        public string Content;

        public Message(string message)
        {
            int i = message.IndexOf(',');
            string type = message.Substring(0, i);
            string content = message.Substring(i + 1);
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
    }
}
