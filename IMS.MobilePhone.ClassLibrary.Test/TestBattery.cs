using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.MobilePhone.ClassLibrary.Battery;
using System.Threading;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Test {
    [TestClass]
    public class TestBattery {
        ChargeBase BatteryCharger { get; set; }
        LithiumLonBattery LithiumLonBattery = new LithiumLonBattery(100);

        [TestMethod]
        public void TestBatteryThreadChargeLess0() {
            int expectations = 0;
            LithiumLonBattery.Charge = 100;
            BatteryDischargerThread BatteryDischargerThread = new BatteryDischargerThread(LithiumLonBattery);
            BatteryDischargerThread.StartDisCharging();
            Thread.Sleep(6000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryTaskChargeLess0() {
            int expectations = 0;
            LithiumLonBattery.Charge = 100;
            BatteryDischargerTask BatteryDischargerTask = new BatteryDischargerTask(LithiumLonBattery);
            BatteryDischargerTask.StartDisCharging();
            Thread.Sleep(6000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryThreadChargeMore100() {
            int expectations = 100;
            BatteryChargerThread BatteryChargerThread = new BatteryChargerThread(LithiumLonBattery);
            BatteryChargerThread.StartCharge();
            Thread.Sleep(3000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryTaskChargeMore100() {
            int expectations = 100;
            BatteryChargerTask BatteryChargerTask = new BatteryChargerTask(LithiumLonBattery);
            BatteryChargerTask.StartCharge();
            Thread.Sleep(3000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryThreadCharge() {
            int expectations = 100;
            LithiumLonBattery.Charge = 0;
            BatteryChargerThread BatteryChargerThread = new BatteryChargerThread(LithiumLonBattery);
            BatteryChargerThread.StartCharge();
            Thread.Sleep(2000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryThreadDisCharge() {
            int expectations = 0;
            LithiumLonBattery.Charge = 100;
            BatteryChargerThread BatteryChargerThread = new BatteryChargerThread(LithiumLonBattery);
            BatteryChargerThread.StopCharge();
            Thread.Sleep(6000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryTaskCharge() {
            int expectations = 100;
            LithiumLonBattery.Charge = 0;
            BatteryChargerTask BatteryChargerTask = new BatteryChargerTask(LithiumLonBattery);
            BatteryChargerTask.StartCharge();
            Thread.Sleep(2000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }

        [TestMethod]
        public void TestBatteryTaskDisCharge() {
            int expectations = 0;
            LithiumLonBattery.Charge = 100;
            BatteryChargerTask BatteryChargerTask = new BatteryChargerTask(LithiumLonBattery);
            BatteryChargerTask.StopCharge();
            Thread.Sleep(6000);
            int result = LithiumLonBattery.Charge;
            Assert.AreEqual(expectations, result);
        }
    }
}
