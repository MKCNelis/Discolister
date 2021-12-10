using Discolister.Classes;
using SQLite;
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
    /// Interaction logic for EditMusic.xaml
    /// </summary>
    public partial class EditMusic : Window

    {
        Songs songs;
        public EditMusic(Classes.Songs selectedSongs)
        {
            InitializeComponent();
            this.songs = selectedSongs;
            _txtsSongName.Text = songs.sSongName;
            _txtsSongSummary.Text = songs.sSongSummary;
            _txtsAlbumTitle.Text = songs.sAlbumTitle;
        }

        private void EditSongSubmit_Click(object sender, RoutedEventArgs e)
        {

            //update
            SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
            songs.sSongName = _txtsSongName.Text;
            songs.sSongSummary = _txtsSongSummary.Text;
            songs.sAlbumTitle = _txtsAlbumTitle.Text;
            songs.sSongPath = _txtsSongPath.Text;
            {
                connection.CreateTable<Songs>();
                connection.Update(songs);
            }
            Close();

        }
       
        private void RegisterSongReset_Click(object sender, RoutedEventArgs e)
        {
            {
                Reset();
            }
        }

        private void Reset()
        {

            _txtsSongName.Text = "";
            _txtsSongSummary.Text = "";
            _txtsAlbumTitle.Text = "";

        }

        private void RegisterSongCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    

        private void RegisterSongDelete_Click(object sender, RoutedEventArgs e)
        {
            //delete
            SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
            {
                connection.CreateTable<Songs>();
                connection.Delete(songs);
            }

            Close();
        }
    }
}
