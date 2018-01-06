namespace Simcorp.IMS.MobilePhone.Battery {
    public interface IBattery {
        int Charge { get; set; }
        int Volume { get; set; }
        void GetStatus(int volume, int charge);
    }
}
