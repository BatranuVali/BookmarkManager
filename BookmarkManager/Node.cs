using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    internal class Node
    {
        internal Node parent { get; set; }
        internal string name { get; set; }
        internal string url { get; set; }
        internal List<Node> children { get; set; }
    }
}
