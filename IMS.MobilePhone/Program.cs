using System;
using System.Reflection;
using System.Collections.Generic;
using Simcorp.IMS.MobilePhone.ClassLibrary.API;
using Simcorp.IMS.MobilePhone.ClassLibrary.Screen;
using Simcorp.IMS.MobilePhone.ClassLibrary.Speaker;
using Simcorp.IMS.MobilePhone.ClassLibrary.Battery;
using Simcorp.IMS.MobilePhone.ClassLibrary.Audio;
using Simcorp.IMS.MobilePhone.ClassLibrary.Headset;

namespace Simcorp.IMS.MobilePhone {
    class Program {
        static int CheckUserInput(string userInput, List<string> playBackComponents) {
            int result = 0;
            try {
                result = int.Parse(userInput);
            }catch (FormatException) {
                Console.WriteLine("Please type just integer number of component!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
            if (result > 0 && result <= playBackComponents.Count) {
                return result;
            }else {
                Console.WriteLine($"Please specify number between 1 and {playBackComponents.Count}!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }
        }

        static void Main(string[] args) {
            OLEDScreen screen = new OLEDScreen(5, 1920, 1080);
            LithiumLonBattery battery = new LithiumLonBattery(4000);
            PhoneSpeaker speaker = new PhoneSpeaker(1000);
            SimCorpMobile simMobile = new SimCorpMobile(screen, battery, speaker);
            SamsungHeadset samsungHeadsetComp = new SamsungHeadset(300);
            IPhoneHeadset iPhoneHeadsetComp = new IPhoneHeadset(350);
            IAudioController samsungHeadset = (IAudioController)samsungHeadsetComp;
            IAudioController iPhoneHeadset = (IAudioController)iPhoneHeadsetComp;        
            List<string> playComponentsMenuItems = new List<string>();
            playComponentsMenuItems.Add("Phone speaker.");
            playComponentsMenuItems.Add("Samsung Headset.");
            playComponentsMenuItems.Add("iPhone Headset.");
            int userPlaybackChoice = 0;
            while (true) {
                while (userPlaybackChoice == 0) {
                    Console.WriteLine(simMobile.ToString());
                    Console.WriteLine("Please select component (specify index)\n");
                    foreach (string item in playComponentsMenuItems) {
                        Console.Write(playComponentsMenuItems.IndexOf(item) + 1 + ". ");
                        Console.WriteLine(item);
                    }
                    Console.Write("\nYour choice: ");
                    userPlaybackChoice = CheckUserInput(Console.ReadLine(), playComponentsMenuItems);
                }
                switch (userPlaybackChoice) {
                    case 1:
                        simMobile.Play();
                        break;
                    case 2:
                        simMobile.Play(samsungHeadset);
                        break;
                    case 3:
                        simMobile.Play(iPhoneHeadset);
                        break;
                }
                userPlaybackChoice = 0;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
