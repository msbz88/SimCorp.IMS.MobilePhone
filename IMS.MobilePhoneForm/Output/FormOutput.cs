using Simcorp.IMS.MobilePhone.ClassLibrary.Output;

namespace IMS.MobilePhoneForm.Output {

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