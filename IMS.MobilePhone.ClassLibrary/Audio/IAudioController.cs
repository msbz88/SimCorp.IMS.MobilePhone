using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;

namespace Simcorp.IMS.MobilePhone.ClassLibrary.Audio {
    public interface IAudioController {
        AudioController AudioController { get; set; }
        void Play();
    }
}
