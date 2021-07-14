using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IkVerveelMij.Model;
using Microsoft.AspNetCore.Components;

namespace IkVerveelMij.Pages
{
    public partial class Index
    {
        private int _count;
        public MarkupString ContentToShow { get; set; }

        public void  Next()
        {
            _count = _count < Content.Count-1 ? _count += 1 : 0;
            ContentToShow = Content.GetContent(_count);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            _count = 0;
            ContentToShow = Content.GetContent(_count);
        }
    }
}
