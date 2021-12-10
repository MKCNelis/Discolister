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
    /// Interaction logic for MusicListing.xaml
    /// </summary>
    public partial class MusicListing : Window
    {
        List<Songs> songs;

        public MusicListing()
        {
            InitializeComponent();
            songs = new List<Songs>();
            ReadDatabase();
        }
        void ReadDatabase()
        {
            // connects the strDatabasePath
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.sDataBasePath))
            {
                connection.CreateTable<Songs>();
               songs = (connection.Table<Songs>().ToList()).OrderBy(c => c.sSongName).ToList();
            }
            // checks if the list is not empty show in the LstContacslist
            if (songs != null)
            {
                // shows where the contacts in the ListView
                LstSongslist.ItemsSource = songs;
            }
        }
    

        private void LstSongslist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //which contact is selected
            Songs selectedSongs = (Songs)LstSongslist.SelectedItem;
            //update lint to update NewContactDetailWindow
            if (selectedSongs != null)
            {
                EditMusic editMusic = new EditMusic(selectedSongs);
                editMusic.ShowDialog();
            
            }
        }
                private void AddSong_Click(object sender, RoutedEventArgs e)
        {
            AddSong addSong = new AddSong();
            addSong.ShowDialog();
        }

       
    }
}
