using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IkVerveelMij.Model
{
    public static class Talks
    {
        private static List<Talk> _Talks = new List<Talk>()
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
                        Location = "Virtual"
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
                        Location = "Vilnius Lithuania"
                    },

            }
        };

        public static List<Talk> GetAllTalks => _Talks;

        public static int Count = _Talks.Count;

        public static Talk GetTalk(int count)
        {
            return _Talks[count];
        }

    }
}
