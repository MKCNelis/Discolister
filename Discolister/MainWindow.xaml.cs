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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Discolister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Users users;
        public MainWindow()
        {
            InitializeComponent();
        }
        public TextBox txtUsername { get; private set; }
        public TextBox txtPassword { get; private set; }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
  //if (Password == txtPassword || Username == txtUsername)
            {
                MenuScreen menuScreen = new MenuScreen();
                menuScreen.ShowDialog();
            }
        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ShowDialog();
        }
    }
}
