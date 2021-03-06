﻿using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class MessageGenThread : MessageGenBase {
        ManualResetEvent newMessageEvent = new ManualResetEvent(false);
        Thread MessageGen { get; set; }
        TextMessage Message { get; set; }
        RandomSMS RandomSMS { get; set; }
        SMSProvider SMSProvider { get; set;}

        public MessageGenThread(IReceiver receiver) {
            RandomSMS = new RandomSMS();
            SMSProvider = new SMSProvider(receiver);
            MessageGen = new Thread(GenerateMessages);
            MessageGen.Start();
        }

        public override void StartGeneration() {
            newMessageEvent.Set();
        }

        public override void StopGeneration() {
            newMessageEvent.Reset();
        }

        private void GenerateMessages() {
            while (true) {
                newMessageEvent.WaitOne();
                lock (this) {
                    Message = new TextMessage(RandomSMS.RandomName(), RandomSMS.RandomMessage());
                    SMSProvider.SendMessage(Message);
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
