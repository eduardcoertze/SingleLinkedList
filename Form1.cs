using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList
{
    public partial class Form1 : Form
    {

        SLinkedLists sLinked = new SLinkedLists();
        List<String> songsList = new List<string>();
        public Form1()
        {

            InitializeComponent();

            //appendling songs to linked list
            sLinked.append("Stairway to Heaven");
            sLinked.append("Heart-Shaped Box");
            sLinked.append("Come as You Are");

            //prepending songs
            sLinked.prepend("Sweet Child o Mine");

            //inserting songs after a perticular node
            sLinked.insertAfter("Comfortably Numb", "Heart-Shaped Box");

            //showing the songs
            songsList = sLinked.showNext();

            reloadList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //method to reload listbox
        public void reloadList()
        {
            lstsongs.Items.AddRange(songsList.ToArray());
        }
    }
}
