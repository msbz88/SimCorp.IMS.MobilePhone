using Simcorp.IMS.MobilePhone.ClassLibrary.Output;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Test.Output {
    public class TestOutput : IOutput {
        UnitTestOutput UnitTestOutput { get; }

        public TestOutput(UnitTestOutput unitTestOutput) {
            this.UnitTestOutput = unitTestOutput;
        }
        public void Write(string text) {
            UnitTestOutput.Result = text;
        }

        public void WriteLine(string text) {
            UnitTestOutput.Result = text;
        }
    }
}
