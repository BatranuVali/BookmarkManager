using System.Collections.Generic;

namespace BookmarkManager
{
    internal class Folder
    {
        public string date_added { get; set; }
        public string date_last_used { get; set; }
        public string guid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public List<dynamic> children { get; set; }
    }
}
