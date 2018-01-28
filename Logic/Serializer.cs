using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Logic
{
    public class Serializer
    {
        public void serialize(List<Podcast> pod)
        {
            var serializer = new XmlSerializer(pod.GetType());
            using (var writer = XmlWriter.Create("Podcast3.xml"))
            {
                serializer.Serialize(writer, pod);
            }
        }

        public List<Podcast> deserializepodcast()
        {
            var serializer = new XmlSerializer(typeof(List<Podcast>));
            using (var reader = XmlReader.Create("Podcast3.xml")) 
            {
                var Plist = (List<Podcast>)serializer.Deserialize(reader);
                return Plist;
            }
        }
    }
}
