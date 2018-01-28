using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public static class Validator
    {
        public static bool KollaTextSkapaKategori(string textfält)
        {
            bool result = true;
            if (textfält == "") {
                result = false;
                MessageBox.Show("Välj en kategori");
            }
            return result;
        }

        public static bool KollaTextfältUrl(string textbox)
        {
            bool result = true;
            if (textbox == "" || textbox == null)
            {
                result = false;
                MessageBox.Show("Ange url för din podcast");
            }
            return result;
           
        }

        public static bool kategoriVald(ComboBox cb)
        {
            bool result = true;
            if(cb.SelectedItem == null)
            {
                result = false;
                MessageBox.Show("Var god välj en kategori!");
            }

            return result;

           
           

        }

        public static bool kollaKlickPodcast(ListBox listboxP)
        {
            bool result = true;
            if (listboxP == null)
            {
                result = false;
                throw new ArgumentNullException();
            }
            return result;
            

        }

        public static bool kollaKlickEpisode(ListBox listbox, ListBox listboxP)
        {
            bool result = true;
            if (listbox == null && listboxP == null)
            {
                result = false;                
                MessageBox.Show("Klicka på ett avsnitt");
            }
            return result;
            
        }

  


    }
}
