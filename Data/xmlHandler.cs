
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class xmlHandler
    {

        public SyndicationFeed updateEpisodes(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
           
            reader.Close();
            return feed;
        }

    }
}
