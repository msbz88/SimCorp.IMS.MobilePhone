using System.Threading;
using Simcorp.IMS.MobilePhone.ClassLibrary.Storage;
using System.Collections.Generic;
using System;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Contact {
    public class CallsGenThread  {
        public delegate void newCall(List<Call> calls);
        public event newCall OnNewCallAdded;
        ManualResetEvent newCallEvent = new ManualResetEvent(false);
        Thread CallsThread { get; set; }
        Call Call { get; set; }
        Contact Contact { get; set; }
        RandomCall RandomCall { get; set; }

        public CallsGenThread() {
            RandomCall = new RandomCall();
            CallsThread = new Thread(GenerateCalls);
            CallsThread.Start();
        }

        public void StartGeneration() {
            newCallEvent.Set();
        }

        public void StopGeneration() {
            newCallEvent.Reset();
        }

        private void GenerateCalls() {
            while (true) {
                newCallEvent.WaitOne();
                Contact = new Contact(RandomCall.RandomName(), RandomCall.RandomNumber());
                Call = new Call(Contact, DateTime.Now, RandomCall.RandomDirection());
                MobileStorage.AddCall(Call);
                OnNewCallAdded?.Invoke(MobileStorage.Calls);
                Thread.Sleep(3000);
            }
        }
    }
}