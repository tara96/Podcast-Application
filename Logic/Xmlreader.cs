using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;

namespace Logic
{
    public class Xmlreader

    {
        public static void sparaKatNamn(Category kategori) 
        {
            string XmlKategorier = @"C:\Users\Sandra\Desktop\senasteON\senasteO\CSharpProjectEmpty\Data\Kategorier.xml";

            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(XmlKategorier);
            XmlElement kategorier = xmlFile.CreateElement("Category");
            XmlElement kategoriNamn = xmlFile.CreateElement("Namn");
            kategoriNamn.InnerText = kategori.title;
            kategorier.AppendChild(kategoriNamn);
            xmlFile.DocumentElement.AppendChild(kategorier);
            xmlFile.Save(XmlKategorier);
        }

        public static void laddaKategoriXml(ComboBox cbNamn)
        {
            List<string> namnLista = new List<string>();
            string XmlKategorier = @"C:\Users\Sandra\Desktop\senasteON\senasteO\CSharpProjectEmpty\Data\Kategorier.xml";
            //XmlDocument xmlFile = new XmlDocument();
            //xmlFile.Load(XmlKategorier);

            string path = XmlKategorier;
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            string katName = "";
            XmlReader xmlIn = XmlReader.Create(path, settings);
            if (xmlIn.ReadToDescendant("Category"))

            {

                do
                {
                    xmlIn.ReadStartElement("Category");
                    katName = xmlIn.ReadElementContentAsString();
                    cbNamn.Items.Add(katName);

                }
                while (xmlIn.ReadToNextSibling("Category"));
                xmlIn.Close();

            }
        }

        public static void RemoveXmlFile(string kategori)
        {
            string XmlKategorier = @"C:\Users\Sandra\Desktop\senasteON\senasteO\CSharpProjectEmpty\Data\Kategorier.xml";
            string path = XmlKategorier;
            XDocument xDocument = XDocument.Load(path);

            var kategoriTaBort = xDocument.Descendants("Category").FirstOrDefault(x => x.Element("Namn").Value == kategori);
            kategoriTaBort.Remove();
            xDocument.Save(XmlKategorier);

        }

        public static void RemovePodcast(string Valdpodcast)
        {
            string podcast = "Podcast3.xml";
            string path = podcast;
            XDocument xDocument = XDocument.Load(path);

            var TabortP = xDocument.Descendants("Podcast").FirstOrDefault(x => x.Element("title").Value == Valdpodcast);
            TabortP.Remove();
            xDocument.Save(podcast);

        }

        public static void uppdateraKategoriLista(ComboBox namn)
        {
            tomComboBox(namn);
            laddaKategoriXml(namn);
        }

        public static void tomComboBox(ComboBox namn)
        {
            namn.Items.Clear();
        }

        public static List<string> hamtaPodcastTitlar(string valdkategori)
        {
            Serializer seri = new Serializer();
            List<Podcast> podList = seri.deserializepodcast();
            return podList.Where(x => x.kategori == valdkategori).Select(y => y.title).ToList();
        }

        public static List<string> hamtaEpisodeTitlar(string valdPodcast)
        {
            Serializer seri = new Serializer();
            List<Podcast> epList = seri.deserializepodcast();

            var epilist = epList.Where(x => x.title == valdPodcast).Select(y => y.episodeList).SingleOrDefault();
            return epilist.Select(c => c.title).ToList();
        }

        public static void taBortPodcasterMedValdkat(string valdKat)
        {
            string XmlPodcaster = "Podcast3.xml";
            string path = XmlPodcaster;
            XDocument xDocument = XDocument.Load(path);

            var taBortPodcast = xDocument.Descendants("Podcast").FirstOrDefault(x => x.Element("kategori").Value == valdKat);
            taBortPodcast.Remove();
            xDocument.Save(XmlPodcaster);

        }

        public static string hamtaEpisodInfo(string valdEpisod, string valdPodcast)
        {
            Serializer seri = new Serializer();
            List<Podcast> epList = seri.deserializepodcast();

            var epilist = epList
                .Where(x => x.title == valdPodcast)
                .First()
                .episodeList.Where(x => x.title == valdEpisod)
                .First().description;
            return epilist;
        }

        public static string hamtaUrlFranValdPodcast(string valdEpisod, string valdPodcast)
        {
            Serializer seri = new Serializer();
            List<Podcast> epList = seri.deserializepodcast();

            var epilist = epList
                .Where(x => x.title == valdPodcast)
                .First()
                .episodeList.Where(x => x.title == valdEpisod)
                .First().link;
            return epilist;
        }

        public static async void LaddaPodcastTillXML(string url, string kategori, int updateInterval)
        {
            List<Podcast> pLista = new List<Podcast>();
            Serializer seri = new Serializer();

            var task = new Task<Podcast>(()=> {

                Podcast podcast = new Podcast(updateInterval, url);
                List<Episode> epLista = new List<Episode>();
                

                if (System.IO.File.Exists("Podcast3.xml"))
                    pLista = seri.deserializepodcast();
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                foreach (SyndicationItem item in feed.Items)
                {
                    var episode = new Episode()
                    {
                        title = item.Title.Text,
                        description = item.Summary.Text,
                        pubDate = item.PublishDate.ToString(),
                        link = item.Links[1].Uri.ToString(),
                        spelad = false,

                    };
                    epLista.Add(episode);
                }

                podcast.title = feed.Title.Text;
                podcast.url = url;
                podcast.kategori = kategori;
                podcast.episodeList = epLista;
                podcast.interval = 10;

                return podcast;
            });

            task.Start();
            var p = await task;
            pLista.Add(p);

            seri.serialize(pLista);
        }

        public static void editCategory(string nyKategori, string gammalKategori)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Sandra\Desktop\senasteON\senasteO\CSharpProjectEmpty\Data\Kategorier.xml");

            XmlNodeList aNodes = doc.SelectNodes("/kategorier/Category/Namn");
            foreach (XmlNode aNode in aNodes)
            {
                string namnAttribut = aNode.FirstChild.InnerText.ToString();

                if (namnAttribut.Equals(gammalKategori))
                {
                    namnAttribut = nyKategori;
                    aNode.FirstChild.Value = namnAttribut;
                }
            }
            doc.Save(@"C:\Users\Sandra\Desktop\senasteON\senasteO\CSharpProjectEmpty\Data\Kategorier.xml");
            //RemoveXmlFile(gammalKategori);
        }

        public static void ändraOmEpisodeÄrSpelad(string episode, string podcast)
        {
            Serializer seri = new Serializer();
            List<Podcast> epList = seri.deserializepodcast();

            var epilist = epList
                .Where(x => x.title == podcast)
                .First()
                .episodeList.Where(x => x.title == episode)
                .First().spelad = true;

            seri.serialize(epList);
        }

        public static void visaSpelad(string episode, string podcast)
        {
            Serializer seri = new Serializer();
            List<Podcast> epList = seri.deserializepodcast();

            var epilist = epList
                .Where(x => x.title == podcast)
                .First()
                .episodeList.Where(x => x.title == episode)
                .First().spelad;
            if(epilist) 
                MessageBox.Show("Detta avsnitt har tidigare spelats");
        }
    }
}
