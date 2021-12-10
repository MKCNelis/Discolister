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
    /// Interaction logic for AlbumListing.xaml
    /// </summary>
    public partial class AlbumListing : Window
    {
        List<Albums> albums;
        public AlbumListing()
        { 
            InitializeComponent();
            albums = new List<Albums>();
            ReadDatabase();
        }

        private void AddAlbum_Click(object sender, RoutedEventArgs e)
        {
            AddAlbum addAlbum = new AddAlbum();
            addAlbum.ShowDialog();
            ReadDatabase();
        }
        void ReadDatabase()
        {
            // connects the strDatabasePath
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.sDataBasePath))
            {
                connection.CreateTable<Albums>();
                albums=(connection.Table<Albums>().ToList()).OrderBy(c=>c.sAlbumTitle).ToList();
            }
            // check if list == empty
            if (albums != null)
            {//show where content is in listview
                LstAlbumslist.ItemsSource = albums;

            }
        }

        private void LstAlbumslist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {       //
            Albums selectedAlbum = (Albums)LstAlbumslist.SelectedItem;
            if (selectedAlbum != null)
            {
                EditAlbum editAlbum = new EditAlbum(selectedAlbum);
                editAlbum.ShowDialog();
            }

        }
    }
}

