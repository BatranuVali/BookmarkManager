using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    internal class Bookmark
    {
        public long date_added { get; set; }
        public long date_last_used { get; set; }
        public string guid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public List<Bookmark> children { get; set; }

    }
}
