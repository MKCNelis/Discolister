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
    /// Interaction logic for EditArtist.xaml
    /// </summary>
    public partial class EditArtist : Window
    {
        Bands bands;
        public EditArtist( Classes.Bands selectedBands)
        {
            InitializeComponent();
            this.bands = selectedBands;
            _txtsBandName.Text = bands.sBandName;
            _txtsBandSummary.Text = bands.sBandSummary;
            _txtsSongTitle.Text = bands.sSongTitle;

        }

        private void EditSongSubmit_Click(object sender, RoutedEventArgs e)
        {
            //update bands
            SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
            bands.sBandName = _txtsBandName.Text;
            bands.sBandSummary = _txtsBandSummary.Text;
            bands.sSongTitle = _txtsSongTitle.Text;
            {
                connection.CreateTable<Bands>();
                connection.Update(bands);
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

            _txtsBandName.Text = "";
            _txtsBandSummary.Text = "";
            _txtsSongTitle.Text = "";

        }

        private void RegisterSongCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RegisterARtistDelete_Click(object sender, RoutedEventArgs e)
        {
            {
                //delete
                SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
                {
                    connection.CreateTable<Bands>();
                    connection.Delete(bands);
                }

                Close();
            }
        }
    }
}
