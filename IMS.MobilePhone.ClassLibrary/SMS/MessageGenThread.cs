using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class MessageGenThread : MessageGenBase {
        TextMessage Message { get; set; }
        RandomSMS RandomSMS { get; set; }
        SMSProvider SMSProvider { get; set;}
        private static bool IsRunning { get; set; }

        public MessageGenThread(IReceiver receiver) {
            RandomSMS = new RandomSMS();
            SMSProvider = new SMSProvider(receiver);
            IsRunning = false;
        }

        public override void StartThread() {
                IsRunning = true;
                MessageGen = new Thread(GenerateMessages);
                MessageGen.Start();   
        }

        public override void StopThread() {
            IsRunning = false;
        }

        private void GenerateMessages() {
            while (IsRunning) {
                lock (this) {
                    Message = new TextMessage(RandomSMS.RandomName(), RandomSMS.RandomMessage());
                    SMSProvider.SendMessage(Message);
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
