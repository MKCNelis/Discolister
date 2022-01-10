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
    /// Interaction logic for AddAlbum.xaml
    /// </summary>
    public partial class AddAlbum : Window
    {
        public AddAlbum()
        {
            InitializeComponent();
        }

        private void RegisterAlbumSubmit_Click(object sender, RoutedEventArgs e)
        { //add entries to albums 
            Albums albums = new Albums()
            {
               sAlbumTitle= txtsAlbumName.Text, //declare type string == type Text
               sAlbumSummary = txtsAlbumSummary.Text,//declare type string == type Text
                sBandName = txtBandName.Text //declare type string == type Text


            };
            //Destanation
            using (SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath))
            {

                //input in database
                connection.CreateTable<Albums>();
                connection.Insert(albums);

            }

            Close();
        
        }

              private void RegisterAlbumCancel_Click(object sender, RoutedEventArgs e)
        {
            {
                {
                    Reset();
                }

            }
            void Reset()
            {// delcare that values are now empty
                txtsAlbumName.Text = "";
                txtsAlbumSummary.Text = "";
                txtBandName.Text = "";
            }
        }

        private void RegisterAlbumReset_Click(object sender, RoutedEventArgs e)
        { // jusr close the window to cancel everything
            Close();
        }

     
    }
}
