using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace Logic
{
    public class Episode : Entity
    {
        public string title { get; set; }
        public string pubDate { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public bool spelad { get; set; }

    }
}
