using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.IMS.MobilePhone
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        private void Show(IScreenImage screenImage, int brightness)
        {
            Screen.Show(screenImage, brightness);
        }

        public string Description()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            return descriptionBuilder.ToString();
        }

    }


}
