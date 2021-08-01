using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlinemovie.Client.Shared
{
    public partial class MovieList
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = ser.GetData();
        }
    }
}
