using IkVerveelMij.Services;
using Microsoft.AspNetCore.Components;

namespace IkVerveelMij.Pages
{
    public partial class Index
    {
        private int _count;
        public MarkupString ContentToShow { get; set; }
        [Inject]
        public IContentService contentService { get; set; }
        public void Next()
        {
            _count =  _count < contentService.Count() - 1 ? _count +=1 : 0;
            ContentToShow = contentService.GetContent(_count);
         
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            _count = 0;
            ContentToShow = contentService.GetContent(_count);
        }
    }
}
