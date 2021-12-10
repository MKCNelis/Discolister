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
    /// Interaction logic for AdminScreen.xaml
    /// </summary>
    public partial class AdminScreen : Window
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        //have to look at menu
   

        private void MusicListing_Click(object sender, RoutedEventArgs e)
        {
            MusicListing musicListing = new MusicListing();
            musicListing.ShowDialog();
        }

        private void AlbumListing_Click(object sender, RoutedEventArgs e)
        {
            AlbumListing albumListing = new AlbumListing();
            albumListing.ShowDialog();
        }

        private void ArtistListing_Click(object sender, RoutedEventArgs e)
        {
            ArtistListing artistListing = new ArtistListing();
            artistListing.ShowDialog();
        }

    }
}
