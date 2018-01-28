using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var katName = txfAddCategory.Text;
            Logic.Category newCategory = new Logic.Category(katName);          
      
            Logic.Xmlreader.sparaKatNamn(newCategory);

            MessageBox.Show(katName + " är nu tillagd!");

        }

    

        object currentMyComboBoxItem;

        private void cbRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMyComboBoxItem = cbRemove.SelectedItem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Logic.Xmlreader.laddaKategoriXml(cbRemove);
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Logic.Xmlreader.RemoveXmlFile(cbRemove.SelectedItem.ToString());
            

            string message = "Är du säker att du vill ta bort "+ cbRemove.SelectedItem.ToString()+" ?";
            DialogResult button = MessageBox.Show(message, "confirm delete", MessageBoxButtons.YesNo);
            if(button == DialogResult.Yes)
            {
                Logic.Xmlreader.uppdateraKategoriLista(cbRemove);
            }

            Xmlreader.taBortPodcasterMedValdkat("Nyheter");





            //string XmlKategorier = "C:\\Users\\Tomas\\Pictures\\CSharpProjectEmpty (3)\\CSharpProjectEmpty\\Data\\Kategorier.xml";
            //XmlDocument doc = new XmlDocument();
            //doc.Load(XmlKategorier);
            //XmlNodeList nodes = doc.SelectNodes("//Setting[@name='"+ currentMyComboBoxItem+"']");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Logic.Validator.KollaTextSkapaKategori(tbÄndraKat.Text))
            {
                var nyKategori = tbÄndraKat.Text;
                var valdKategori = cbRemove.SelectedItem.ToString();

                Logic.Xmlreader.editCategory(nyKategori, valdKategori);
            }
        }

        private void tbÄndraKat_MouseClick(object sender, MouseEventArgs e)
        {
            var nyKategori = cbRemove.SelectedItem.ToString();
            tbÄndraKat.Text = nyKategori;
        }

        private void tbÄndraKat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
