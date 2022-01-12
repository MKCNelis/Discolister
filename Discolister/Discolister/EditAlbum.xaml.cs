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
    /// Interaction logic for EditAlbum.xaml
    /// </summary>
    public partial class EditAlbum : Window
    {
        Albums albums;
        public EditAlbum(Classes.Albums selectedAlbums)
        {
            InitializeComponent();
            this.albums = selectedAlbums;
            _txtsAlbumName.Text = albums.sAlbumTitle;
            _txtsAlbumSummary.Text = albums.sAlbumSummary;
            _txtsBandName.Text = albums.sBandName;
        }

        private void EditSongSubmit_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
            albums.sAlbumTitle = _txtsAlbumName.Text;
            albums.sAlbumSummary= _txtsAlbumSummary.Text;
            albums.sBandName = _txtsBandName.Text;
            {
                connection.CreateTable<Albums>();
                connection.Update(albums);
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
            _txtsAlbumName.Text = "";
            _txtsAlbumName.Text = "";
            _txtsBandName.Text = "";
        }

        private void RegisterSongCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void RegisterAlbumDelete_Click(object sender, RoutedEventArgs e)
        {
            //delete
        SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
            {
                connection.CreateTable<Albums>();
                connection.Delete(albums);
            }

            Close();
        }
    }
}
