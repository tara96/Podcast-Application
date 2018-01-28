using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Logic
{
    public class Podcast : Entity
    {
        public string title { get; set; }
        
        public Episode enEpisod { get; set; }
        public string kategori { get; set; }
        public string url { get; set; }
        public int interval { get; set; }
        private Timer updateTimer;
        public List<Episode> episodeList { get; set; }

        public Podcast(int interval, string url)
        {
            this.url = url;
            updateTimer = new Timer(interval);
            updateTimer.Elapsed += update;
            updateTimer.Start();
        }
        public Podcast()
        {

        }

        private void update(Object sender, EventArgs e)
        {
            Console.WriteLine("test");
            xmlHandler handler = new xmlHandler();
           var feed = handler.updateEpisodes(url);
            var epLista = new List<Episode>();

            foreach (SyndicationItem item in feed.Items)
            {
                var episode = new Episode()
                {
                    title = item.Title.Text,
                    description = item.Summary.Text,
                    pubDate = item.PublishDate.ToString(),
                    link = item.Links[1].Uri.ToString(),

                };
                epLista.Add(episode);
            }
            this.episodeList = epLista;
        }
    }


    }

