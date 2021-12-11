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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Discolister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Users users;
        public MainWindow(Classes.Users Getusers)
        {
            InitializeComponent();
            users();
        }
     

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var sUsername = txtUsername.Text;
            var sPassword = txtPassword.Text;

            // check if the cridentials are alright
            bool userfound = Users.(users => users.Name == eUsername && users.Password == ePassword);
            if (sUsername == users.eUserName || sPassword == users.ePassword )
            {
                GrantedAcces();
              
            } else {
                Messagebox.Text = " inlog has failed"; //displayed message if login has faied
            }
                
        }
        /// <summary>
        ///  thlogin has to check if the cridentials are correct an coserpond with users 
        /// <summary>

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ShowDialog();
        }

        public void GrantedAcces() 
        {
        MenuScreen menuScreen = new MenuScreen();
            menuScreen.ShowDialog();
        }
    }
}
