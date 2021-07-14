using Microsoft.AspNetCore.Components;
using System.Collections.Generic;


namespace IkVerveelMij.Model
{
    public static class Content
    {
        private static readonly List<MarkupString> _content = new List<MarkupString>
        {
            new MarkupString("Ik heb tijd vrij..."),
            new MarkupString("Wat zou ik doen?"),
            new MarkupString("Laat ik een: <br /><ul><li>Niew boek</li><li>Nieuwe trui</li><li>Uitstapje</li><li>...</li></ul>leveren!<br/> <strong>Super</strong>! <br/> En als we terwijl aan <strong>DDSoft vzw</strong> denken..."),
            new MarkupString("Dan bestellen we bij <strong>TROOPER!</strong> <br/> WANT..."),
            new MarkupString("Het kost <strong>voor mij NIETS</strong> extra! <br /> Maar..."),
            new MarkupString("De web bedrijven betalen een percent! <strong>WAUW, hoor je dit?</strong>")
        };
        public static  List<MarkupString> AllContent => _content;
        public static  int Count => _content.Count;

        public static MarkupString GetContent(int count)
        {
            return _content[count];
        }
    }
}
