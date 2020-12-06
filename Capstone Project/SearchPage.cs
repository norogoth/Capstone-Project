using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    public partial class SearchForm : Form
    {
        //public TextBox searchBox;
        public SearchForm()
        {
            InitializeComponent();
            playerNameListBox.DisplayMember = "fullName";
            setListView(Data.PitcherIdList.Values, playerNameListBox);
        }
        private static void setListView(Dictionary<String, Pitcher>.ValueCollection pitcherList, ListBox listBox)
        {
            foreach (Pitcher pitcher in pitcherList)
            {
                listBox.Items.Add(pitcher);
            }
        }
        private static void setListView(List<Pitcher> pitcherList, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Pitcher pitcher in pitcherList)
            {
                listBox.Items.Add(pitcher);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length >= 3 || searchBox.Text.Length == 0)
            {
                List<Pitcher> pitcherList = Data.searchPitcher(searchBox.Text);
                Console.WriteLine("The length of this list is " + pitcherList.Count);
                setListView(pitcherList, playerNameListBox);

            }
        }
        private void searchBox_KeyDown(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
/*            Console.WriteLine("key is down.");
            TextBox searchBox = sender as TextBox;
            if (searchBox.Text.Length >= 2)
            {
                //Perform search in the list below.
            }*/
        }

        private void Loading_Click(object sender, EventArgs e)
        {

        }

        private void playerNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.selectedPitcher = (Pitcher) playerNameListBox.SelectedItem;
            StatPage statPage = new StatPage();
            statPage.Show();
        }
    }
}
