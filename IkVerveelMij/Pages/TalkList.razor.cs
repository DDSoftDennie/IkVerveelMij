using IkVerveelMij.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IkVerveelMij.Pages
{
    public partial class TalkList
    {
        public List<Talk> TalksToShow { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            TalksToShow = Talks.GetAllTalks;
        }
    }
}
