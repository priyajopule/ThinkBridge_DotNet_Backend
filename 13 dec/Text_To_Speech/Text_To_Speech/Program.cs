using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Text_To_Speech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of spech synthesize 
            //creating reference and add system.speeh
            //callong output todefault audio device
            //calling seak() functionality
            SpeechSynthesizer speakSyn = new SpeechSynthesizer();
            speakSyn.SetOutputToDefaultAudioDevice();
            speakSyn.Speak("Today is a great day....");
        }
    }
}
