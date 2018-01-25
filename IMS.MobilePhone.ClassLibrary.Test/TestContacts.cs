using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.Contact;
using System;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Test {
    [TestClass]
    public class TestContacts {
        [TestMethod]
        public void TestSorting() {
            List<Call> resultSorting = new List<Call>();
            Call call1 = new Call("User1", DateTime.Now, "In");
            Call call2 = new Call("User2", DateTime.Now.AddMinutes(1), "Out");
            Call call3 = new Call("User3", DateTime.Now.AddMinutes(2), "Out");
            Call call4 = new Call("User4", DateTime.Now.AddMinutes(3), "In");
            Call call5 = new Call("User5", DateTime.Now.AddMinutes(4), "In");
            resultSorting.Add(call2);
            resultSorting.Add(call4);
            resultSorting.Add(call1);
            resultSorting.Add(call5);
            resultSorting.Add(call3);
            resultSorting.Sort();
            List<Call> expectedSorting = new List<Call>();
            expectedSorting.Add(call5);
            expectedSorting.Add(call4);
            expectedSorting.Add(call3);
            expectedSorting.Add(call2);
            expectedSorting.Add(call1);
            CollectionAssert.AreEqual(expectedSorting, resultSorting);
        }
    }
}
