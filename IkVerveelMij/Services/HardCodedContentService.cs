using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using IkVerveelMij.Model;

namespace IkVerveelMij.Services
{
    public class HardCodedContentService : IContentService
    {

        private static List<MarkupString> contents = new List<MarkupString>()
        {
            new MarkupString("Ik heb tijd vrij..."),
            new MarkupString("Wat zou ik doen?"),
            new MarkupString("Laat ik een: <br /><ul><li>Nieuw boek</li><li>Nieuwe trui</li><li>Uitstapje</li><li>...</li></ul>leveren!<br/> <strong>Super</strong>! <br/> En als we terwijl aan <strong>DDSoft vzw</strong> denken..."),
            new MarkupString("Dan bestellen we bij <strong>TROOPER!</strong> <br/> WANT..."),
            new MarkupString("Het kost <strong>voor mij NIETS</strong> extra! <br /> Maar..."),
            new MarkupString("De web bedrijven betalen een percent! <strong>WAUW, hoor je dit?</strong>")

        };

        public IEnumerable<MarkupString> GetAllContents() => contents;

        public int Count() => contents.Count();

        public MarkupString GetContent(int count) => contents[count];
     
    }
}
