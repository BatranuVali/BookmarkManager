using System.Collections.Generic;

namespace BookmarkManager
{
    public class Folder
    {
        public Folder() 
        {
            this.children= new List<dynamic> ();
            this.guid = null; 
            this.name=null;
            this.date_added = null;
            this.date_last_used = null;
            this.id = null;
            this.type = "folder";

        }
        public List<dynamic> children { get; set; }
        public string date_added { get; set; }
        public string date_last_used { get; set; }
        public string guid { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

    }
}
