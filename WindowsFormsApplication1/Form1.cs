using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApplication1;
using WMPLib;

namespace CSharpProject
{
    public partial class lbEpisodeInfo : Form
    {
        public lbEpisodeInfo()
        {
            InitializeComponent();
  
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logic.Xmlreader.laddaKategoriXml(cbKat);
            Logic.Xmlreader.laddaKategoriXml(cbChooseKat);
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbEpisod.Items.Clear();
            lbEInfo.Clear();
            tbTitle.Clear();
            var selectedCb = this.cbKat.GetItemText(this.cbChooseKat.SelectedItem);
            lbPodcast.Items.Clear();
            
            

           
           var kategorier =  Logic.Xmlreader.hamtaPodcastTitlar(selectedCb);

            foreach(var kategori in kategorier)
            {
                lbPodcast.Items.Add(kategori);
            }
            
        }



        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Logic.Podcast podcast = new Logic.Podcast(); 
            //listBox3.DataSource = podcast.getList();
            //Logic.Xmlreader hej = new Logic.Xmlreader();
            //hej.loadPod();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHantera_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logic.Xmlreader.uppdateraKategoriLista(cbKat);
        }

        private void cbKat_MouseClick(object sender, MouseEventArgs e)
        {
            Logic.Xmlreader.uppdateraKategoriLista(cbKat);

        }
        private void cbChooseKat_MouseClick(object sender, MouseEventArgs e)
        {
            Logic.Xmlreader.uppdateraKategoriLista(cbKat);

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            
  

            var url = txbUrl.Text;
            var cbSelect = cbKat.GetItemText(cbKat.SelectedItem);

            


                if (Rb1h.Checked && Validator.KollaTextfältUrl(url))
                {
                    Xmlreader.LaddaPodcastTillXML(url, cbSelect, 3600000);
                MessageBox.Show("Podcasten är nu tillagd!");
            }
                else if (Rb1Day.Checked && Validator.KollaTextfältUrl(url))
            {
                    Xmlreader.LaddaPodcastTillXML(url, cbSelect, 86400000);
                MessageBox.Show("Podcasten är nu tillagd!");
            }
                else if (Rb1Week.Checked && Validator.KollaTextfältUrl(url))
            {
                    Xmlreader.LaddaPodcastTillXML(url, cbSelect, 604800000);
                MessageBox.Show("Podcasten är nu tillagd!");
            }

            
           
                

            

        
            

            //Logic.Xmlreader.LaddaPodcastTillXML(url, cbSelect);
        
            


        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
                lbEpisod.Items.Clear();
                lbEInfo.Clear();
                tbTitle.Clear();
                var listboxItem = lbPodcast.SelectedItem.ToString();
                //string url = Logic.Xmlreader.hamtaUrlFrånValdPodcast(listboxItem);
                var episoder = Logic.Xmlreader.hamtaEpisodeTitlar(listboxItem);

                foreach (var episod in episoder)
                {
                    lbEpisod.Items.Add(episod);

                }
            

         
        }





        

        private void cbChooseKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbEpisod_MouseClick(object sender, MouseEventArgs e)
        {
                var selectedItemP = lbPodcast.SelectedItem.ToString();
                var selectedItem = lbEpisod.SelectedItem.ToString();

                string Info = Logic.Xmlreader.hamtaEpisodInfo(selectedItem, selectedItemP);
                lbEInfo.Text = Info;
                tbTitle.Text = selectedItem;
                Xmlreader.visaSpelad(selectedItem, selectedItemP);
            
          




        }

        private void button3_Click(object sender, EventArgs e)
        {

            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "http://media.acast.com/varvet/-251-anithaschulman/media.mp3";
            player.controls.play();


        }

        private void Player_Enter(object sender, EventArgs e)
        {
           var podcast = lbPodcast.SelectedItem.ToString();
            var episod = lbEpisod.SelectedItem.ToString();

            var url = Logic.Xmlreader.hamtaUrlFranValdPodcast(episod, podcast);

            Player.URL = url;

            Xmlreader.ändraOmEpisodeÄrSpelad(episod, podcast);
            
        }

        private void cbChooseKat_MouseClick_1(object sender, MouseEventArgs e)
        {
            Logic.Xmlreader.uppdateraKategoriLista(cbKat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbChooseKat_MouseClick_2(object sender, MouseEventArgs e)
        {
            Xmlreader.uppdateraKategoriLista(cbChooseKat);
        }

        private void cbKat_MouseClick_1(object sender, MouseEventArgs e)
        {
            Xmlreader.uppdateraKategoriLista(cbKat);
        }

        private void lbPodcast_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveP_Click(object sender, EventArgs e)
        {
            var cbSelect = cbChooseKat.GetItemText(cbChooseKat.SelectedItem);
            var podcast = lbPodcast.SelectedItem.ToString();
            Xmlreader.RemovePodcast(podcast);
            lbPodcast.Items.Remove(lbPodcast.SelectedItem);
            lbEpisod.Items.Clear();
            lbEInfo.Clear();
            

        }
    }
}
