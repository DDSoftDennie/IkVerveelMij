using System;
using System.Collections.Generic;
using IkVerveelMij.Model;


namespace IkVerveelMij.Services
{
    public class HardCodedTalksService : ITalksService
    {
        private static List<Talk> talks = new List<Talk>()
        {
            new Talk
            {
                Date = new DateTime(2021,10,21),
                Title = "AI for the Bettter",
                Event = new Event
                {
                    DateFrom = new DateTime(2021,10,21),
                    DateTo = new DateTime(2021,10,21),
                    isSpeaking = true,
                    Name = "Global AI Bootcamp Pune, India",
                    Location = "Virtual",
                    Website = "https://globalai.community/global-ai-back-together/asia-global-ai-pune-4406/"
                }
            },
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

            },
            new Talk
            {
                Date = new DateTime(2021,11,19),
                Title = "Blazing Accessibility Basics",
                Event = new Event
                {
                    DateFrom = new DateTime(2021,11,18),
                    DateTo = new DateTime(2021,11,19),
                    isSpeaking = true,
                    Name = "Update Conference Prague",
                    Location = "Prague, Chech Republic",
                    Website = "https://www.updateconference.net"
                }
            },
            new Talk
            {
                Date = new DateTime(2021,12,9),
                Title = "Autism in Tech",
                Event = new Event
                {
                    DateFrom = new DateTime(2021,12,8),
                    DateTo = new DateTime(2021,12,9),
                    isSpeaking = true,
                    Name = "JavaZone",
                    Location = "Moved Online...",
                    Website = "https://www.javazone.no"
                }
            },
            new Talk
            {
                Date = new DateTime(2021,12,15),
                Title = "The Scary Truth about Labels",
                Event = new Event
                {
                    DateFrom = new DateTime(2021,12,15),
                    DateTo = new DateTime(2021,12,15),
                    isSpeaking = true,
                    Name = "Tech A11y Summit",
                    Location = "Online",
                    Website = "https://techa11y.dev"
                }
            }
        };


        public int Count() => talks.Count;

        public IEnumerable<Talk> GetAllTalks() => talks;

        public Talk GetTalk(int count) => talks[count];
    }
}
