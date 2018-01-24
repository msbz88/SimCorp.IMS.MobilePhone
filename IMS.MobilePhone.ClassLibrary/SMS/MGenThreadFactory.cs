namespace Simcorp.IMS.MobilePhone.ClassLibrary.SMS {
    public class MGenThreadFactory : MGenBaseFactory {
        IReceiver Receeiver { get; set; }

        public MGenThreadFactory(IReceiver receeiver) {
            Receeiver = receeiver;
        }

        public override MessageGenBase FactoryMethod() {
            return new MessageGenThread(Receeiver);
        }
    }
}
