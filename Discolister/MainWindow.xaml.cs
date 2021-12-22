using Discolister.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
     
        public MainWindow()
        {
            InitializeComponent();
          
        }
        SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!ValidLogin)
                {
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;
                    
                    string Statment;
                    //DBConnections
                    SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
                    {
                        //SQLite.Open();
                        Statment = $"SELECT EXISTS FROM Users WHERE Username='eUserName'";
                        if((Int64) new SQLiteCommand(Statment, sSQLite).ExecuteScalar() == 0) 
                        {
                            
                        }
                    }
                    
                }
            }
       
                  
           
        }
        // butti to go to Registation window  new
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ShowDialog();
        }

        //=====================================func validi login========================
        private bool ValidLogin()
        {
            string message = "Enter a ";
            if(txtUsername.Text == "")
            {
                message += "Username";
            }
            if (txtPassword.Text == "")
            {
                if (txtUsername.Text == "")
                {
                    message += "and a ";
                }
                message += "password";
                }
                if (Message != "Enter a ")
                {
                    LoginLabelError.Text = Message;
                LoginLabelError.Left = (LoginPanel.Width - LoginLabelError.Width) / 2;
                LoginLabelError.Visible = true;
                return false;
            }
            }
        //=====================================func validi login========================





        public void GrantedAcces() 
        {
        MenuScreen menuScreen = new MenuScreen();
            menuScreen.ShowDialog();
        }
    }
}
