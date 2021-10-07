using System;
using System.Collections.Generic;
using IkVerveelMij.Model;


namespace IkVerveelMij.Services
{
    public class HardCodedTalksService : ITalksService
    {
        private static List<Talk> talks = new List<Talk>()
        {
            new Talk{
                     Date = new DateTime(2021,10,29),
                     Title = "AI for the Better",
                     Event = new Event
                    {
                        DateFrom = new DateTime(2021,10,29),
                        DateTo = new DateTime(2021,10,30),
                        isSpeaking = true,
                        Name = "Azure Community Conference",
                        Location = "Virtual",
                        Website = "https://azconf.dev"
                     }
            },
            new Talk{
                    Date = new DateTime(2021,11,18),
                    Title = "Intro to Blazing Web Accessibility (*)",
                    Event = new Event
                    {
                        DateFrom = new DateTime(2021,11,17),
                        DateTo = new DateTime(2021,11,19),
                        isSpeaking = true,
                        Name = "Build Stuff",
                        Location = "Vilnius Lithuania",
                        Website = "https://www.buildstuff.events/travel-tips"

                    },

            }
        };


        public int Count() => talks.Count;

        public IEnumerable<Talk> GetAllTalks() => talks;

        public Talk GetTalk(int count) => talks[count];
    }
}
