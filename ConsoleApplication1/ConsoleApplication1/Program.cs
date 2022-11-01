using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
       // private static ;
        static void Main(string[] args)
        {
            
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            sre.SetInputToDefaultAudioDevice();
            sre.LoadGrammar(new DictationGrammar());
            sre.RecognizeAsync(RecognizeMode.Multiple);
            sre.SpeechRecognized += rec;
            
            /*
            foreach (RecognizerInfo ri in SpeechRecognitionEngine.InstalledRecognizers())
            {
                System.Diagnostics.Debug.WriteLine(ri.Culture.Name);
            }*/
            Console.ReadKey();
        }
        private static void rec(object sender,SpeechRecognizedEventArgs result) {
            Console.WriteLine(result.Result.Text);

        }
    }
}
