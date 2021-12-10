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
    /// Interaction logic for AddSong.xaml
    /// </summary>
    public partial class AddSong : Window
    {
        public AddSong()
        {
            InitializeComponent();
        }
        private void RegisterSongSubmit_Click(object sender, RoutedEventArgs e)
        {
            Songs songs = new Songs()
            {


                sSongName = txtsSongName.Text,
                sSongSummary = txtsSongSummary.Text,
                sAlbumTitle = txtsAlbumTitle.Text

            };
            //Destanation
            using (SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath))
            {

                //input in database
                connection.CreateTable<Songs>();
/*
                string QueryName1 = connection.Query.< Songs > ($"SELECT Album_ID FROM Albums WHERE AlbumTitle = "{ 'txtsAlbumTitle'}
                "[0]).Album_ID;
                string QueryName2 = connection.Query.< Albums > ($"SELECT Song_ID FROM Songs WHERE SongName = "{ 'txtsSongName'}
                "[0]).Song_ID;
                connection.Query.< Songs > ($"UPDATE Songs SET AlbumFK_ID = "{ QueryName1}, " WHERE Song_ID = "{ QueryName2}, "")[0];

                //Confirm
*/
                connection.Insert(songs);

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

            txtsSongName.Text = "";
            txtsSongSummary.Text = "";
            txtsAlbumTitle.Text = "";

        }

        private void RegisterSongCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    } 
}
    
