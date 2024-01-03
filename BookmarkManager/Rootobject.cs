using System.Collections.Generic;

namespace BookmarkManager
{
    public class Rootobject
    {
        public string checksum { get; set; }

        public Dictionary<string, dynamic> roots = new Dictionary<string, dynamic>();
        public string version { get; set; }
    }
}
