using System.Threading;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class MessageGenTask : MessageGenBase {
        ManualResetEvent newMessageEvent = new ManualResetEvent(false);
        Task MessageTask { get; set; }
        TextMessage Message { get; set; }
        RandomSMS RandomSMS { get; set; }
        SMSProvider SMSProvider { get; set; }

        public MessageGenTask(IReceiver receiver) {
            RandomSMS = new RandomSMS();
            SMSProvider = new SMSProvider(receiver);
            MessageTask = new Task(GenerateMessages);
            MessageTask.Start();
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
