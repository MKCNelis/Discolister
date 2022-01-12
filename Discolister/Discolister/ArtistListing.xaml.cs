using Discolister.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Discolister
{
    /// <summary>
    /// Interaction logic for ArtistListing.xaml
    /// </summary>
    public partial class ArtistListing : Window
    {
        List<Bands> bands;
        public ArtistListing()
        {
            InitializeComponent();
           bands = new List<Bands>();
            ReadDatabase();
        }

        void ReadDatabase()
        {
            // connects the strDatabasePath
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.sDataBasePath))
            {
                connection.CreateTable<Bands>();
                bands = (connection.Table<Bands>().ToList()).OrderBy(c => c.sBandName).ToList();
            }
            // checks if the list is not empty show in the LstSongslist
            if (bands != null)
            {
                // shows where the Songs in the ListView
                LstBandslist.ItemsSource = bands;
            }
        }


        private void LstBandslist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //which contact is selected
            Bands selectedBands = (Bands)LstBandslist.SelectedItem;
            //update lint to update editArtist
            if (selectedBands != null)
            {
                EditArtist editArtist = new EditArtist(selectedBands);
                editArtist.ShowDialog();

            }
        }

        private void AddArtist_Click(object sender, RoutedEventArgs e)
        {// go to add Artist showed by a Dialogbox
            AddArtist addArtist = new AddArtist();
            addArtist.ShowDialog(); 
        }
    }

}
