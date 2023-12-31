using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    internal class BookmarkData
    {
        public string checksum {  get; set; }
        public Dictionary<string, Bookmark> roots { get; set; }

        public string version { get; set; }
    }
}