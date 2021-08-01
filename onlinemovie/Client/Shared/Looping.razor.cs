using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlinemovie.Client.Shared
{
    public partial class Looping
    {
        [Parameter] public List<Data> D1 { get; set; }
        public bool check { get; set; }
        public void Delete(Data d3)
        {
            D1.Remove(d3);
        }
    }
}
