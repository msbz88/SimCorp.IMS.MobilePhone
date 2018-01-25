using System;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Contact {
    public class RandomCall {
        private static Random random = new Random();

        public string RandomName() {
            List<string> userNames = new List<string> { "John", "Sam", "Rob", "Martin", "Julia", "Eva", "Tom", "Kate" };
            int index = random.Next(userNames.Count);
            string curName = userNames[index];
            userNames.RemoveAt(index);
            return curName;
        }

        public string RandomDirection() {
            List<string> dir = new List<string> { "In", "Out" };
            int index = random.Next(dir.Count);
            string curDir = dir[index];
            dir.RemoveAt(index);
            return curDir;
        }

        public string RandomNumber() {
            List<string> dir = new List<string> { "0967115458", "0977845588", "0961245478", "0967844478" };
            int index = random.Next(dir.Count);
            string curNum = dir[index];
            dir.RemoveAt(index);
            return curNum;
        }
    }
}
