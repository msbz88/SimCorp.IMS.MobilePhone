using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.Contacts;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System;
using System.Collections.Generic;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Test {
    [TestClass]
    public class TestContacts {
        CallsGenThread CallsGenThread = new CallsGenThread();

        [TestMethod]
        public void TestSorting() {
            List<Call> resultSorting = new List<Call>();
            Contact contact1 = new Contact("User1", "0948562541");
            Contact contact2 = new Contact("User2", "0948562549");
            Contact contact3 = new Contact("User3", "0948567441");
            Contact contact4 = new Contact("User4", "0955562548");
            Contact contact5 = new Contact("User5", "0948584554");
            Call call1 = new Call(contact1, DateTime.Now, "In");
            Call call2 = new Call(contact2, DateTime.Now.AddMinutes(1), "Out");
            Call call3 = new Call(contact3, DateTime.Now.AddMinutes(2), "Out");
            Call call4 = new Call(contact4, DateTime.Now.AddMinutes(3), "In");
            Call call5 = new Call(contact5, DateTime.Now.AddMinutes(4), "In");
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
        [TestMethod]
        public void TestEqualityUser() {
            MobileStorage.CallGroups.Clear();
            MobileStorage.CallsHistory.Clear();
            Contact contact1 = new Contact("User1", "0948562541");
            Contact contact2 = new Contact("User2", "0948562549");
            Contact contact3 = new Contact("User3", "5555555555");
            Contact contact4 = new Contact("User4", "5555555555");
            Call call1 = new Call(contact1, DateTime.Now.AddMinutes(1), "In");
            Call call2 = new Call(contact2, DateTime.Now.AddMinutes(2), "In");
            Call call3 = new Call(contact3, DateTime.Now.AddMinutes(3), "Out");
            Call call4 = new Call(contact4, DateTime.Now.AddMinutes(4), "Out");
            List<Call> expectedEquality = new List<Call>();
            expectedEquality.Add(call1);
            expectedEquality.Add(call2);
            expectedEquality.Add(call3);
            expectedEquality.Add(call4);
            expectedEquality.Sort();
            CallsGenThread.CheckAndSaveCall(call1);
            CallsGenThread.CheckAndSaveCall(call2);
            CallsGenThread.CheckAndSaveCall(call3);
            CallsGenThread.CheckAndSaveCall(call4);
            List<Call> resultEquality = new List<Call>();
            resultEquality = MobileStorage.CallGroups;
            CollectionAssert.AreEqual(expectedEquality, resultEquality);
        }
        [TestMethod]
        public void TestEqualityNumber() {
            MobileStorage.CallGroups.Clear();
            MobileStorage.CallsHistory.Clear();
            Contact contact1 = new Contact("User1", "0948562541");
            Contact contact2 = new Contact("User2", "0948562549");
            Contact contact3 = new Contact("User4", "5555555444");
            Contact contact4 = new Contact("User4", "5555555555");
            Call call1 = new Call(contact1, DateTime.Now.AddMinutes(1), "Out");
            Call call2 = new Call(contact2, DateTime.Now.AddMinutes(2), "Out");
            Call call3 = new Call(contact3, DateTime.Now.AddMinutes(3), "In");
            Call call4 = new Call(contact4, DateTime.Now.AddMinutes(4), "Out");
            List<Call> expectedEquality = new List<Call>();
            expectedEquality.Add(call1);
            expectedEquality.Add(call2);
            expectedEquality.Add(call3);
            expectedEquality.Add(call4);
            expectedEquality.Sort();
            CallsGenThread.CheckAndSaveCall(call1);
            CallsGenThread.CheckAndSaveCall(call2);
            CallsGenThread.CheckAndSaveCall(call3);
            CallsGenThread.CheckAndSaveCall(call4);
            List<Call> resultEquality = new List<Call>();
            resultEquality = MobileStorage.CallGroups;
            CollectionAssert.AreEqual(expectedEquality, resultEquality);
        }
        [TestMethod]
        public void TestEqualityDirection() {
            MobileStorage.CallGroups.Clear();
            MobileStorage.CallsHistory.Clear();
            Contact contact1 = new Contact("User1", "0948562541");
            Contact contact2 = new Contact("User2", "0948562549");
            Contact contact3 = new Contact("User4", "5555555555");
            Contact contact4 = new Contact("User4", "5555555555");
            Call call1 = new Call(contact1, DateTime.Now.AddMinutes(1), "Out");
            Call call2 = new Call(contact2, DateTime.Now.AddMinutes(2), "Out");
            Call call3 = new Call(contact3, DateTime.Now.AddMinutes(3), "In");
            Call call4 = new Call(contact4, DateTime.Now.AddMinutes(4), "Out");
            List<Call> expectedEquality = new List<Call>();
            expectedEquality.Add(call1);
            expectedEquality.Add(call2);
            expectedEquality.Add(call3);
            expectedEquality.Add(call4);
            expectedEquality.Sort();
            CallsGenThread.CheckAndSaveCall(call1);
            CallsGenThread.CheckAndSaveCall(call2);
            CallsGenThread.CheckAndSaveCall(call3);
            CallsGenThread.CheckAndSaveCall(call4);
            List<Call> resultEquality = new List<Call>();
            resultEquality = MobileStorage.CallGroups;
            CollectionAssert.AreEqual(expectedEquality, resultEquality);
        }
        [TestMethod]
        public void TestEqualityFull() {
            MobileStorage.CallGroups.Clear();
            MobileStorage.CallsHistory.Clear();
            Contact contact1 = new Contact("User1", "0948562541");
            Contact contact2 = new Contact("User2", "0948562549");
            Contact contact3 = new Contact("User4", "5555555555");
            Contact contact4 = new Contact("User4", "5555555555");
            Call call1 = new Call(contact1, DateTime.Now.AddMinutes(1), "Out");
            Call call2 = new Call(contact2, DateTime.Now.AddMinutes(2), "Out");
            Call call3 = new Call(contact3, DateTime.Now.AddMinutes(3), "Out");
            Call call4 = new Call(contact4, DateTime.Now.AddMinutes(4), "Out");
            List<Call> expectedEquality = new List<Call>();
            expectedEquality.Add(call1);
            expectedEquality.Add(call2);
            expectedEquality.Add(call3);
            expectedEquality.Sort();
            CallsGenThread.CheckAndSaveCall(call1);
            CallsGenThread.CheckAndSaveCall(call2);
            CallsGenThread.CheckAndSaveCall(call3);
            CallsGenThread.CheckAndSaveCall(call4);
            List<Call> resultEquality = new List<Call>();
            resultEquality = MobileStorage.CallGroups;
            CollectionAssert.AreEqual(expectedEquality, resultEquality);
        }
    }
}
