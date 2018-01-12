using Simcorp.IMS.MobilePhone.ClassLibrary.Output;

namespace Simcorp.IMS.MobilePhone.PlaybackForm.Output {

    public class FormOutput : IOutput  {
        FormPlayComponents FormPlayComponents { get; }

        public FormOutput(FormPlayComponents formPlayComponents) {
            FormPlayComponents = formPlayComponents;
        }

        public void Write(string text) {
            FormPlayComponents.textBox1.Text = text;
        }

        public void WriteLine(string text) {
            FormPlayComponents.textBox1.Text = text;
        }

    }
}