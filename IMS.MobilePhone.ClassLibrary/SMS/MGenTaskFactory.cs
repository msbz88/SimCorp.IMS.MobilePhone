namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class MGenTaskFactory : MGenBaseFactory {
        IReceiver Receeiver { get; set; }

        public MGenTaskFactory(IReceiver receeiver) {
            Receeiver = receeiver;
        }

        public override MessageGenBase FactoryMethod() {
            return new MessageGenTask(Receeiver);
        }
    }
}
