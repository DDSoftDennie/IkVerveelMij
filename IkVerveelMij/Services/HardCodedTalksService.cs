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
            },
            new Talk
            {
                Date = new DateTime(2022,1,15),
                Title = "Speech Everything and (let them) Rise!",
                Event = new Event
                {
                    DateFrom = new DateTime(2022,1,15),
                    DateTo = new DateTime(2022,1,15),
                    isSpeaking = true,
                    Name = "Global AI Bootcamp Pune",
                    Location = "Online",
                    Website = "https://globalai.community/bootcamp-2022/asia-india-pune-4407/"
                }
            },
            new Talk
            {
                Date = new DateTime(2022,1,17),
                Title = "Autism in Tech",
                Event = new Event
                {
                    DateFrom = new DateTime(2022,1,17),
                    DateTo = new DateTime(2022,1,17),
                    isSpeaking = true,
                    Name = "Microsoft Reactor | Putting Accessibility into Practice Series",
                    Location = "Online",
                    Website = "https://www.meetup.com/Microsoft-Reactor-London/events/282821823/?utm_medium=email&utm_source=braze_canvas&utm_campaign=mmrk_alleng_event_announcement_prod_v5_en&utm_term=promo&utm_content=lp_meetup"
                }
            },
            new Talk
            {
                Date = new DateTime(2022,3,16),
                Title = "Exploring Patterns to Debug your Life (co speaker: Miriam Perrone)",
                Event = new Event
                {
                    DateFrom = new DateTime(2022,3,15),
                    DateTo = new DateTime(2022,3,17),
                    isSpeaking = true,
                    Name = "Javaland 2022",
                    Location = "Phantasialand Bruhl Germany",
                    Website = "https://www.javaland.eu"
                }
            },
            new Talk
            {
                Date = new DateTime(2022,6,1),
                Title = "Blazing Acccesibility Basics",
                Event = new Event
                {
                    DateFrom = new DateTime(2022,6,1),
                    DateTo = new DateTime(2022,6,1),
                    isSpeaking = true,
                    Name = "Scottish Summit",
                    Location = "Glasgow, Scotland",
                    Website = "https://scottishsummit.com"
                }
            }

        };


        public int Count() => talks.Count;

        public IEnumerable<Talk> GetAllTalks() => talks;

        public Talk GetTalk(int count) => talks[count];
    }
}
