using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlinemovie.Client.Shared
{
    public class Data
    {
        public string Title { get; set; }
        public string Poster { get; set; }
        public DateTime StartingDate { get; set; }

        public string Titlebrief
        {
            get
            {
                if(string.IsNullOrEmpty(Title))
                {
                    return null;
                }
                if(Title.Length>60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }

      
    }
}
