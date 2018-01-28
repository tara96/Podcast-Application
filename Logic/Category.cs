using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Category : Entity
    {
        public string title { get; set; }
        private List<Podcast> podCasts;




        public Category(string name)
        {
            title = name;
        }
     

        public List<Podcast> getList()
        {
            return podCasts;
        }

        public void addToCatList(Podcast pod)
        {
            podCasts.Add(pod);
        }
    }
}
