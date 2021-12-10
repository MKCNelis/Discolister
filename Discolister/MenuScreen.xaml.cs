using Discolister.Classes;
using Microsoft.Win32;
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
using System.Windows.Threading;

namespace Discolister
{
    /// <summary>
    /// Interaction logic for menuScreen.xaml
    /// </summary>
    public partial class MenuScreen : Window
    {
		private MediaPlayer mediaPlayer = new MediaPlayer();
        List<Songs> songs;
        public MenuScreen()
		{
			InitializeComponent();
			//======================  musi/c player controls==========================================================
			OpenFileDialog openFileDialog = new OpenFileDialog(); // open a 
			openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*"; // filter  file type 
			if (openFileDialog.ShowDialog() == true)
				mediaPlayer.Open(new Uri(openFileDialog.FileName));

			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			//timer.Tick += timer_Tick;
			timer.Start();
		}

		/*void timer_Tick(object sender, EventArgs e)
		{
			if (mediaPlayer.Source != null)
				lblStatus.Content = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss")); //format time as minutes an seconds
			else
				lblStatus.Content = "No file selected..."; // if no file is found display message
		}*/
		//if audio is loaden playbutton
		private void btnPlay_Click(object sender, RoutedEventArgs e)
		{
			mediaPlayer.Play();
		}
		//if audio is loaden pause button

		private void btnPause_Click(object sender, RoutedEventArgs e)
		{
			mediaPlayer.Pause();
		}
		//if audio is loaden stopbutton

		private void btnStop_Click(object sender, RoutedEventArgs e)
		{
			mediaPlayer.Stop();
		}
		//====================== end of musi/c player controls==========================================================

		//admin screenbutton

		private void admin_Click(object sender, RoutedEventArgs e)
        {
            Close();
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.ShowDialog();
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
                mediaPlayer.Open(new Uri(selectedSongs.sSongPath));

            }
        }



    }
}
