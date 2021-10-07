using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IkVerveelMij.Model
{
    public class Event
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public string Website { get; set;  }

        public DateTime DateFrom {  get; set; }

        public DateTime DateTo { get; set; }

        public bool isSpeaking { get; set; }



    }
}
