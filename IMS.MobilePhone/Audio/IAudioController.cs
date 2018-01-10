using Simcorp.IMS.MobilePhone.Audio;

namespace Simcorp.IMS.MobilePhone.Audio {
    public interface IAudioController {
        AudioController AudioController { get; set; }
        void Play();
    }
}
