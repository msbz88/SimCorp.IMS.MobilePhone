using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public abstract class MessageGenBase {
        protected Thread MessageGen;

        public abstract void StartThread();

        public abstract void StopThread();
    }
}
