using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Contacts {
    public class CallsGenThread  {
        public delegate void CallEvent(List<Call> calls);
        public event CallEvent OnNewCallAdded;
        ManualResetEvent GenEvent = new ManualResetEvent(false);
        Thread CallsThread { get; set; }
        Call NewCall { get; set; }
        Contact NewContact { get; set; }
        RandomCall RandomCall { get; set; }

        public CallsGenThread() {
            RandomCall = new RandomCall();
            CallsThread = new Thread(GenerateCalls);
            CallsThread.Start();
        }

        public void StartGeneration() {
            GenEvent.Set();
        }

        public void StopGeneration() {
            GenEvent.Reset();
        }

        public void CheckAndSaveCall(Call newCall) {   
            foreach (Call savedCall in MobileStorage.CallsHistory) {
                if (savedCall.Equals(newCall)) {
                    newCall.CountTimesCalled += savedCall.CountTimesCalled;
                    MobileStorage.RemoveCallFromGroup(savedCall);
                }
            }
            MobileStorage.AddCallToGroup(newCall);
            MobileStorage.AddCallToHistory(newCall);
            OnNewCallAdded?.Invoke(MobileStorage.CallGroups);
        }

        private void GenerateCalls() {
            while (true) {
                GenEvent.WaitOne();
                NewContact = new Contact(RandomCall.RandomName(), RandomCall.RandomNumber());
                NewCall = new Call(NewContact, DateTime.Now, RandomCall.RandomDirection());
                CheckAndSaveCall(NewCall);
                Thread.Sleep(3000);
            }
        }
    }
}