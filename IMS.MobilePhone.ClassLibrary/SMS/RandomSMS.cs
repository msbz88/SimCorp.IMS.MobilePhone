using System;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class RandomSMS {
        private static Random random = new Random();

        public string RandomName() {
            List<string> userNames = new List<string> { "John", "Sam", "Rob", "Martin", "Julia", "Eva" };
            int index = random.Next(userNames.Count);
            string curName = userNames[index];
            userNames.RemoveAt(index);
            return curName;
        }

        public string RandomMessage() {
            List<string> userPhrases = new List<string> { "Hello!", "Hi!", "How are u?", "Bye", "How do you like Japan so far?",
                "See you this weekend!" , "In my view, it's a difficult task.", "What do you think?", "What a wonderful day!",
                "You did it!", "Well done!", "Don't get upset.", "Let's go to a football game.", "Why don't we go to a concert?",
                "Why do you ask?", "Nice morning today, isn't it?", "Do you agree?" };
            int index = random.Next(userPhrases.Count);
            string curPhrase = userPhrases[index];
            userPhrases.RemoveAt(index);
            return curPhrase;
        }
    }
}
