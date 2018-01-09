using System;
using System.Collections.Generic;
using Simcorp.IMS.MobilePhone.API;

namespace Simcorp.IMS.MobilePhone {
    class Program {
        static int CheckUserInput(string userInput, List<string> playBackComponents) {
            int result = 0;
            try {
                result = int.Parse(userInput);
            }
            catch (FormatException) {
                Console.WriteLine("Please type just number of playback component!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            if (result > 0 && result <= playBackComponents.Count) {
                return result;
            }
            else {
                Console.WriteLine($"Please just specify number between 1 and {playBackComponents.Count}!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
        }

        static void Main(string[] args) {
            SimCorpMobile simMobile = new SimCorpMobile();
            /*
            Console.WriteLine(simMobile.Screen.ToString());
            Console.WriteLine(simMobile.Battery.ToString());
            Console.WriteLine(simMobile.Speaker.ToString());
            */
            List<string> playBackComponents = new List<string>();
            playBackComponents.Add("1. phone speaker.");
            playBackComponents.Add("2. Samsung Headset.");
            playBackComponents.Add("3. iPhone Headset.");

            int userPlaybackChoice = 0;

            while (userPlaybackChoice == 0) {
                Console.WriteLine("Please select playback component(specify index)\n");
                foreach (string item in playBackComponents){
                    Console.WriteLine(item);
                }
                Console.Write("\nYour choice: ");
                userPlaybackChoice = CheckUserInput(Console.ReadLine(), playBackComponents);
            }

            switch (userPlaybackChoice) {
                case 1:
                    simMobile.PlaybackComponent.Play(null);
                    break;
                case 2:
                    simMobile.PlaybackComponent.Play(null);
                    break;
                case 3:
                    simMobile.PlaybackComponent.Play(null);
                    break;
            }
            Console.ReadKey();
        }
    }
}
