using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using IkVerveelMij.Model;

namespace IkVerveelMij.Services
{
    public interface IContentService
    {
       IEnumerable<MarkupString> GetAllContents();

        int Count();

        MarkupString GetContent(int count);
    }
}
