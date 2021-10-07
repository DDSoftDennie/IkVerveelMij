using System;
using System.Collections.Generic;
using IkVerveelMij.Model;

namespace IkVerveelMij.Services
{
    public interface ITalksService
    {
        IEnumerable<Talk> GetAllTalks();

        int Count();

        Talk GetTalk(int count);
    }
}
