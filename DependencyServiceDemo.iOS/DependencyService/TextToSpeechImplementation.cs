using System;
using AVFoundation;
using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.iOS.DependencyService;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]

namespace DependencyServiceDemo.iOS.DependencyService
{
    public class TextToSpeechImplementation : ITextToSpeech 
    {
        public TextToSpeechImplementation()
        {
        }

        public void speak(string Text)
        {
            var speechSyntinetizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(Text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("es-MX"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };
            speechSyntinetizer.SpeakUtterance(speechUtterance);
        }
    }
}
