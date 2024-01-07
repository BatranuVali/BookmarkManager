using System.Collections.Generic;

namespace BookmarkManager
{
    public class Folder:Base
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
    }
}
