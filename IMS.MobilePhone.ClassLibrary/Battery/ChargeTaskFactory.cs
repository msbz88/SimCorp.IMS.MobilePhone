namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class ChargeTaskFactory : ChargeBaseFactory {
        BatteryBase Battery { get; set; }

        public ChargeTaskFactory(BatteryBase battery) {
            Battery = battery;
        }

        public override ChargeBase FactoryMethod() {
            return new BatteryChargerTask(Battery);
        }
    }
}
