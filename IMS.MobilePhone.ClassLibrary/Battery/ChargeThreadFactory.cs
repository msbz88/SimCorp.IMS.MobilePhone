namespace Simcorp.IMS.MobilePhone.ClassLibrary.Battery {
    public class ChargeThreadFactory : ChargeBaseFactory {
        BatteryBase Battery { get; set; }

        public ChargeThreadFactory(BatteryBase battery) {
            Battery = battery;
        }

        public override ChargeBase FactoryMethod() {
            return new BatteryChargerThread(Battery);
        }
    }
}
