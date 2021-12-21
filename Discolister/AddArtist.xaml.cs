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
    /// Interaction logic for AddArtist.xaml
    /// </summary>
    public partial class AddArtist : Window
    {
        public AddArtist()
        {
            InitializeComponent();
        }

        private void RegisterArtistSubmit_Click(object sender, RoutedEventArgs e)
        {
            Bands bands = new Bands()
            { // data that will be stored
               sBandName = txtsBandName.Text,
               sBandSummary = txtsBandSummary.Text,
               sSongTitle = txtSongName.Text


          };
            //Destanation
            using (SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath))
            {

                //input in database
                connection.CreateTable<Bands>();
                connection.Insert(bands);

            }
            //Close window
            Close();
        }

        private void RegisterArtistReset_Click(object sender, RoutedEventArgs e)
        {
            {
                {
                    Reset();
                }

            }
            //function of reset
            void Reset()
            { // reset the fields
                txtsBandName.Text = "";
                txtsBandSummary.Text = "";
                txtSongName.Text = "";
            }
        }

        private void RegisterArtistCancel_Click(object sender, RoutedEventArgs e)
        { //cancel actions by closing screen
            Close();

        }
    }
}
