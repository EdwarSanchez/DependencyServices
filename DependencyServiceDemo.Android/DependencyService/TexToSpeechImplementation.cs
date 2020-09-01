using System;
using Android.Runtime;
using Android.Speech.Tts;
using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.Droid.DependencyService;
using Xamarin.Forms;
using static Android.Speech.Tts.TextToSpeech;

[assembly: Dependency(typeof(TexToSpeechImplementation))]
namespace DependencyServiceDemo.Droid.DependencyService
{
    public class TexToSpeechImplementation : Java.Lang.Object, ITextToSpeech, IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            speaker.Speak(toSpeak, QueueMode.Flush, null, null);

        }

        public void speak(string Text)
        {
            toSpeak = Text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}
